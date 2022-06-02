using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Chess;
using Chess.Pieces;

namespace ChessLearnProgram
{
    internal sealed partial class ChessBoardForm : Form
    {
        private readonly Dictionary<string, SoundPlayer?> _sounds = new Dictionary<string, SoundPlayer?>()
                                                                    {
                                                                        {
                                                                            "bishop_train",
                                                                            new SoundPlayer(Resource.bishop_train)
                                                                        },
                                                                        {
                                                                            "pawn_train",
                                                                            new SoundPlayer(Resource.pawn_train)
                                                                        },
                                                                        {
                                                                            "king_train",
                                                                            new SoundPlayer(Resource.king_train)
                                                                        },
                                                                        {
                                                                            "rook_train",
                                                                            new SoundPlayer(Resource.rook_train)
                                                                        },
                                                                        {
                                                                            "queen_train",
                                                                            new SoundPlayer(Resource.queen_train)
                                                                        },
                                                                        {
                                                                            "knight_train",
                                                                            new SoundPlayer(Resource.knight_train)
                                                                        }
                                                                    };

        private SoundPlayer? _soundPlayer;
        private Thread?      _theoryThread;
        private ChessPiece?  _lastClickedPiece;

        private int _playButtonClicks;

        public ChessBoardForm()
        {
            this.InitializeComponent();
        }

