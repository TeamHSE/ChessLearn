using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Knight : ChessPiece
    {
        public Knight(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop = true;
            this.Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize  = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = color == "Black"
                                       ? new Bitmap(ResourceBlack.Knight)
                                       : new Bitmap(ResourceWhite.Knight);

            this.BackgroundImageLayout      = ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize  = 0;
            this.FlatStyle                  = FlatStyle.Flat;
            this.ForeColor                  = System.Drawing.Color.DarkRed;
            this.Location                   = new Point(173, 347);
            this.Margin                     = new Padding(2);
            this.Name                       = "Knight";
            this.Size                       = new Size(53, 54);
            this.TabIndex                   = 7;
            this.UseVisualStyleBackColor    = true;
        }

        private bool IsCorrectMove(int column, int row)
        {
            return IsCorrectCoordinates(column, row)
                && ((ChessBoard.ChessBoardMatrix[column, row]       == null)
                 || (ChessBoard.ChessBoardMatrix[column, row].Color != this.Color)
                 || ChessBoard.ChessBoardMatrix[column, row] is ValidMove);
        }

        public override List<Coordinate> GetValidMoves()
        {
            var validMoves = new List<Coordinate>();
            int column     = this.CurrentCoordinate.Column;
            int row        = this.CurrentCoordinate.Row;

            if (this.IsCorrectMove(column + 1, row - 2))
            {
                validMoves.Add(new Coordinate(row - 2, column + 1));
            }

            if (this.IsCorrectMove(column + 1, row + 2))
            {
                validMoves.Add(new Coordinate(row + 2, column + 1));
            }

            if (this.IsCorrectMove(column + 2, row - 1))
            {
                validMoves.Add(new Coordinate(row - 1, column + 2));
            }

            if (this.IsCorrectMove(column + 2, row + 1))
            {
                validMoves.Add(new Coordinate(row + 1, column + 2));
            }

            if (this.IsCorrectMove(column - 1, row - 2))
            {
                validMoves.Add(new Coordinate(row - 2, column - 1));
            }

            if (this.IsCorrectMove(column - 1, row + 2))
            {
                validMoves.Add(new Coordinate(row + 2, column - 1));
            }

            if (this.IsCorrectMove(column - 2, row - 1))
            {
                validMoves.Add(new Coordinate(row - 1, column - 2));
            }

            if (this.IsCorrectMove(column - 2, row + 1))
            {
                validMoves.Add(new Coordinate(row + 1, column - 2));
            }

            return validMoves;
        }
    }
}
