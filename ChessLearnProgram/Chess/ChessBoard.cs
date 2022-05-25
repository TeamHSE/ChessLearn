using System.Windows.Forms;
using Chess.Pieces;

namespace Chess
{
    public static class ChessBoard
    {
        public static readonly Button[,] ChessBoardMatrix = new Button[8, 8];

        internal static ChessPiece GetPieceOrNull(int currentRow, int currentColumn)
        {
            bool isValidRow    = (currentRow    >= 0) && (currentRow    <= 7);
            bool isValidColumn = (currentColumn >= 0) && (currentColumn <= 7);
            if (!isValidColumn || !isValidRow)
            {
                return null;
            }

            if (ChessBoardMatrix[currentRow, currentColumn] is ChessPiece piece)
            {
                return piece;
            }

            return null;
        }
    }
}
