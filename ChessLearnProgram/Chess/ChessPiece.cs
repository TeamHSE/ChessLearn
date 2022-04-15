using System.Collections.Generic;

namespace Chess
{
    public abstract class ChessPiece
    {
        public abstract Coordinate CurrentCoordinate { get; set; }

        public void MoveTo(Coordinate coordinate) => CurrentCoordinate = coordinate;

        public abstract List<Coordinate> ValidMoves { get; set; }

        public abstract bool IsPlayable { get; set; }


        public abstract class Coordinate : ICoordinate
        {
            public int Column { get; set; }
            public int Row    { get; set; }

            internal Coordinate(int column, int row)
            {
                Column = column;
                Row    = row;
            }
        }
    }
}
