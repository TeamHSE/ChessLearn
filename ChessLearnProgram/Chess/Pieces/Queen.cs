using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Queen : ChessPiece
    {
        public Queen(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop = true;
            this.Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize  = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = color == "Black"
                                       ? new Bitmap(ResourceBlack.Queen)
                                       : new Bitmap(ResourceWhite.Queen);

            this.BackgroundImageLayout      = ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize  = 0;
            this.FlatStyle                  = FlatStyle.Flat;
            this.ForeColor                  = System.Drawing.Color.DarkRed;
            this.Location                   = new Point(173, 347);
            this.Margin                     = new Padding(2);
            this.Name                       = "Queen";
            this.Size                       = new Size(53, 54);
            this.TabIndex                   = 7;
            this.UseVisualStyleBackColor    = true;
        }

        public override List<Coordinate> GetValidMoves()
        {
            var validMoves = new List<Coordinate>();

            this.UpdateProportionalMoves(ref validMoves);
            this.UpdateDisproportialMoves(ref validMoves);
            this.UpdateVerticalMoves(ref validMoves);
            this.UpdateHorizontalMoves(ref validMoves);

            return validMoves;
        }

        private void UpdateDisproportialMoves(ref List<Coordinate> validMoves)
        {
            static bool IsCorrectCoordinates(int col, int row)
            {
                return (col >= 0) && (col < 8) && (row >= 0) && (row < 8);
            }

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
            static bool IsCorrectCoordinates(int col, int row)
            {
                return (col >= 0) && (col < 8) && (row >= 0) && (row < 8);
            }

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

        private void UpdateHorizontalMoves(ref List<Coordinate> validMoves)
        {
            int currentCol  = this.CurrentCoordinate.Column;
            int checkingCol = currentCol - 1;

            static bool IsCorrectLowCol(int columnIndex)
            {
                return columnIndex >= 0;
            }

            while (IsCorrectLowCol(checkingCol))
            {
                if ((ChessBoard.ChessBoardMatrix[checkingCol, this.CurrentCoordinate.Row] == null)
                 || ChessBoard.ChessBoardMatrix[checkingCol, this.CurrentCoordinate.Row] is ValidMove)
                {
                    validMoves.Add(new Coordinate(this.CurrentCoordinate.Row, checkingCol));
                    checkingCol--;
                }
                else if (ChessBoard.ChessBoardMatrix[checkingCol, this.CurrentCoordinate.Row].Color != this.Color)
                {
                    validMoves.Add(new Coordinate(this.CurrentCoordinate.Row, checkingCol));
                    break;
                }
                else
                {
                    break;
                }
            }

            checkingCol = currentCol + 1;

            static bool IsCorrectHighCol(int columnIndex)
            {
                return columnIndex < 8;
            }

            while (IsCorrectHighCol(checkingCol))
            {
                if ((ChessBoard.ChessBoardMatrix[checkingCol, this.CurrentCoordinate.Row] == null)
                 || ChessBoard.ChessBoardMatrix[checkingCol, this.CurrentCoordinate.Row] is ValidMove)
                {
                    validMoves.Add(new Coordinate(this.CurrentCoordinate.Row, checkingCol));
                    checkingCol++;
                }
                else if (
                    ChessBoard.ChessBoardMatrix[checkingCol, this.CurrentCoordinate.Row].Color != this.Color)
                {
                    validMoves.Add(new Coordinate(this.CurrentCoordinate.Row, checkingCol));
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private void UpdateVerticalMoves(ref List<Coordinate> validMoves)
        {
            int currentRow  = this.CurrentCoordinate.Row;
            int checkingRow = currentRow + 1;

            static bool IsCorrectLowRow(int rowIndex)
            {
                return rowIndex < 8;
            }

            while (IsCorrectLowRow(checkingRow))
            {
                if ((ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, checkingRow] == null)
                 || ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, checkingRow] is ValidMove)
                {
                    validMoves.Add(new Coordinate(checkingRow, this.CurrentCoordinate.Column));
                    checkingRow++;
                }
                else if (
                    ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, checkingRow].Color != this.Color)
                {
                    validMoves.Add(new Coordinate(checkingRow, this.CurrentCoordinate.Column));
                    break;
                }
                else
                {
                    break;
                }
            }

            checkingRow = currentRow - 1;

            static bool IsCorrectHighRow(int rowIndex)
            {
                return rowIndex >= 0;
            }

            while (IsCorrectHighRow(checkingRow))
            {
                if ((ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, checkingRow] == null)
                 || ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, checkingRow] is ValidMove)
                {
                    validMoves.Add(new Coordinate(checkingRow, this.CurrentCoordinate.Column));
                    checkingRow--;
                }
                else if (ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, checkingRow].Color != this.Color)
                {
                    validMoves.Add(new Coordinate(checkingRow, this.CurrentCoordinate.Column));
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
