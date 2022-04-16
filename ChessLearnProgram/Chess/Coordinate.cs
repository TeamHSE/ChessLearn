using System;

namespace Chess
{
    /// <inheritdoc />
    /// <summary>
    /// Координата шахматной фигуры.
    /// </summary>
    public class Coordinate : ICoordinate
    {
        private int _column;
        private int _row;

        public int Column
        {
            get => this._column;
            set
            {
                if ((value < 0) || (value > 7))
                {
                    throw new ArgumentException("Диапазон индекса столбца координаты фигуры: от 0 до 7,"
                                              + $" поступил на вход: {value}");
                }

                this._column = value;
            }
        }

        public int Row
        {
            get => this._row;
            set
            {
                if ((value < 0) || (value > 7))
                {
                    throw new ArgumentException("Диапазон индекса строки координаты фигуры: от 0 до 7,"
                                              + $" поступил на вход: {value}");
                }

                this._row = value;
            }
        }

        internal Coordinate(int column, int row)
        {
            Column = column;
            Row    = row;
        }
    }
}
