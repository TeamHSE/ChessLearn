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
            this.Row    = row;
            this.Column = column;
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

        /// <summary>Возвращает строку, представляющую текущий объект.</summary>
        /// <returns>Строка, представляющая текущий объект.</returns>
        public override string ToString()
        {
            return $"{this.Row} {this.Column}";
        }

        /// <summary>Определяет, равен ли заданный объект текущему объекту.</summary>
        /// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
        /// <returns>Значение <see langword="true" />, если указанный объект равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Coordinate coordinate)
            {
                return (this.Row == coordinate.Row) && (this.Column == coordinate.Column);
            }

            return false;
        }

        private bool Equals(Coordinate other)
        {
            return (this._row    == other._row)
                && (this._column == other._column);
        }

        /// <summary>Служит хэш-функцией по умолчанию.</summary>
        /// <returns>Хэш-код для текущего объекта.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (this._row * 397) ^ this._column;
            }
        }
    }
}
