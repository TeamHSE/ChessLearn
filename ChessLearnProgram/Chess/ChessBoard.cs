using Chess;

namespace ChessLearnProgram
{
    public class ChessBoard
    {
        private const    int           Columns = 8;
        private          ChessPiece[,] boardArray;
        private readonly int           Rows = 8;

        public ChessPiece this[int x, int y] => this.boardArray[x, y];
        public int GetLength(int  l) => this.boardArray.GetLength(l);


    }
}
