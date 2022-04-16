using System;
using System.Windows.Forms;

namespace Chess
{
    public class ChessBoard
    {
        private ChessPiece[,] _chessBoardMatrix;

        public ChessBoard() => this._chessBoardMatrix = new ChessPiece[8, 8];



    }
}
