using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillDups
{
    public partial class LogView : Form
    {
        public LogView()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetLogText(string text, string status)
        {
            textBoxLog.Text = text;
            labelStatus.Text = status;
            textBoxLog.Select(0, 0);
            buttonClose.Focus();
        }

    }
}
