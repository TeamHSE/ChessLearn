using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    public partial class HowToFiguresLesson : Form
    {
        public HowToFiguresLesson()
        {
            this.InitializeComponent();
        }


        private void HowToPawnButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadPawnScene();
            chessBoardForm.ShowDialog();
        }
    }
}

