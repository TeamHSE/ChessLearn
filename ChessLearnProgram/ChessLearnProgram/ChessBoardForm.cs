using System;
using System.Windows.Forms;
using Chess;
using Chess.Pieces;

namespace ChessLearnProgram
{
    internal sealed partial class ChessBoardForm : Form
    {
        public ChessBoardForm()
        {
            this.InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Добавить Pawn на поле.
            var pawn = new Pawn(new Coordinate(0, 0), "White");
            ChessBoard.ChessBoardMatrix[pawn.CurrentCoordinate.Column, pawn.CurrentCoordinate.Row] = pawn;
            this.UpdateChessBoard();
        }

        private void UpdateChessBoard()
        {
            this.tableLayoutPanel1.Controls.Clear();
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    if (ChessBoard.ChessBoardMatrix[i, j] != null)
                    {
                        this.tableLayoutPanel1.Controls.Add(ChessBoard.ChessBoardMatrix[i, j], i, j);
                    }
                }
            }
        }
    }
}
