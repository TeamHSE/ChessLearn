using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class SettingsForm : Form
    {
        public SettingsForm() => this.InitializeComponent();

        private void SettingsForm_Load(object sender, System.EventArgs e) { }

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
                this.WindowState = FormWindowState.Normal;
                return;
            }
            else
            {
                this.TopMost = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
                
            }
            
        }

        private void WayToMoveDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void GraphicsSettingsLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmptyBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
