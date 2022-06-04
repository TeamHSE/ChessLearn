using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Bishop : ChessPiece
    {
        public Bishop(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop = true;
            this.Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize  = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = color == "Black"
                                       ? new Bitmap(ResourceBlack.Bishop)
                                       : new Bitmap(ResourceWhite.Bishop);

            this.BackgroundImageLayout      = ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize  = 0;
            this.FlatStyle                  = FlatStyle.Flat;
            this.ForeColor                  = System.Drawing.Color.DarkRed;
            this.Location                   = new Point(173, 347);
            this.Margin                     = new Padding(2);
            this.Name                       = "Bishop";
            this.Size                       = new Size(53, 54);
            this.TabIndex                   = 7;
            this.UseVisualStyleBackColor    = true;
        }

        public override List<Coordinate> GetValidMoves()
        {
            var validMoves = new List<Coordinate>();

            this.UpdateProportionalMoves(ref validMoves);
            this.UpdateDisproportialMoves(ref validMoves);
            return validMoves;
        }

        private void UpdateDisproportialMoves(ref List<Coordinate> validMoves)
        {

            int checkingRow    = this.CurrentCoordinate.Row    + 1;
            int checkingColumn = this.CurrentCoordinate.Column - 1;
            while (IsCorrectCoordinates(checkingRow, checkingColumn))
            {
                if ((ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] == null)
                 || ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] is ValidMove)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    checkingColumn--;
                    checkingRow++;
                }
                else if (ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow].Color
                      != this.Color)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    break;
                }
                else
                {
                    break;
                }
            }

            checkingRow    = this.CurrentCoordinate.Row    - 1;
            checkingColumn = this.CurrentCoordinate.Column + 1;
            while (IsCorrectCoordinates(checkingRow, checkingColumn))
            {
                if ((ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] == null)
                 || ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] is ValidMove)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    checkingColumn++;
                    checkingRow--;
                }
                else if (ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow].Color
                      != this.Color)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private void UpdateProportionalMoves(ref List<Coordinate> validMoves)
        {

            int checkingRow    = this.CurrentCoordinate.Row    + 1;
            int checkingColumn = this.CurrentCoordinate.Column + 1;
            while (IsCorrectCoordinates(checkingRow, checkingColumn))
            {
                if ((ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] == null)
                 || ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] is ValidMove)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    checkingColumn++;
                    checkingRow++;
                }
                else if (ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow].Color
                      != this.Color)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    break;
                }
                else
                {
                    break;
                }
            }

            checkingRow    = this.CurrentCoordinate.Row    - 1;
            checkingColumn = this.CurrentCoordinate.Column - 1;
            while (IsCorrectCoordinates(checkingRow, checkingColumn))
            {
                if ((ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] == null)
                 || ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow] is ValidMove)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    checkingColumn--;
                    checkingRow--;
                }
                else if (ChessBoard.ChessBoardMatrix[checkingColumn, checkingRow].Color
                      != this.Color)
                {
                    validMoves.Add(new Coordinate(checkingRow, checkingColumn));
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
