using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLearnProgram
{
    public class ChessBoard
    {
        private const    int           Columns = 8;
        private          ChessPart[,] boardArray;
        private readonly int           Rows = 8;
        public ChessBoard()
        {
            
        }

        public ChessPart this[int x, int y] => boardArray[x, y];
        public int GetLength(int  l) => boardArray.GetLength(l);


    }
}
