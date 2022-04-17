using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class ChessBoardForm : Form
    {
        public ChessBoardForm() => this.InitializeComponent();

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void button2_Click(object sender, EventArgs e) => this.tableLayoutPanel1.Size += new Size(20, 20);

        private void button3_Click(object sender, EventArgs e) => this.tableLayoutPanel1.Size -= new Size(20, 20);

        private void BlackPawn_Click(object sender, EventArgs e)
        {

        }

        private List<(int, int)> GetPossiblePawnMoves(Control piece)
        {
            int columnCoordinate = this.tableLayoutPanel1.GetColumn(piece);
            int rowCoordinate    = this.tableLayoutPanel1.GetRow(piece);
            switch (rowCoordinate)
            {
                // На последней горизонтали
                case 0:
                    return new List<(int, int)>();
                // Если пешка в начальном положении.
                case 6:
                    return new List<(int, int)>
                           {
                               (columnCoordinate, 5),
                               (columnCoordinate, 4)
                           };
                default:
                    // Если пешка в центре доски.
                    return new List<(int, int)>
                           {
                               (columnCoordinate, rowCoordinate - 1),
                           };
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }
    }
}
