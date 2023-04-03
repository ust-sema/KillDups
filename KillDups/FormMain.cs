using System.Security.Cryptography;
using System.Text;

namespace KillDups
{
    public partial class FormMain : Form
    {
        static List<FileInfo> files = new List<FileInfo>();
        static List<Tuple<FileInfo, string, int>> dupes = new List<Tuple<FileInfo, string, int>>();
        static string tick = "";
        const string formHeader = "Find and delete duplicate files";
        static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

        public FormMain()
        {
            InitializeComponent();
            EnableUI(true);
        }

        private void buttonSelectFolders_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != null)
            {
                textBoxFolder.Text = folderBrowserDialog1.SelectedPath;
                ClearGrid();
            }
        }

        void FullDirList(DirectoryInfo dir, string searchPattern)
        {
            if (backgroundWorkerScan.CancellationPending) return;

            try
            {
                foreach (FileInfo f in dir.GetFiles(searchPattern))
                {
                    files.Add(f);
                }
            }
            catch
            {

            }

            try
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    FullDirList(d, searchPattern);
                }
            }
            catch (Exception)
            {

            }

        }

        void ProcessFiles()
        {
            var groups = files
                .GroupBy(f => f.Length)
                .Select(g => new { Size = g.Key, Files = g.ToList() });

            var hashes = new List<Tuple<FileInfo, string>>();

            var dupGroup = 1;
            var dupSizes = new List<FileInfo>();

            foreach (var group in groups)
            {
                if (group.Files.Count == 1) continue;
                dupSizes.AddRange(group.Files);
            }

            var percent = 0;
            var step = dupSizes.Count / 100;
            var counter = 0;

            foreach (var ds in dupSizes)
            {
                var hash = GetHash(ds.FullName);
                if (hash != null)
                {
                    hashes.Add(new Tuple<FileInfo, string>(ds, hash));
                }

                if (counter > step)
                {
                    percent++;
                    counter = 0;
                    backgroundWorkerScan.ReportProgress(percent);

                }

                counter++;

                if (backgroundWorkerScan.CancellationPending) break;
            }

            var dupgroup = hashes
                .GroupBy(h => h.Item2)
                .Where(g => g.Count() > 1)
                .Select(w => new { Hash = w.Key, Dupes = w.ToList() });

            foreach (var dup in dupgroup)
            {
                if (backgroundWorkerScan.CancellationPending) break;

                dupes.AddRange(dup.Dupes.Select(d => new Tuple<FileInfo, string, int>(d.Item1, d.Item2, dupGroup)));
                dupGroup++;
            }
        }

        string? GetHash(string file)
        {
            using (var md5 = MD5.Create())
            {
                try
                {
                    using (var stream = File.OpenRead(file))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                catch (Exception)
                {
                    return null;
                }

            }
        }

        private void buttonDeDup_Click(object sender, EventArgs e)
        {
            EnableUI(false);
            ClearGrid();
            backgroundWorkerScan.RunWorkerAsync();
        }

        void FillGrid()
        {
            ClearGrid();

            var group = 0;
            var mark = false;

            dupes.ForEach(d =>
            {
                if (group != d.Item3)
                {
                    group = d.Item3;
                    mark = false;
                }
                else
                {
                    mark = true;
                }
                var row = new object[] { mark, d.Item1.FullName, d.Item1.Length, d.Item3, d.Item2 };
                dataGridViewFiles.Rows.Add(row);
            });
        }

        void ClearGrid()
        {
            dataGridViewFiles.Rows.Clear();
            pictureBoxPreview.Image = null;
            labelDupes.Text = "";
        }

        private void dataGridViewFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFiles.SelectedCells.Count == 0) return;
            var file = dataGridViewFiles.Rows[dataGridViewFiles.SelectedCells[0].RowIndex].Cells["cName"].Value.ToString();

            try
            {
                pictureBoxPreview.Load(file);
            }
            catch (Exception)
            {
                pictureBoxPreview.Image = null;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var rows2delete = 0;
            var log = new StringBuilder();
            var errors = 0;

            foreach (var row in dataGridViewFiles.Rows)
            {
                if ((bool)((DataGridViewRow)row).Cells["cDel"].Value)
                {
                    rows2delete++;
                }
            }

            if (rows2delete == 0) return;


            if (MessageBox.Show($"Are you sure to delete {rows2delete} selected files?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var deleted = 0;
                pictureBoxPreview.Image = null;

                foreach (var row in dataGridViewFiles.Rows)
                {
                    if ((bool)((DataGridViewRow)row).Cells["cDel"].Value)
                    {
                        var file = ((DataGridViewRow)row).Cells["cName"].Value.ToString();
                        try
                        {
                            File.Delete(file);
                            deleted++;
                        }
                        catch (Exception ex)
                        {
                            errors++;
                            log.AppendLine(ex.Message);
                        }
                    }
                }

                var logView = new LogView();
                log.AppendLine("Finished.");
                logView.SetLogText(log.ToString(), $"Deleted files: {deleted}, errors: {errors}");
                logView.Show();
                ClearGrid();
            }
        }

        private void backgroundWorkerScan_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            files = new List<FileInfo>();
            dupes = new List<Tuple<FileInfo, string, int>>();

            var dir = new DirectoryInfo(textBoxFolder.Text);
            FullDirList(dir, "*.*");

            ProcessFiles();
        }

        private void backgroundWorkerScan_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;

            var sum = dupes.Sum(d => d.Item1.Length);
            labelDupes.Text = $"Duplicate files: {dupes.Count}, size: {FormatSize(sum / 2)}";

            FillGrid();
            EnableUI(true);
        }

        void EnableUI(bool enabled)
        {
            textBoxFolder.Enabled = enabled;
            buttonSelectFolders.Enabled = enabled;
            buttonDeDup.Enabled = enabled;
            buttonCancelScan.Enabled = !enabled;
            buttonDelete.Enabled = enabled;
            labelPercent.Text = "0%";
            this.Text = formHeader;
            if (enabled)
            {
                timerDots.Stop();
            }
            else
            {
                timerDots.Start();
            }
        }

        private void buttonCancelScan_Click(object sender, EventArgs e)
        {
            backgroundWorkerScan.CancelAsync();
        }

        private void backgroundWorkerScan_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            this.Text = $"{progressBar1.Value}% " + formHeader;
        }

        private void timerDots_Tick(object sender, EventArgs e)
        {
            labelPercent.Text = $"{progressBar1.Value}%{tick}";
            tick += ".";
            if (tick.Length > 3) tick = "";
        }

        static string FormatSize(long size)
        {
            var i = (decimal)size;
            int j = 0;
            while ((long)i / 1024 > 0)
            {
                i /= 1024;
                j++;
            }
            return i.ToString($"0.00 {suffixes[j]}");
        }
    }
}