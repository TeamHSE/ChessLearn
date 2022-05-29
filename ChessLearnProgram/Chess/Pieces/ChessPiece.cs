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
        public virtual List<Coordinate> ValidMoves { get; } = new List<Coordinate>();

        private string     _color;
        private Coordinate _currentCoordinate;

        public ChessPiece(Coordinate coordinate, string color)
        {
            this.CurrentCoordinate                                         = coordinate;
            this.Color                                                        = color;
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
            if (!this.ValidMoves.Contains(newCoordinate))
            {
                throw new ArgumentException($"Фигура не может переместиться с {this.CurrentCoordinate}"
                                          + $" на {newCoordinate}!");
            }

            this.CurrentCoordinate                                                    = newCoordinate;
            ChessBoard.ChessBoardMatrix[newCoordinate.Column, newCoordinate.Row] = this;
        }

        public void ToggleShowValidMoves()
        {
            foreach (Coordinate coordinate in this.ValidMoves)
            {
                if (ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] == null)
                {
                    ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = new ValidMove(coordinate, this.Color);
                }
                else if (ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] is ValidMove)
                {
                    ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = null;
                }
            }
        }
    }

    public sealed class ValidMove : ChessPiece
    {
        public ValidMove(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop                  = true;
            this.Anchor                     = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize                   = true;
            this.BackColor                  = System.Drawing.Color.Chartreuse;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize  = 0;
            this.FlatStyle                  = FlatStyle.Flat;
            this.UseVisualStyleBackColor       = true;
        }
    }
}
