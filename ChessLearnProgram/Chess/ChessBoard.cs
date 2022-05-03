using Chess.Pieces;

namespace Chess
{
    public static class ChessBoard
    {
        public static ChessPiece[,] ChessBoardMatrix = new ChessPiece[8, 8];

        internal static ChessPiece GetPiece(int currentRow, int currentColumn)
        {
            return ChessBoardMatrix[currentRow, currentColumn];
        }
    }
}
