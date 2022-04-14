using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    public partial class LessonsForm : Form
    {
        public LessonsForm() => this.InitializeComponent();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.ShowDialog();
        }
    }
}

