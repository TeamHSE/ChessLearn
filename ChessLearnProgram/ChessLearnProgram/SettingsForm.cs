using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            this.InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void FullScreenСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveForm == null)
            {
                return;
            }

            if (!this.FullScreenСheckBox.Checked)
            {
                ActiveForm.TopMost              = false;
                ActiveForm.FormBorderStyle      = FormBorderStyle.Sizable;
                ActiveForm.WindowState          = FormWindowState.Normal;
                this.FullScreenСheckBox.Checked = true;
                return;
            }

            this.Dispose();
            ActiveForm.TopMost              = true;
            ActiveForm.FormBorderStyle      = FormBorderStyle.None;
            ActiveForm.WindowState          = FormWindowState.Maximized;
            this.FullScreenСheckBox.Checked = false;
        }
    }
}
