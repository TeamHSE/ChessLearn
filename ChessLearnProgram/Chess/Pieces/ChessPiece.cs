using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chess.Pieces
{
    /// <inheritdoc />
    /// <summary>
    ///     Класс шахматной фигуры.
    /// </summary>
    public abstract class ChessPiece : Button
    {
        /// <summary>
        ///     Текущая координата фигуры.
        /// </summary>
        protected abstract Coordinate CurrentCoordinate { get; set; }

        /// <summary>
        ///     Список корректных возможных ходов.
        /// </summary>
        protected abstract List<Coordinate> ValidMoves { get; set; }

        private string _color;

        /// <summary>
        ///     Статус фигуры. True – не срублена, False – срублена.
        /// </summary>
        public abstract bool IsPlayable { get; set; }

        /// <summary>
        /// Цвет фигуры.
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set
            {
                if ((value != "White") && (value != "Black"))
                {
                    throw new ArgumentException("Неверный цвет фигуры.");
                }

                this._color = value;
            }
        }

        /// <summary>
        ///     Переход на другую клетку.
        /// </summary>
        /// <param name="newCoordinate">Координата другой клетки.</param>
        /// <exception cref="ArgumentException">Фигура не может переместиться на новую клетку.</exception>
        public void MoveTo(Coordinate newCoordinate)
        {
            if (!ValidMoves.Contains(newCoordinate))
            {
                throw new ArgumentException($"Фигура не может переместиться с {CurrentCoordinate}"
                                          + $" на {newCoordinate}!");
            }

            CurrentCoordinate = newCoordinate;
        }
    }
}
