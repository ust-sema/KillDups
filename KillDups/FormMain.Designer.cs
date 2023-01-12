namespace KillDups
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectFolders = new System.Windows.Forms.Button();
            this.buttonDeDup = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDupes = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.cDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.backgroundWorkerScan = new System.ComponentModel.BackgroundWorker();
            this.buttonCancelScan = new System.Windows.Forms.Button();
            this.labelPercent = new System.Windows.Forms.Label();
            this.timerDots = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectFolders
            // 
            this.buttonSelectFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolders.Location = new System.Drawing.Point(969, 39);
            this.buttonSelectFolders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectFolders.Name = "buttonSelectFolders";
            this.buttonSelectFolders.Size = new System.Drawing.Size(126, 32);
            this.buttonSelectFolders.TabIndex = 0;
            this.buttonSelectFolders.Text = "Select Folder";
            this.buttonSelectFolders.UseVisualStyleBackColor = true;
            this.buttonSelectFolders.Click += new System.EventHandler(this.buttonSelectFolders_Click);
            // 
            // buttonDeDup
            // 
            this.buttonDeDup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeDup.Location = new System.Drawing.Point(1204, 39);
            this.buttonDeDup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeDup.Name = "buttonDeDup";
            this.buttonDeDup.Size = new System.Drawing.Size(174, 32);
            this.buttonDeDup.TabIndex = 1;
            this.buttonDeDup.Text = "Scan for duplicates";
            this.buttonDeDup.UseVisualStyleBackColor = true;
            this.buttonDeDup.Click += new System.EventHandler(this.buttonDeDup_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(27, 95);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(65, 20);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(160, 95);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1375, 20);
            this.progressBar1.TabIndex = 3;
            // 
            // labelDupes
            // 
            this.labelDupes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDupes.AutoSize = true;
            this.labelDupes.Location = new System.Drawing.Point(27, 708);
            this.labelDupes.Name = "labelDupes";
            this.labelDupes.Size = new System.Drawing.Size(119, 20);
            this.labelDupes.TabIndex = 4;
            this.labelDupes.Text = "Duplicate files: 0";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(27, 39);
            this.textBoxFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(934, 27);
            this.textBoxFolder.TabIndex = 5;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDel,
            this.cName,
            this.cSize,
            this.cGroup,
            this.cHash});
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.RowHeadersWidth = 51;
            this.dataGridViewFiles.RowTemplate.Height = 25;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFiles.Size = new System.Drawing.Size(1144, 543);
            this.dataGridViewFiles.TabIndex = 6;
            this.dataGridViewFiles.SelectionChanged += new System.EventHandler(this.dataGridViewFiles_SelectionChanged);
            // 
            // cDel
            // 
            this.cDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDel.FillWeight = 3F;
            this.cDel.HeaderText = "Delete";
            this.cDel.MinimumWidth = 6;
            this.cDel.Name = "cDel";
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.FillWeight = 67F;
            this.cName.HeaderText = "File name";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cSize
            // 
            this.cSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cSize.FillWeight = 10F;
            this.cSize.HeaderText = "Size";
            this.cSize.MinimumWidth = 6;
            this.cSize.Name = "cSize";
            this.cSize.ReadOnly = true;
            // 
            // cGroup
            // 
            this.cGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cGroup.FillWeight = 5F;
            this.cGroup.HeaderText = "Group";
            this.cGroup.MinimumWidth = 6;
            this.cGroup.Name = "cGroup";
            this.cGroup.ReadOnly = true;
            // 
            // cHash
            // 
            this.cHash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cHash.FillWeight = 15F;
            this.cHash.HeaderText = "Hash";
            this.cHash.MinimumWidth = 6;
            this.cHash.Name = "cHash";
            this.cHash.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(29, 148);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxPreview);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 543);
            this.splitContainer1.SplitterDistance = 1144;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(357, 543);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(1352, 703);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(183, 31);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete selected files";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // backgroundWorkerScan
            // 
            this.backgroundWorkerScan.WorkerReportsProgress = true;
            this.backgroundWorkerScan.WorkerSupportsCancellation = true;
            this.backgroundWorkerScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerScan_DoWork);
            this.backgroundWorkerScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerScan_ProgressChanged);
            this.backgroundWorkerScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerScan_RunWorkerCompleted);
            // 
            // buttonCancelScan
            // 
            this.buttonCancelScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelScan.Location = new System.Drawing.Point(1397, 39);
            this.buttonCancelScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelScan.Name = "buttonCancelScan";
            this.buttonCancelScan.Size = new System.Drawing.Size(138, 32);
            this.buttonCancelScan.TabIndex = 9;
            this.buttonCancelScan.Text = "Cancel scan";
            this.buttonCancelScan.UseVisualStyleBackColor = true;
            this.buttonCancelScan.Click += new System.EventHandler(this.buttonCancelScan_Click);
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPercent.Location = new System.Drawing.Point(94, 92);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(70, 23);
            this.labelPercent.TabIndex = 10;
            this.labelPercent.Text = "100%...";
            // 
            // timerDots
            // 
            this.timerDots.Enabled = true;
            this.timerDots.Interval = 500;
            this.timerDots.Tick += new System.EventHandler(this.timerDots_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 760);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.buttonCancelScan);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.labelDupes);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonDeDup);
            this.Controls.Add(this.buttonSelectFolders);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Find and delete duplicate files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonSelectFolders;
        private Button buttonDeDup;
        private Label labelInfo;
        private ProgressBar progressBar1;
        private Label labelDupes;
        private TextBox textBoxFolder;
        private DataGridView dataGridViewFiles;
        private DataGridViewCheckBoxColumn cDel;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cSize;
        private DataGridViewTextBoxColumn cGroup;
        private DataGridViewTextBoxColumn cHash;
        private SplitContainer splitContainer1;
        private PictureBox pictureBoxPreview;
        private Button buttonDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorkerScan;
        private Button buttonCancelScan;
        private Label labelPercent;
        private System.Windows.Forms.Timer timerDots;
    }
}