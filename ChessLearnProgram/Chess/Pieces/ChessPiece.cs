#nullable enable
using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Chess.Pieces
{
    /// <inheritdoc />
    /// <summary>
    ///     Класс шахматной фигуры.
    /// </summary>
    public abstract class ChessPiece : Button
    {
        private       string      _color;
        private       Coordinate  _currentCoordinate;
        public static SoundPlayer? MoveSound;

        public ChessPiece(Coordinate coordinate, string color)
        {
            this.CurrentCoordinate = coordinate;
            this.Color             = color;
            if (this.Color == "Black")
            {
                this.Enabled = false;
            }

            ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = this;
        }

        public int Clicks { get; set; }

        /// <summary>
        ///     Текущая координата фигуры.
        /// </summary>
        public Coordinate CurrentCoordinate
        {
            get { return this._currentCoordinate; }
            set
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
        ///     Цвет фигуры.
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
            if (this.CurrentCoordinate.Equals(newCoordinate))
            {
                return;
            }

            if (!this.GetValidMoves().Contains(newCoordinate))
            {
                throw new ArgumentException($"Фигура не может переместиться с {this.CurrentCoordinate}"
                                          + $" на {newCoordinate}!");
            }

            ChessBoard.ChessBoardMatrix[newCoordinate.Column, newCoordinate.Row]                   = this;
            ChessBoard.ChessBoardMatrix[this.CurrentCoordinate.Column, this.CurrentCoordinate.Row] = null;

            this.CurrentCoordinate = new Coordinate(newCoordinate.Row, newCoordinate.Column);
            this.Clicks            = 0;
            this.BackColor = System.Drawing.Color.Transparent;
            MoveSound?.Play();
        }

        public abstract List<Coordinate> GetValidMoves();

        public void ToggleShowValidMoves()
        {
            foreach (Coordinate coordinate in this.GetValidMoves())
            {
                switch (ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row])
                {
                    case null:
                        ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row]
                            = new ValidMove(coordinate, this.Color);
                        break;
                    case ValidMove _:
                        ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = null;
                        break;
                    default:
                        ChessPiece enemy = ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row];
                        if (enemy.BackColor == System.Drawing.Color.Transparent)
                        {
                            enemy.Enabled   = true;
                            enemy.BackColor = ValidMove.ValidMoveColor;
                        }
                        else
                        {
                            enemy.Enabled   = false;
                            enemy.BackColor = System.Drawing.Color.Transparent;
                        }

                        break;
                }
            }

            foreach (ChessPiece chessPiece in ChessBoard.ChessBoardMatrix)
            {
                if (chessPiece == null)
                {
                    continue;
                }

                if (chessPiece.Color == "White" && chessPiece.Enabled && !(chessPiece is ValidMove))
                {
                    chessPiece.Enabled = false;
                }
                else if (chessPiece.Color == "White" && !(chessPiece is ValidMove))
                {
                    chessPiece.Enabled = true;
                }
            }

            this.Enabled   = true;
            if (this.Clicks % 2 == 1)
            {
                this.BackColor = System.Drawing.Color.Bisque;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Transparent;
            }
        }

        public static bool IsCorrectCoordinates(int col, int row)
        {
            return (col >= 0) && (col < 8) && (row >= 0) && (row < 8);
        }
    }
}
