using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Pawn : ChessPiece
    {
        public Pawn(Coordinate coordinate, string color) : base(coordinate, color)
        {
            AllowDrop = true;
            Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AutoSize  = true;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = color == "Black"
                                  ? new Bitmap(ResourceBlack.Pawn)
                                  : new Bitmap(ResourceWhite.Pawn);
            BackgroundImageLayout      = ImageLayout.Zoom;
            FlatAppearance.BorderColor = System.Drawing.Color.White;
            FlatAppearance.BorderSize  = 0;
            FlatStyle                  = FlatStyle.Flat;
            ForeColor                  = System.Drawing.Color.DarkRed;
            Location                   = new Point(173, 347);
            Margin                     = new Padding(2);
            Name                       = "Pawn";
            Size                       = new Size(53, 54);
            TabIndex                   = 7;
            UseVisualStyleBackColor    = true;
        }


        /// <inheritdoc />
        /// <summary>
        ///     Список корректных возможных ходов пешки.
        /// </summary>
        protected override List<Coordinate> ValidMoves
        {
            get { return this.GetValidMoves(CurrentCoordinate); }
        }

        private int InitialRow
        {
            get
            {
                return Color == "White"
                           ? 1
                           : 6;
            }
        }

        private int OneStep
        {
            get
            {
                return Color == "White"
                           ? 1
                           : -1;
            }
        }

        private int TwoSteps
        {
            get
            {
                return Color == "White"
                           ? 2
                           : -2;
            }
        }

        // Получение координат возможных ходов пешки.
        private List<Coordinate> GetValidMoves(ICoordinate currentCoordinate)
        {
            var validMoves = new List<Coordinate>();

            // Пешка находится на первом ряду.
            if (currentCoordinate.Row == InitialRow)
            {
                // На её ходу с первой горизонтали на 2 клетки нет дугих фигур.
                if (ChessBoard.GetPieceOrNull(currentCoordinate.Row + TwoSteps, currentCoordinate.Column) == null)
                {
                    validMoves.Add(new Coordinate(currentCoordinate.Row + TwoSteps, currentCoordinate.Column));
                }
            }

            // На её ходу с любой горизонтали нет дугих фигур.
            if (ChessBoard.GetPieceOrNull(currentCoordinate.Row + OneStep, currentCoordinate.Column) == null)
            {
                validMoves.Add(new Coordinate(currentCoordinate.Row + OneStep, currentCoordinate.Column));
            }

            // Спереди слева или спереди справа есть фигуры другого цвета.
            this.PawnCutMoves(currentCoordinate, ref validMoves);

            return validMoves;
        }

        private void PawnCutMoves(ICoordinate currentCoordinate, ref List<Coordinate> validMoves)
        {
            bool isLeftPieceExists = ChessBoard
                                        .GetPieceOrNull(currentCoordinate.Row + OneStep, currentCoordinate.Column - 1)
                                  != null;
            bool isRightPieceExists = ChessBoard
                                         .GetPieceOrNull(currentCoordinate.Row + OneStep, currentCoordinate.Column + 1)
                                   != null;
            var isLeftPieceColorDiffers = false;
            if (isLeftPieceExists)
            {
                isLeftPieceColorDiffers = ChessBoard
                                         .GetPieceOrNull(currentCoordinate.Row + OneStep, currentCoordinate.Column - 1)
                                         .Color
                                       != Color;
            }

            var isRightPieceColorDiffers = false;
            if (isRightPieceExists)
            {
                isRightPieceColorDiffers = ChessBoard
                                          .GetPieceOrNull(currentCoordinate.Row + OneStep, currentCoordinate.Column + 1)
                                          .Color
                                        != Color;
            }

            if (isLeftPieceExists && isLeftPieceColorDiffers)
            {
                validMoves.Add(new Coordinate(currentCoordinate.Row + OneStep, currentCoordinate.Column - 1));
            }

            if (isRightPieceExists && isRightPieceColorDiffers)
            {
                validMoves.Add(new Coordinate(currentCoordinate.Row + OneStep, currentCoordinate.Column + 1));
            }
        }
    }
}