        private void UpdateChessBoard()
        {
            this.tableLayoutPanel1.Controls.Clear();
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    if (ChessBoard.ChessBoardMatrix[i, j] != null)
                    {
                        this.tableLayoutPanel1.Controls.Add(ChessBoard.ChessBoardMatrix[i, j], i, j);
                    }
                }
            }
        }

        private void SizeTrackBar_Scroll(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Size = new Size(this.SizeTrackBar.Value, this.SizeTrackBar.Value + 2);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            this._playButtonClicks++;
            if ((this._playButtonClicks % 2) != 0)
            {
                this._soundPlayer?.Play();
                this._theoryThread?.Start();
            }
            else
            {
                this._soundPlayer?.Stop();
                this._theoryThread?.Abort();
            }
        }

        public void LoadPawnScene()
        {
            this.PracticeButton.Text += " (пешка)";
            for (var i = 0; i < 8; i++)
            {
                _ = new Pawn(new Coordinate(1, i), "Black");
                _ = new Pawn(new Coordinate(6, i), "White");
            }

            void StartPawnLesson()
            {
                // sleep 23 seconds
                Thread.Sleep(22000);
                // Берем фигуру.
                Control centralWhitePawn = this.tableLayoutPanel1.GetControlFromPosition(4, 6);
                // Ставим на новую позицию.
                this.tableLayoutPanel1.Controls.Add(centralWhitePawn, 4, 5);
                Thread.Sleep(2000);
                Control centralBlackPawn = this.tableLayoutPanel1.GetControlFromPosition(3, 1);
                this.tableLayoutPanel1.Controls.Add(centralBlackPawn, 3, 3);
                Thread.Sleep(3000);
                Control nearWhitePawn = this.tableLayoutPanel1.GetControlFromPosition(3, 6);
                this.tableLayoutPanel1.Controls.Add(nearWhitePawn, 3, 4);
                Thread.Sleep(5000);
                Control nearBlackPawn = this.tableLayoutPanel1.GetControlFromPosition(2, 1);
                this.tableLayoutPanel1.Controls.Add(nearBlackPawn, 2, 3);
                Thread.Sleep(2000);
                Control farWhitePawn = this.tableLayoutPanel1.GetControlFromPosition(2, 6);
                this.tableLayoutPanel1.Controls.Add(farWhitePawn, 2, 5);
                Thread.Sleep(5000);
                this.tableLayoutPanel1.Controls.Add(nearBlackPawn, 2, 4);
                Thread.Sleep(4000);
                Control secondWhitePawn = this.tableLayoutPanel1.GetControlFromPosition(1, 6);
                this.tableLayoutPanel1.Controls.Add(secondWhitePawn, 1, 5);
                Thread.Sleep(7000);
                this.tableLayoutPanel1.Controls.Remove(secondWhitePawn);
                this.tableLayoutPanel1.Controls.Add(nearBlackPawn, 1, 5);
                Thread.Sleep(3000);
                Control edgeWhitePawn = this.tableLayoutPanel1.GetControlFromPosition(0, 6);
                this.tableLayoutPanel1.Controls.Add(edgeWhitePawn, 0, 5);
                Thread.Sleep(1000);
                this.tableLayoutPanel1.Controls.Add(nearBlackPawn, 1, 6);
                Thread.Sleep(1000);
                this.tableLayoutPanel1.Controls.Add(edgeWhitePawn, 0, 4);
                Thread.Sleep(1000);
                this.tableLayoutPanel1.Controls.Add(nearBlackPawn, 1, 7);
            }

            this.UpdateChessBoard();
            this._soundPlayer        = this._sounds["pawn_train"];
            this._theoryThread       = new Thread(StartPawnLesson);
            this.MessageTextBox.Text = Resource.pawn_train_text;
        }


        public void LoadKingScene()
        {
            var blackKing = new King(new Coordinate(4, 2), "Black");
            var whiteKing = new King(new Coordinate(3, 6), "White");
            var whitePawn = new Pawn(new Coordinate(6, 1), "White");
            _ = new Pawn(new Coordinate(1, 6), "White");

            void StartKingLesson()
            {
                // Ожидание начала.
                Thread.Sleep(20000);
                // Делается шах королю пешкой.
                this.tableLayoutPanel1.Controls.Add(whitePawn, 1, 5);
                blackKing.BackColor = Color.Red;
                // Король рубит пешку.
                Thread.Sleep(10000);
                blackKing.BackColor = Color.Transparent;
                this.tableLayoutPanel1.Controls.Remove(whitePawn);
                this.tableLayoutPanel1.Controls.Add(blackKing, 1, 5);
                // Двигаем королей.
                Thread.Sleep(25000);
                this.tableLayoutPanel1.Controls.Add(whiteKing, 6, 4);
                Thread.Sleep(2000);
                this.tableLayoutPanel1.Controls.Add(blackKing, 2, 5);
                Thread.Sleep(2000);
                this.tableLayoutPanel1.Controls.Add(whiteKing, 5, 5);
                Thread.Sleep(2000);
                this.tableLayoutPanel1.Controls.Add(blackKing, 3, 5);
            }

            this.UpdateChessBoard();
            this._soundPlayer        = this._sounds["king_train"];
            this._theoryThread       = new Thread(StartKingLesson);
            this.MessageTextBox.Text = Resource.king_train_text;
        }

        public void LoadBishopScene()
        {
            var whiteBishop1 = new Bishop(new Coordinate(7, 2), "White");
            var whiteBishop2 = new Bishop(new Coordinate(7, 5), "White");
            var blackBishop1 = new Bishop(new Coordinate(0, 2), "Black");
            _ = new Bishop(new Coordinate(0, 5), "Black");

            void StartBishopLesson()
            {
                Thread.Sleep(15000);
                this.tableLayoutPanel1.Controls.Add(whiteBishop1, 6, 3);
                Thread.Sleep(2000);
                this.tableLayoutPanel1.Controls.Add(blackBishop1, 6, 4);
                Thread.Sleep(15000);
                this.tableLayoutPanel1.Controls.Add(whiteBishop2, 4, 6);
                Thread.Sleep(11000);
                // Рубим белого слона
                this.tableLayoutPanel1.Controls.Remove(whiteBishop2);
                this.tableLayoutPanel1.Controls.Add(blackBishop1, 4, 6);
            }

            this.UpdateChessBoard();
            this._soundPlayer        = this._sounds["bishop_train"];
            this._theoryThread       = new Thread(StartBishopLesson);
            this.MessageTextBox.Text = Resource.bishop_train_text;
        }

        private void ChessBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChessBoard.Clear();
            this.StopSound();
        }

        private void StopSound()
        {
            this._soundPlayer?.Stop();
        }

        public void LoadRookScene()
        {
            _ = new Rook(new Coordinate(7, 7), "White");
            _ = new Rook(new Coordinate(0, 0), "Black");
            _ = new Rook(new Coordinate(7, 0), "White");
            _ = new King(new Coordinate(7, 4), "White");

            void StartRookLesson()
            {
                Thread.Sleep(36000);
                // Рокировка короткая 
                Control whiteKing = this.tableLayoutPanel1.GetControlFromPosition(4, 7);
                this.tableLayoutPanel1.Controls.Add(whiteKing, 6, 7);
                Thread.Sleep(500);
                Control whiteRook = this.tableLayoutPanel1.GetControlFromPosition(7, 7);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 5, 7);
                Thread.Sleep(2000);
                whiteKing = this.tableLayoutPanel1.GetControlFromPosition(6, 7);
                this.tableLayoutPanel1.Controls.Add(whiteKing, 4, 7);
                whiteRook = this.tableLayoutPanel1.GetControlFromPosition(5, 7);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 7, 7);
                Thread.Sleep(1500);
                //Рокировка длинная 
                whiteKing = this.tableLayoutPanel1.GetControlFromPosition(4, 7);
                this.tableLayoutPanel1.Controls.Add(whiteKing, 2, 7);
                Thread.Sleep(700);
                whiteRook = this.tableLayoutPanel1.GetControlFromPosition(0, 7);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 3, 7);
                Thread.Sleep(2000);
                whiteKing = this.tableLayoutPanel1.GetControlFromPosition(2, 7);
                this.tableLayoutPanel1.Controls.Add(whiteKing, 4, 7);
                whiteRook = this.tableLayoutPanel1.GetControlFromPosition(3, 7);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 0, 7);
                // Ход на всю длину шахматного поля
                Thread.Sleep(4790);
                whiteRook = this.tableLayoutPanel1.GetControlFromPosition(7, 7);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 7, 0);
                // Ход на 1 шаг 
                Thread.Sleep(2600);
                whiteRook = this.tableLayoutPanel1.GetControlFromPosition(7, 0);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 6, 0);
                // Ладья рубит 
                Thread.Sleep(7000);
                Control blackRook = this.tableLayoutPanel1.GetControlFromPosition(0, 0);
                whiteRook = this.tableLayoutPanel1.GetControlFromPosition(6, 0);
                this.tableLayoutPanel1.Controls.Remove(blackRook);
                this.tableLayoutPanel1.Controls.Add(whiteRook, 0, 0);
            }

            this.UpdateChessBoard();
            this._soundPlayer        = this._sounds["rook_train"];
            this._theoryThread       = new Thread(StartRookLesson);
            this.MessageTextBox.Text = Resource.rook_train_text;
        }

        public void LoadQueenScene()
        {
            _ = new King(new Coordinate(7,  4), "White");
            _ = new Queen(new Coordinate(7, 3), "White");
            _ = new King(new Coordinate(0,  4), "Black");
            _ = new Queen(new Coordinate(0, 3), "Black");

            void StartQueenLesson()
            {
                // удаление королей
                Thread.Sleep(20000);
                Control whiteKing = this.tableLayoutPanel1.GetControlFromPosition(4, 7);
                this.tableLayoutPanel1.Controls.Remove(whiteKing);
                Control blackKing = this.tableLayoutPanel1.GetControlFromPosition(4, 0);
                this.tableLayoutPanel1.Controls.Remove(blackKing);

                Thread.Sleep(6000);
                Control blackQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 0);
                Control whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 7);

                // ход ферзя ввер
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 2);
                Thread.Sleep(1000);
                // ход ферзя вниз
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 7);
                Thread.Sleep(1000);
                //возврат позиции ферзя 
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 7);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 2);
                Thread.Sleep(1000);
                // ход ферзя вправо
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 7, 2);
                Thread.Sleep(1000);
                // возврат ферзя 
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(7, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 2);
                // ход ферзя влево 
                Thread.Sleep(1000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 0, 2);
                // возврат ферзя 
                Thread.Sleep(1000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(0, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 2);
                // ход по диагонали вправо вверх
                Thread.Sleep(1000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 5, 0);
                Thread.Sleep(1000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(5, 0);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 2);
                Thread.Sleep(1000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 2);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 7, 6);
                Thread.Sleep(1000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(7, 6);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 2);
                // заключительный ход ферзя 
                Thread.Sleep(3000);
                whiteQueen = this.tableLayoutPanel1.GetControlFromPosition(3, 2);
                this.tableLayoutPanel1.Controls.Remove(blackQueen);
                this.tableLayoutPanel1.Controls.Add(whiteQueen, 3, 0);
            }

            this.UpdateChessBoard();
            this._soundPlayer        = this._sounds["queen_train"];
            this._theoryThread       = new Thread(StartQueenLesson);
            this.MessageTextBox.Text = Resource.queen_train_text;
        }

        public void LoadKnightScene()
        {
            _ = new Rook(new Coordinate(7,   7), "White");
            _ = new Rook(new Coordinate(7,   0), "White");
            _ = new Knight(new Coordinate(7, 6), "White");
            _ = new Knight(new Coordinate(7, 1), "White");
            _ = new Pawn(new Coordinate(6,   0), "White");
            _ = new Pawn(new Coordinate(6,   1), "White");
            _ = new Pawn(new Coordinate(6,   2), "White");
            _ = new Rook(new Coordinate(0,   0), "Black");
            _ = new Rook(new Coordinate(0,   7), "Black");
            _ = new Knight(new Coordinate(0, 6), "Black");
            _ = new Knight(new Coordinate(0, 1), "Black");


            void StartQueenLesson()
            {
                Thread.Sleep(18000);
                Control whiteKnight = this.tableLayoutPanel1.GetControlFromPosition(1, 7);
                this.tableLayoutPanel1.Controls.Add(whiteKnight, 2, 5);
                Thread.Sleep(5000);
                whiteKnight = this.tableLayoutPanel1.GetControlFromPosition(2, 5);
                this.tableLayoutPanel1.Controls.Add(whiteKnight, 4, 4);
                Thread.Sleep(14000);
                whiteKnight = this.tableLayoutPanel1.GetControlFromPosition(4, 4);
                this.tableLayoutPanel1.Controls.Add(whiteKnight, 5, 2);
                Thread.Sleep(3000);
                whiteKnight = this.tableLayoutPanel1.GetControlFromPosition(5, 2);
                this.tableLayoutPanel1.Controls.Add(whiteKnight, 3, 3);
            }

            this.UpdateChessBoard();
            this._soundPlayer        = this._sounds["knight_train"];
            this._theoryThread       = new Thread(StartQueenLesson);
            this.MessageTextBox.Text = Resource.knight_train_text;
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            this._theoryThread?.Abort();
            this._soundPlayer?.Stop();
            ChessBoard.Clear();
            this.PlayButton.Enabled = false;
            this.UpdateChessBoard();
            this.MessageTextBox.Text = "Вы перешли к практической части задания!\n";
            if (!(sender is Button button))
            {
                return;
            }

            if (button.Text.Contains("пешка"))
            {
                this.MessageTextBox.Text += "Сейчас вам предлагается закрепить знания о пешке.";
                this.LoadPawnPracticeScene();
            }
        }

        private void LoadPawnPracticeScene()
        {
            var pawn = new Pawn(new Coordinate(6, 3), "White");
            var blackPawn = new Pawn(new Coordinate(1, 2), "Black");
            pawn.Click += this.PawnOnClick;
            this.UpdateChessBoard();
        }

        private void PawnOnClick(object sender, EventArgs e)
        {
            var pawn = sender as Pawn;
            this._lastClickedPiece = pawn;
            if (pawn != null)
            {
                List<Coordinate>? validMoves = pawn.GetValidMoves(pawn.CurrentCoordinate);
                pawn.Clicks++;
                pawn.ToggleShowValidMoves();
                this.UpdateChessBoard();
                if (validMoves != null)
                {
                    foreach (Coordinate? coordinate in validMoves)
                    {
                        ChessPiece? piece = ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row];
                        if (piece is ValidMove)
                        {
                            piece.Click += this.ValidMoveOnClick;
                        }
                    }
                }
            }
        }

        private void ValidMoveOnClick(object sender, EventArgs e)
        {
            ChessPiece? lastClickedPiece = this._lastClickedPiece;
            if (lastClickedPiece != null)
            {
                lastClickedPiece.Clicks++;
                lastClickedPiece.ToggleShowValidMoves();
                var         validMove  = sender as ValidMove;
                Coordinate? coordinate = validMove?.Coordinate;
                if (coordinate != null)
                {
                    this._lastClickedPiece?.MoveTo(coordinate);
                    this.UpdateChessBoard();
                }
            }
        }
    }
}
