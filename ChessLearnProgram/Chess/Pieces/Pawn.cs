using System.Collections.Generic;

namespace Chess.Pieces
{
    public class Pawn : ChessPiece
    {
        /// <inheritdoc />
        /// <summary>
        ///     Текущая координата пешки.
        /// </summary>
        protected override Coordinate CurrentCoordinate { get; set; }

        /// <inheritdoc />
        /// <summary>
        ///     Список корректных возможных ходов пешки.
        /// </summary>
        protected override List<Coordinate> ValidMoves { get; set; }

        /// <inheritdoc />
        /// <summary>
        ///     Статус пешки. True – не срублена, False – срублена.
        /// </summary>
        public override bool IsPlayable { get; set; }

        // Получение координат возможных ходов пешки.
        public List<Coordinate> GetValidMoves()
        {
            ValidMoves = new List<Coordinate>();
            Coordinate currentCoordinate = CurrentCoordinate;
            int        currentRow        = currentCoordinate.Row;
            int        currentColumn     = currentCoordinate.Column;

            return GetColorPawnValidMoves(currentRow, currentColumn, Color);
        }

        private static List<Coordinate> GetColorPawnValidMoves(int currentRow, int currentColumn, string color)
        {
            var validMoves = new List<Coordinate>();
            int initialRow;
            int moveOneRow;
            int moveTwoRows;
            if (color == "White")
            {
                initialRow  = 1;
                moveOneRow  = 1;
                moveTwoRows = 2;
            }
            else
            {
                initialRow  = 6;
                moveOneRow  = -1;
                moveTwoRows = -2;
            }

            // Пешка находится на первом ряду.
            if (currentRow == initialRow)
            {
                // На её ходу с первой горизонтали на 2 клетки нет дугих фигур.
                if (ChessBoard.GetPiece(currentRow + moveTwoRows, currentColumn) == null)
                {
                    validMoves.Add(new Coordinate(currentRow + moveTwoRows, currentColumn));
                }
            }

            // На её ходу с любой горизонтали нет дугих фигур.
            if (ChessBoard.GetPiece(currentRow + moveOneRow, currentColumn) == null)
            {
                validMoves.Add(new Coordinate(currentRow + moveOneRow, currentColumn));
            }

            // Спереди слева или спереди справа есть фигуры другого цвета.
            bool isLeftPiece  = ChessBoard.GetPiece(currentRow + moveOneRow, currentColumn - 1) != null;
            bool isRightPiece = ChessBoard.GetPiece(currentRow + moveOneRow, currentColumn + 1) != null;
            bool isLeftPieceColor = ChessBoard.GetPiece(currentRow + moveOneRow, currentColumn - 1)
                                              .Color
                                 != color;
            bool isRightPieceColor = ChessBoard.GetPiece(currentRow + moveOneRow, currentColumn + 1)
                                               .Color
                                  != color;
            if (isLeftPiece && isLeftPieceColor)
            {
                validMoves.Add(new Coordinate(currentRow + moveOneRow, currentColumn - 1));
            }

            if (isRightPiece && isRightPieceColor)
            {
                validMoves.Add(new Coordinate(currentRow + moveOneRow, currentColumn + 1));
            }

            return validMoves;
        }
    }
}
