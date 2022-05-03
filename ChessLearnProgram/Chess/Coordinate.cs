using System;

namespace Chess
{
    /// <inheritdoc />
    /// <summary>
    ///     Координата шахматной фигуры.
    /// </summary>
    public sealed class Coordinate : ICoordinate
    {
        private int _row;
        private int _column;

        /// <summary>
        ///     Координата фигуры.
        /// </summary>
        /// <param name="row">Строка координаты.</param>
        /// <param name="column">Столбец координаты.</param>
        public Coordinate(int row, int column)
        {
            Row    = row;
            Column = column;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Столбец координаты фигуры.
        /// </summary>
        /// <exception cref="T:System.ArgumentException">Индекс столбца не входит в допустимый диапазон.</exception>
        public int Column
        {
            get { return this._column; }
            set
            {
                if (!IsCoordinateInDiapason(value))
                {
                    throw new ArgumentException("Диапазон индекса столбца координаты фигуры: от 0 до 7,"
                                              + $" поступил на вход: {value}");
                }

                this._column = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     Строка координаты фигуры.
        /// </summary>
        /// <exception cref="T:System.ArgumentException">Индекс строки не входит в допустимый диапазон.</exception>
        public int Row
        {
            get { return this._row; }
            set
            {
                if (!IsCoordinateInDiapason(value))
                {
                    throw new ArgumentException("Диапазон индекса строки координаты фигуры: от 0 до 7,"
                                              + $" поступил на вход: {value}");
                }

                this._row = value;
            }
        }

        private static bool IsCoordinateInDiapason(int coordinatePart)
        {
            return (coordinatePart >= 0) && (coordinatePart < 8);
        }
    }
}
