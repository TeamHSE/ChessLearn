using System;
using System.Collections.Generic;
using System.Drawing;
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
        protected Coordinate CurrentCoordinate
        {
            get { return this._currentCoordinate; }
            private set
            {
                if ((value.Column < 0) || (value.Column > 7))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                if ((value.Row < 0) || (value.Row > 7))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this._currentCoordinate = value;
            }
        }

        /// <summary>
        ///     Список корректных возможных ходов.
        /// </summary>
        protected virtual List<Coordinate> ValidMoves { get; } = new List<Coordinate>();

        private string     _color;
        private Coordinate _currentCoordinate;

        public ChessPiece(Coordinate coordinate, string color)
        {
            CurrentCoordinate                                              = coordinate;
            Color                                                          = color;
            ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = this;
        }

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

            CurrentCoordinate                                                    = newCoordinate;
            ChessBoard.ChessBoardMatrix[newCoordinate.Column, newCoordinate.Row] = this;
        }

        public void ShowValidMoves()
        {
            foreach (Coordinate coordinate in ValidMoves)
            {
                var validMove = new ValidMove(coordinate, Color);
                ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = validMove;
            }
        }
    }

    public sealed class ValidMove : ChessPiece
    {
        public ValidMove(Coordinate coordinate, string color) : base(coordinate, color)
        {
            AllowDrop = true;
            Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AutoSize  = true;
            BackColor = System.Drawing.Color.Chartreuse;
            FlatAppearance.BorderColor = System.Drawing.Color.White;
            FlatAppearance.BorderSize  = 0;
            FlatStyle                  = FlatStyle.Flat;
            UseVisualStyleBackColor    = true;
        }
    }
}
