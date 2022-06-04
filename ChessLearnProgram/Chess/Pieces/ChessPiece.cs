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
        private string     _color;
        private Coordinate _currentCoordinate;

        public ChessPiece(Coordinate coordinate, string color)
        {
            this.CurrentCoordinate                                         = coordinate;
            this.Color                                                     = color;
            ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = this;
        }

        public List<Coordinate> ValidMoves { get; } = new List<Coordinate>();

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
                        ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row].BackColor
                            = enemy.BackColor == System.Drawing.Color.Transparent
                                  ? System.Drawing.Color.Red
                                  : System.Drawing.Color.Transparent;
                        break;
                }
            }
        }
        public static bool IsCorrectCoordinates(int col, int row)
        {
            return (col >= 0) && (col < 8) && (row >= 0) && (row < 8);
        }
    }

    public sealed class ValidMove : ChessPiece
    {
        public ValidMove(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop = true;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.UseVisualStyleBackColor = true;
            ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = this;
        }

        public Coordinate Coordinate
        {
            get { return this.CurrentCoordinate; }
        }

        public override List<Coordinate> GetValidMoves()
        {
            return null;
        }
    }
}
