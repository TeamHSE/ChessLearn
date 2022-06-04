using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Pawn : ChessPiece
    {
        public Pawn(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop = true;
            this.Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize  = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = color == "Black"
                                       ? new Bitmap(ResourceBlack.Pawn)
                                       : new Bitmap(ResourceWhite.Pawn);

            this.BackgroundImageLayout      = ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize  = 0;
            this.FlatStyle                  = FlatStyle.Flat;
            this.ForeColor                  = System.Drawing.Color.DarkRed;
            this.Location                   = new Point(173, 347);
            this.Margin                     = new Padding(2);
            this.Name                       = "Pawn";
            this.Size                       = new Size(53, 54);
            this.TabIndex                   = 7;
            this.UseVisualStyleBackColor    = true;
        }

        private int InitialRow
        {
            get
            {
                return this.Color == "White"
                           ? 6
                           : 1;
            }
        }

        private int OneStep
        {
            get
            {
                return this.Color == "White"
                           ? -1
                           : 1;
            }
        }

        private int TwoSteps
        {
            get
            {
                return this.Color == "White"
                           ? -2
                           : 2;
            }
        }

        // Получение координат возможных ходов пешки.
        public override List<Coordinate> GetValidMoves()
        {
            var        validMoves        = new List<Coordinate>();
            Coordinate currentCoordinate = this.CurrentCoordinate;

            // Пешка находится на первом ряду.
            if (currentCoordinate.Row == this.InitialRow)
            {
                // На её ходу с первой горизонтали на 2 клетки нет дугих фигур.
                ChessPiece twoMove
                    = ChessBoard.GetPieceOrNull(currentCoordinate.Row + this.TwoSteps, currentCoordinate.Column);
                if ((twoMove == null) || twoMove is ValidMove)
                {
                    validMoves.Add(new Coordinate(currentCoordinate.Row + this.TwoSteps, currentCoordinate.Column));
                }
            }

            // На её ходу с любой горизонтали нет дугих фигур.
            ChessPiece oneMove
                = ChessBoard.GetPieceOrNull(currentCoordinate.Row + this.OneStep, currentCoordinate.Column);
            if ((oneMove == null) || oneMove is ValidMove)
            {
                validMoves.Add(new Coordinate(currentCoordinate.Row + this.OneStep, currentCoordinate.Column));
            }

            // Спереди слева или спереди справа есть фигуры другого цвета.
            this.PawnCutMoves(currentCoordinate, ref validMoves);

            return validMoves;
        }

        private void PawnCutMoves(ICoordinate currentCoordinate, ref List<Coordinate> validMoves)
        {
            bool isLeftPieceExists = ChessBoard
                                        .GetPieceOrNull(currentCoordinate.Column + this.OneStep,
                                                        currentCoordinate.Row    + this.OneStep)
                                  != null;
            bool isRightPieceExists = ChessBoard
                                         .GetPieceOrNull(currentCoordinate.Column - this.OneStep,
                                                         currentCoordinate.Row    + this.OneStep)
                                   != null;
            var isLeftPieceColorDiffers = false;
            if (isLeftPieceExists)
            {
                isLeftPieceColorDiffers = ChessBoard
                                         .GetPieceOrNull(currentCoordinate.Column + this.OneStep,
                                                         currentCoordinate.Row    + this.OneStep)
                                         .Color
                                       != this.Color;
            }

            var isRightPieceColorDiffers = false;
            if (isRightPieceExists)
            {
                isRightPieceColorDiffers = ChessBoard
                                          .GetPieceOrNull(currentCoordinate.Column - this.OneStep,
                                                          currentCoordinate.Row    + this.OneStep)
                                          .Color
                                        != this.Color;
            }

            if (isLeftPieceExists && isLeftPieceColorDiffers)
            {
                validMoves.Add(new Coordinate(currentCoordinate.Row    + this.OneStep,
                                              currentCoordinate.Column + this.OneStep));
                ChessPiece enemy = ChessBoard
                   .GetPieceOrNull(currentCoordinate.Column + this.OneStep, currentCoordinate.Row + this.OneStep);
            }

            if (isRightPieceExists && isRightPieceColorDiffers)
            {
                validMoves.Add(new Coordinate(currentCoordinate.Row    + this.OneStep,
                                              currentCoordinate.Column - this.OneStep));
                ChessPiece enemy = ChessBoard
                   .GetPieceOrNull(currentCoordinate.Column - this.OneStep, currentCoordinate.Row + this.OneStep);
            }
        }
    }
}
