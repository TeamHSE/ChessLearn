using System;

namespace Chess
{
    /// <inheritdoc />
    /// <summary>
    /// Координата шахматной фигуры.
    /// </summary>
    public class Coordinate : ICoordinate
    {
        private        int  _column;
        private        int  _row;
        private static bool IsCoordinateInDiapason(int coordinatePart) => (coordinatePart >= 0) && (coordinatePart < 8);

        /// <inheritdoc />
        /// <summary>
        /// Столбец координаты фигуры.
        /// </summary>
        /// <exception cref="T:System.ArgumentException">Индекс столбца не входит в допустимый диапазон.</exception>
        public int Column
        {
            get => this._column;
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
        /// Строка координаты фигуры.
        /// </summary>
        /// <exception cref="T:System.ArgumentException">Индекс строки не входит в допустимый диапазон.</exception>
        public int Row
        {
            get => this._row;
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

        /// <summary>
        /// Координата фигуры.
        /// </summary>
        /// <param name="column">Столбец координаты.</param>
        /// <param name="row">Строка координаты.</param>
        internal Coordinate(int column, int row)
        {
            Column = column;
            Row    = row;
        }
    }
}
