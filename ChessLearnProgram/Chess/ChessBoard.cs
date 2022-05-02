using Chess.Pieces;

namespace Chess
{
    public static class ChessBoard
    {
        private static ChessPiece[,] _chessBoardMatrix = new ChessPiece[8, 8];

        internal static ChessPiece GetPiece(int currentRow, int currentColumn)
        {
            return _chessBoardMatrix[currentRow, currentColumn];
        }
    }
}
