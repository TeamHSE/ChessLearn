using System.Collections.Generic;
using Chess;

namespace ChessLearnProgram
{
    public class Pawn : ChessPiece
    {
        public override (int, int) Coordinate() => (0, 0);

        public override List<(int, int)> ValidMovesCoordinates() => null;

        public override bool IsPlayable() => false;
    }
}
