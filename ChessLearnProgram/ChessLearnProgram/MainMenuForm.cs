using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class MainMenuForm : Form
    {
        public MainMenuForm() => this.InitializeComponent();

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form2 = new SettingsForm();
            form2.Show();
        }
    }
}
