using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    public sealed partial class HowToFiguresLesson : Form
    {
        internal HowToFiguresLesson()
        {
            this.InitializeComponent();
        }


        private void HowToPawnButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadPawnScene();
            chessBoardForm.ShowDialog();
        }

        private void HowToKingButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadKingScene();
            chessBoardForm.ShowDialog();
        }

        private void HowToBishopButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadBishopScene();
            chessBoardForm.ShowDialog();
        }

        private void HowToRookButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadRookScene();
            chessBoardForm.ShowDialog();
        }

        private void HowToQueenButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadQueenScene();
            chessBoardForm.ShowDialog();
        }

        private void HowToKnightButton_Click(object sender, EventArgs e)
        {
            var chessBoardForm = new ChessBoardForm();
            chessBoardForm.LoadKnightScene();
            chessBoardForm.ShowDialog();
        }
    }
}

