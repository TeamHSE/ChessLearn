using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chess
{
    public abstract class ChessPiece : Button
    {
        /// <summary>
        /// Текущая координата фигуры.
        /// </summary>
        protected abstract ChessBoard.Coordinate CurrentCoordinate { get; set; }

        /// <summary>
        /// Переход на другую клетку.
        /// </summary>
        /// <param name="coordinate">Координата другой клетки.</param>
        public void MoveTo(ChessBoard.Coordinate coordinate) => CurrentCoordinate = coordinate;

        /// <summary>
        /// Список корректных возможных ходов.
        /// </summary>
        public abstract List<ChessBoard.Coordinate> ValidMoves { get; set; }

        /// <summary>
        /// Статус фигуры. True – не срублена, False – срублена.
        /// </summary>
        public abstract bool IsPlayable { get; set; }
    }
}
