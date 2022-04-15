using System.Collections.Generic;

namespace Chess
{
    public abstract class ChessPiece
    {
        /// <summary>
        /// Текущая координата фигуры.
        /// </summary>
        public abstract Coordinate CurrentCoordinate { get; set; }

        /// <summary>
        /// Переход на другую клетку.
        /// </summary>
        /// <param name="coordinate">Координата другой клетки.</param>
        public void MoveTo(Coordinate coordinate) => CurrentCoordinate = coordinate;

        /// <summary>
        /// Список корректных возможных ходов.
        /// </summary>
        public abstract List<Coordinate> ValidMoves { get; set; }

        /// <summary>
        /// Статус фигуры. True – не срублена, False – срублена.
        /// </summary>
        public abstract bool IsPlayable { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Координата шахматной фигуры.
        /// </summary>
        public abstract class Coordinate : ICoordinate
        {
            public int Column { get; set; }

            public int Row { get; set; }

            internal Coordinate(int column, int row)
            {
                Column = column;
                Row    = row;
            }
        }
    }
}
