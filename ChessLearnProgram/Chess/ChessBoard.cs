using Chess.Pieces;

namespace Chess
{
    public static class ChessBoard
    {
        public static ChessPiece[,] ChessBoardMatrix = new ChessPiece[8, 8];

        internal static ChessPiece GetPieceOrNull(int currentRow, int currentColumn)
        {
            bool isValidRow    = (currentRow    >= 0) && (currentRow    <= 7);
            bool isValidColumn = (currentColumn >= 0) && (currentColumn <= 7);
            if (!isValidColumn || !isValidRow)
            {
                return null;
            }

            return ChessBoardMatrix[currentColumn, currentRow];
        }

        /// <summary>
        ///     Очистка доски.
        /// </summary>
        public static void Clear()
        {
            for (var row = 0; row < 8; row++)
            {
                for (var column = 0; column < 8; column++)
                {
                    ChessBoardMatrix[row, column] = null;
                }
            }
        }
    }
}
