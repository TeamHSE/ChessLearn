using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chess
{
    /// <inheritdoc />
    /// <summary>
    /// Класс шахматной фигуры.
    /// </summary>
    public abstract class ChessPiece : Button
    {
        /// <summary>
        /// Текущая координата фигуры.
        /// </summary>
        protected abstract Coordinate CurrentCoordinate { get; set; }

        /// <summary>
        /// Переход на другую клетку.
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

        /// <summary>
        /// Список корректных возможных ходов.
        /// </summary>
        protected abstract List<Coordinate> ValidMoves { get; set; }

        /// <summary>
        /// Статус фигуры. True – не срублена, False – срублена.
        /// </summary>
        public abstract bool IsPlayable { get; set; }
    }
}
