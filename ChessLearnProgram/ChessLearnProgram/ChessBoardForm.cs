using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Chess;
using Chess.Pieces;

namespace ChessLearnProgram
{
    internal sealed partial class ChessBoardForm : Form
    {
        private readonly Dictionary<string, SoundPlayer?> _sounds = new Dictionary<string, SoundPlayer?>
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

        private ChessPiece? _lastClickedPiece;

        private ChessPiece? _mainEnemyPiece;
        private ChessPiece? _mainPiece;

        private int _playButtonClicks;

        private SoundPlayer? _soundPlayer;
        private Thread?      _theoryThread;

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

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            this._theoryThread?.Abort();
            this._soundPlayer?.Stop();
            ChessBoard.Clear();
            this.PlayButton.Enabled = false;
            this.UpdateChessBoard();
            this.MessageTextBox.Text = @"  Вы перешли к практической части задания!
";
            if (!(sender is Button button))
            {
                return;
            }

            if (button.Text.Contains("пешка"))
            {
                this.MessageTextBox.Text += @"  Сейчас вам предлагается закрепить знания о пешке.
  Перед вами стоит задача провести пешку до конца поля, чтобы превратить её в ферзя.
  Соперник, однако, надеется опередить вас и поставить свою пешку.
  В пылу эмоций он забывает про своего коня, воспользуйтесь этим и проведите свою центраьную пешку быстрее него!
  Внимание! Чтобы опередить соперника проводить нужно именно центральную пешку!
";
                button.Text = @"Пройти урок заново (пешка)";
                this.LoadPawnPracticeScene();
            }
            else if (button.Text.Contains("король"))
            {
                this.MessageTextBox.Text += @"  Сейчас вам предлагается закрепить знания о короле.

  Смтрите! Следующим ходом соперник может поставить вам мат, сделав ход ладьёй на горизонталь с вашим королём!
  Найдите наилучший ход для короля, чтобы не только избежать мата, но и сохранить свою ладью и завершить партию победой!
  Обратите внимание! Ваш король не сделал ни одного хода ранее и ваша ладья справа тоже!";
                button.Text = @"Пройти урок заново (король)";
                this.LoadKingPracticeScene();
            }
            else if (button.Text.Contains("ладья"))
            {
                this.MessageTextBox.Text += @"  Сейчас вам предлагается закрепить знания о ладье.

  Ваша пешка очень близка к тому, чтобы стать ферзём, однако вражеские фигуры мешают вам это сделать!
  Ваша задача найти лучшие ходы для своей ладьи, чтобы выиграть партию в дальнейшем!";
                button.Text = @"Пройти урок заново (ладья)";
                this.LoadRookPracticeScene();
            }
            else if (button.Text.Contains("слон"))
            {
                this.MessageTextBox.Text += @"  Сейчас вам предлагается закрепить знания о слоне.

  Оцентие позицию и преимущество ваших слонов и найдите мат в 3 хода для вашего соперника.";
                button.Text = @"Пройти урок заново (слон)";
                this.LoadBishopPracticeScene();
            }
            else if (button.Text.Contains("ферзь"))
            {
                this.MessageTextBox.Text
                    += @"  Сейчас вам предлагается закрепить знания о ферзе. Начиная с хода своего белого ферзя, продолжите с помощью короля и завершите игру, поставив мат сопернику!";
                button.Text = @"Пройти урок заново (ферзь)";
                this.LoadQueenPracticeScene();
            }
            else if (button.Text.Contains("конь"))
            {
                this.MessageTextBox.Text += @"  Сейчас вам предлагается закрепить знания о коне.
  Закончим наш курс матом, который многие новички пропускают из виду, в пылу сражения теряют бдительность.
  Я буду давать подсказки по ходам для достижения этого мата, но если хотите, попробуйте поставить его без подсказок.
  Первым ходом конь, находящийся под атакой слона берёт центральную пешку. ""Зачем?"" – спросите вы, затем, чтобы подготовить атаку на короля с помощью силы ваших коней и слона.";
                button.Text = @"Пройти урок заново (конь)";
                this.LoadKnightPracticeScene();
            }
        }

        #region Theory part

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
            this.PracticeButton.Text = @"Перейти к практике (пешка)";
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
            this.PracticeButton.Text = @"Перейти к практике (король)";
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
            this.PracticeButton.Text = @"Перейти к практике (слон)";
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

        public void LoadRookScene()
        {
            this.PracticeButton.Text = @"Перейти к практике (ладья)";

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
            this.PracticeButton.Text = @"Перейти к практике (ферзь)";
            _                        = new King(new Coordinate(7,  4), "White");
            _                        = new Queen(new Coordinate(7, 3), "White");
            _                        = new King(new Coordinate(0,  4), "Black");
            _                        = new Queen(new Coordinate(0, 3), "Black");

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
            this.PracticeButton.Text = @"Перейти к практике (конь)";

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

        private void ChessBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChessBoard.Clear();
            this.StopSound();
        }

        private void StopSound()
        {
            this._soundPlayer?.Stop();
        }

        #endregion Theory part

        #region Pawn

        private void LoadPawnPracticeScene()
        {
            var pawn = new Pawn(new Coordinate(6, 3), "White");
            _          =  new Knight(new Coordinate(1, 2), "Black");
            _          =  new Pawn(new Coordinate(1,   3), "Black");
            _          =  new Pawn(new Coordinate(1,   7), "Black");
            _          =  new Pawn(new Coordinate(1,   6), "Black");
            _          =  new King(new Coordinate(0,   7), "Black");
            _          =  new Pawn(new Coordinate(2,   0), "Black");
            _          =  new King(new Coordinate(7,   7), "White");
            _          =  new Pawn(new Coordinate(6,   7), "White");
            _          =  new Pawn(new Coordinate(6,   6), "White");
            pawn.Click += this.Pawn_Click;
            this.UpdateChessBoard();
            this._mainEnemyPiece = this.tableLayoutPanel1.GetControlFromPosition(0, 2) as Pawn;
        }

        private void Pawn_Click(object sender, EventArgs e)
        {
            var pawn = sender as Pawn;
            this._lastClickedPiece = pawn;
            this._mainPiece        = pawn;
            if (pawn == null)
            {
                return;
            }

            List<Coordinate>? validMoves = pawn.GetValidMoves();
            pawn.Clicks++;
            pawn.ToggleShowValidMoves();
            this.UpdateChessBoard();
            if (validMoves != null)
            {
                IEnumerable<ValidMove> valids = validMoves
                                               .Select(coordinate =>
                                                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                               coordinate.Row])
                                               .OfType<ValidMove>();
                foreach (ValidMove validMove in valids)
                {
                    if (pawn.Clicks != 1)
                    {
                        validMove.Click -= this.ValidPawnMove_Click;
                    }

                    validMove.Click += this.ValidPawnMove_Click;
                }
            }

            ChessPiece enemy;
            if (pawn.CurrentCoordinate.Row != 2)
            {
                return;
            }

            {
                void EnemyPawn_Click(object o, EventArgs args)
                {
                    ChessBoard.ChessBoardMatrix[enemy.CurrentCoordinate.Column, enemy.CurrentCoordinate.Row]
                        = pawn;
                    ChessBoard.ChessBoardMatrix[pawn.CurrentCoordinate.Column, pawn.CurrentCoordinate.Row]
                        = null;
                    this.tableLayoutPanel1.Controls.Remove(enemy);
                    pawn.CurrentCoordinate = enemy.CurrentCoordinate;
                    this.tableLayoutPanel1.Controls.Add(pawn, pawn.CurrentCoordinate.Column,
                                                        pawn.CurrentCoordinate.Row);
                    this.UpdateChessBoard();
                    ChessPiece? mainEnemyPiece = this._mainEnemyPiece;
                    if (mainEnemyPiece != null)
                    {
                        this.NextBlackPawnMove(mainEnemyPiece);
                    }
                }

                if (!(this.tableLayoutPanel1.GetControlFromPosition(pawn.CurrentCoordinate.Column - 1, 1) is
                          ChessPiece piece))
                {
                    return;
                }

                enemy           =  piece;
                enemy.BackColor =  Color.Red;
                enemy.Click     -= EnemyPawn_Click;
                enemy.Click     += EnemyPawn_Click;
            }
        }

        private void NextBlackPawnMove(ChessPiece piece)
        {
            piece.MoveTo(new Coordinate(piece.CurrentCoordinate.Row + 1, piece.CurrentCoordinate.Column));
            if (piece.CurrentCoordinate.Row == 7)
            {
                _ = new Queen(new Coordinate(piece.CurrentCoordinate.Row, piece.CurrentCoordinate.Column),
                              "Black");
                ChessPiece? chessPiece = this._mainPiece;
                if (chessPiece != null)
                {
                    chessPiece.Enabled = false;
                }

                var whiteking = this.tableLayoutPanel1.GetControlFromPosition(7, 7) as King;
                if (whiteking != null)
                {
                    whiteking.Enabled   = false;
                    whiteking.BackColor = Color.Red;
                }

                this.MessageTextBox.Text += @"
  Увы! Вы не смогли поставить мат королю соперника.
  Попробуйте заново! Попробуйте просчитать, как можно опередить пешку соперника!";
                MessageBox.Show(@"Вы не смогли поставить мат королю соперника.
  Попробуйте заново! Попробуйте просчитать, как можно опередить пешку соперника!", @"Вы проиграли!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            this.UpdateChessBoard();
        }

        private void ValidPawnMove_Click(object sender, EventArgs e)
        {
            ChessPiece? mainPiece = this._mainPiece;
            if ((mainPiece != null) && (mainPiece.CurrentCoordinate.Row == 1))
            {
                ChessPiece? chessPiece = this._mainPiece;
                if (chessPiece != null)
                {
                    ChessBoard.ChessBoardMatrix[chessPiece.CurrentCoordinate.Column,
                                                chessPiece.CurrentCoordinate.Row] = null;
                    var queen
                        = new
                            Queen(new Coordinate(chessPiece.CurrentCoordinate.Row - 1, chessPiece.CurrentCoordinate.Column),
                                  "White");
                    this.tableLayoutPanel1.Controls.Remove(chessPiece);
                    this.tableLayoutPanel1.Controls.Add(queen, queen.CurrentCoordinate.Column,
                                                        queen.CurrentCoordinate.Row);
                }

                this.UpdateChessBoard();
                mainPiece.Click -= this.Pawn_Click;
                if (this.tableLayoutPanel1.GetControlFromPosition(7, 0) is King blackKing)
                {
                    blackKing.Enabled   = false;
                    blackKing.BackColor = Color.Red;
                    this.MessageTextBox.Text
                        += @"
  Поздравляем! Вы успешно смогли поставить мат королю соперника, тем самым выиграв партию!";
                    MessageBox.Show(@"Поздравляем! Вы успешно смогли поставить мат королю соперника, тем самым выиграв партию!",
                                    @"Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            ChessPiece? lastClickedPiece = this._lastClickedPiece;
            if (lastClickedPiece == null)
            {
                return;
            }

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

                ChessPiece? chessPiece = this._mainEnemyPiece;
                if ((chessPiece != null) && (((ValidMove)sender).CurrentCoordinate.Row != 0))
                {
                    this.NextBlackPawnMove(chessPiece);
                }
            }
        }

        #endregion Pawn

        #region King

        private void LoadKingPracticeScene()
        {
            // White pieces
            var whiteKing = new King(new Coordinate(7, 4), "White");
            whiteKing.ValidMoves.Add(new Coordinate(whiteKing.CurrentCoordinate.Row,
                                                    whiteKing.CurrentCoordinate.Column + 1));
            whiteKing.ValidMoves.Add(new Coordinate(whiteKing.CurrentCoordinate.Row,
                                                    whiteKing.CurrentCoordinate.Column + 2));
            whiteKing.ValidMoves.Add(new Coordinate(whiteKing.CurrentCoordinate.Row,
                                                    whiteKing.CurrentCoordinate.Column - 1));
            whiteKing.Click += this.WhiteKing_Click;
            _               =  new Rook(new Coordinate(7, 7), "White");
            _               =  new Pawn(new Coordinate(6, 4), "White");
            _               =  new Pawn(new Coordinate(6, 6), "White");
            _               =  new Pawn(new Coordinate(6, 7), "White");

            // Black pieces
            _ = new King(new Coordinate(5, 4), "Black");
            _ = new Rook(new Coordinate(0, 0), "Black");
            this.UpdateChessBoard();
        }

        private void WhiteKing_Click(object sender, EventArgs e)
        {
            if (!(sender is King whiteKing))
            {
                return;
            }

            this._lastClickedPiece = whiteKing;
            whiteKing.Clicks++;
            whiteKing.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteKing.GetValidMoves();
            IEnumerable<ValidMove> validMoves = validMoveCoords
                                               .Select(coordinate =>
                                                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                               coordinate.Row])
                                               .OfType<ValidMove>();
            foreach (ValidMove validMove in validMoves)
            {
                validMove.Click -= this.ValidKingMove_Click;
                validMove.Click += this.ValidKingMove_Click;
            }
        }

        private void ValidKingMove_Click(object sender, EventArgs e)
        {
            if (!(sender is ValidMove validMove) || (this._lastClickedPiece == null))
            {
                return;
            }

            Coordinate validMoveCoord = validMove.Coordinate;
            if (validMoveCoord == null)
            {
                return;
            }

            if (Equals(validMoveCoord, new Coordinate(7, 3)))
            {
                this.RunBadKingMoveLoseRook();
                return;
            }

            if (Equals(validMoveCoord, new Coordinate(7, 5)))
            {
                this.RunBadKingMoveMate();
                return;
            }

            if (Equals(validMoveCoord, new Coordinate(7, 6)))
            {
                this.RunCorrectKingMove();
            }
        }


        private void RunCorrectKingMove()
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var whiteKing = (King)this._lastClickedPiece;
            whiteKing.MoveTo(new Coordinate(whiteKing.CurrentCoordinate.Row,
                                            whiteKing.CurrentCoordinate.Column + 2));
            var whiteRook = (Rook)ChessBoard.ChessBoardMatrix[7, 7];
            ChessBoard.ChessBoardMatrix[5, 7] = whiteRook;
            ChessBoard.ChessBoardMatrix[7, 7] = null;
            whiteKing.ToggleShowValidMoves();
            whiteKing.ValidMoves.Clear();
            this.UpdateChessBoard();

            this.MessageTextBox.Text += @"
  Поздравляем! Вы смогли защитить короля, сделав рокировку! Этим ходом вы обеспечили не только безопасность своего короля,
но и открыли для ладьи сразу два пути для развития, что позволит вам провести свои пешки и сделать их ферзями!";
            MessageBox.Show(@"Поздравляем! Вы смогли защитить короля, сделав рокировку! Этим ходом вы обеспечили не только безопасность своего короля,
но и открыли для ладьи сразу два пути для развития, что позволит вам провести свои пешки и сделать их ферзями!",
                            @"Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RunBadKingMoveMate()
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var whiteKing = (King)this._lastClickedPiece;
            whiteKing.MoveTo(new Coordinate(whiteKing.CurrentCoordinate.Row,
                                            whiteKing.CurrentCoordinate.Column + 1));
            whiteKing.ToggleShowValidMoves();
            whiteKing.ValidMoves.Clear();
            var blackRook = (Rook)ChessBoard.ChessBoardMatrix[0, 0];
            ChessBoard.ChessBoardMatrix[0, 7] = blackRook;
            ChessBoard.ChessBoardMatrix[0, 0] = null;
            whiteKing.BackColor               = Color.Red;
            whiteKing.Enabled                 = false;
            this.UpdateChessBoard();

            this.MessageTextBox.Text += @"
  О нет! Вам мат! Ваш король оказалься замкнут и не сможет выбраться из-под шаха, что значит, что вы проиграли партию! Попробуйте заново!";
            MessageBox.Show(@"О нет! Вам мат! Ваш король оказалься замкнут и не сможет выбраться из-под шаха, что значит, что вы проиграли партию! Попробуйте заново!",
                            @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RunBadKingMoveLoseRook()
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var whiteKing = (King)this._lastClickedPiece;
            whiteKing.MoveTo(new Coordinate(whiteKing.CurrentCoordinate.Row,
                                            whiteKing.CurrentCoordinate.Column - 1));
            whiteKing.ToggleShowValidMoves();
            whiteKing.ValidMoves.Clear();
            var blackRook = (Rook)ChessBoard.ChessBoardMatrix[0, 0];
            ChessBoard.ChessBoardMatrix[0, 7] = blackRook;
            ChessBoard.ChessBoardMatrix[0, 0] = null;
            whiteKing.BackColor               = Color.Red;
            whiteKing.Enabled                 = false;
            this.UpdateChessBoard();

            this.MessageTextBox.Text += @"
  О нет! Вам шах, и следующим ходом ладья соперника забирает вашу!
  это значит, что вы будете играть королём и пешками против короля и ладьи соперника, но при такой ситуации это безвыигрышная
позиция! Попробуйте заново!";
            MessageBox.Show(@"О нет! Вам шах, и следующим ходом ладья соперника забирает вашу!
  Это значит, что вы будете играть королём и пешками против короля и ладьи соперника, но при такой ситуации это безвыигрышная позиция!
  Попробуйте заново!", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion King

        #region Rook

        private void LoadRookPracticeScene()
        {
            // White pieces.
            var whiteRook = new Rook(new Coordinate(5, 4), "White");
            var whitePawn = new Pawn(new Coordinate(2, 2), "White");
            new King(new Coordinate(0, 1), "White");
            whiteRook.Click += this.Rook_Click;
            whitePawn.Click += this.WhitePawn_Click;

            // Black pieces.
            new Rook(new Coordinate(5, 2), "Black");
            new Rook(new Coordinate(1, 4), "Black");
            new Pawn(new Coordinate(2, 4), "Black");
            new King(new Coordinate(0, 3), "Black");
            this.UpdateChessBoard();
        }

        private void WhitePawn_Click(object sender, EventArgs e)
        {
            var pawn = sender as Pawn;
            this._lastClickedPiece = pawn;
            this._mainPiece        = pawn;
            if (pawn == null)
            {
                return;
            }

            List<Coordinate>? validMoves = pawn.GetValidMoves();
            pawn.Clicks++;
            pawn.ToggleShowValidMoves();
            this.UpdateChessBoard();
            if (validMoves != null)
            {
                IEnumerable<ValidMove> valids = validMoves
                                               .Select(coordinate =>
                                                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                               coordinate.Row])
                                               .OfType<ValidMove>();
                foreach (ValidMove validMove in valids)
                {
                    validMove.Click -= this.ValidWhitePawnMove_Click;
                    validMove.Click += this.ValidWhitePawnMove_Click;
                }
            }
        }

        private void ValidWhitePawnMove_Click(object sender, EventArgs e)
        {
            this.MessageTextBox.Text += @"
  Найдите ход получше! Этим ходом вы передаёте инициативу своему сопернику!";
            MessageBox.Show(@"Найдите ход получше! Этим ходом вы передаёте инициативу своему сопернику!",
                            @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ChessPiece? lastClickedPiece = this._lastClickedPiece;
            if (lastClickedPiece != null)
            {
                lastClickedPiece.Clicks = 0;
            }

            ChessBoard.Clear();
            this.LoadRookPracticeScene();
            this.UpdateChessBoard();
        }

        private void Rook_Click(object sender, EventArgs e)
        {
            var whiteRook = (Rook)sender;
            this._lastClickedPiece = whiteRook;
            whiteRook.Clicks++;
            whiteRook.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteRook.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidRookMove_Click;
                    piece.Click += this.ValidRookMove_Click;
                }
            }
        }

        private void ValidRookMove_Click(object sender, EventArgs e)
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var         whiteRook         = (Rook)this._lastClickedPiece;
            Coordinate? initialCoordinate = whiteRook.CurrentCoordinate;
            var         move              = (ChessPiece)sender;
            Coordinate? moveCoord         = move.CurrentCoordinate;
            whiteRook.ToggleShowValidMoves();
            whiteRook.MoveTo(moveCoord);
            this.UpdateChessBoard();

            if (moveCoord.Equals(new Coordinate(5, 2)) && (whiteRook.Clicks == 0))
            {
                this.MessageTextBox.Text += @"
  Отличный очевидный ход! Так вы смогли не только забрать вражескую фигуру, но и сможете помочь своей пешке!
  Продолжайте!
  Теперь он перекрыл путь вашей пешке! Найдите лучший ход своей ладьи, для контрудара!";
                var blackRook = (Rook)ChessBoard.ChessBoardMatrix[4, 1];
                blackRook.MoveTo(new Coordinate(1, 2));
                this.UpdateChessBoard();
            }
            else if (whiteRook.Clicks == 1)
            {
                this.MessageTextBox.Text += @"
  Найдите ход получше! Этим ходом вы передаёте инициативу своему сопернику!";
                MessageBox.Show(@"Найдите ход получше! Этим ходом вы передаёте инициативу своему сопернику!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChessBoard.Clear();
                this.LoadRookPracticeScene();
                this.UpdateChessBoard();
                whiteRook.Clicks = 0;
            }
            else if (moveCoord.Equals(new Coordinate(5, 3)) && (initialCoordinate.Column != 4))
            {
                this.MessageTextBox.Text += @"
  Замечательно! Вы поставили шах его королю, который удерживал ладью от удара и следующим ходом своего короля вы с лёгкостью заберёте его ладью и проведёте пешку, выиграв партию!
  Поздравляем!";
                var blackKing = (King)ChessBoard.ChessBoardMatrix[3, 0];
                ChessBoard.ChessBoardMatrix[4, 0] = blackKing;
                ChessBoard.ChessBoardMatrix[3, 0] = null;
                this.UpdateChessBoard();
                MessageBox.Show(@"Замечательно! Вы поставили шах его королю, который удерживал ладью от удара и следующим ходом своего короля вы с лёгкостью заберёте его ладью и проведёте пешку, выиграв партию! Поздравляем!",
                                @"Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                whiteRook.Enabled = false;
            }
            else if (!moveCoord.Equals(new Coordinate(5, 3)) || (initialCoordinate.Column == 4))
            {
                this.MessageTextBox.Text += @"
  Найдите ход получше! Этим ходом вы передаёте инициативу своему сопернику!";
                MessageBox.Show(@"Найдите ход получше! Этим ходом вы передаёте инициативу своему сопернику!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                whiteRook.Clicks = 0;
                ChessBoard.Clear();
                this.LoadRookPracticeScene();
                this.UpdateChessBoard();
            }
        }

        #endregion Rook

        #region Bishop

        private void LoadBishopPracticeScene()
        {
            var whiteBishop  = new Bishop(new Coordinate(4, 7), "White");
            var whiteBishop1 = new Bishop(new Coordinate(4, 2), "White");
            whiteBishop.Click  += this.Bishop_Click;
            whiteBishop1.Click += this.Bishop_Click;
            var whiteRook      = new Rook(new Coordinate(0, 5), "White");
            var whiteRookAddit = new Rook(new Coordinate(7, 5), "White");
            whiteRook.Click      += this.RookInBishopLesson_Click;
            whiteRookAddit.Click += this.RookInBishopLesson_Click;
            _                    =  new King(new Coordinate(7, 0), "White");
            _                    =  new King(new Coordinate(0, 1), "Black");
            _                    =  new Pawn(new Coordinate(3, 4), "Black");
            _                    =  new Pawn(new Coordinate(1, 0), "Black");
            _                    =  new Pawn(new Coordinate(1, 1), "Black");
            _                    =  new Pawn(new Coordinate(1, 2), "Black");
            _                    =  new Rook(new Coordinate(0, 2), "Black");

            this.UpdateChessBoard();
        }

        private void RookInBishopLesson_Click(object sender, EventArgs e)
        {
            var whiteRook = (Rook)sender;
            this._lastClickedPiece = whiteRook;
            whiteRook.Clicks++;
            whiteRook.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteRook.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidRookMoveInBishopLesson_Click;
                    piece.Click += this.ValidRookMoveInBishopLesson_Click;
                }
            }
        }

        private void ValidRookMoveInBishopLesson_Click(object sender, EventArgs e)
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var         whiteRook    = (Rook)this._lastClickedPiece;
            Coordinate? initialCoord = whiteRook.CurrentCoordinate;
            var         move         = (ChessPiece)sender;
            Coordinate? moveCoord    = move.CurrentCoordinate;
            whiteRook.ToggleShowValidMoves();
            whiteRook.MoveTo(moveCoord);
            this.UpdateChessBoard();
            if ((initialCoord.Row == 7) && (moveCoord.Row == 0) && (ChessBoard.ChessBoardMatrix[1, 0] != null))
            {
                this.MessageTextBox.Text += @"
  Отлично! Вы поставили мат королю соперника, поздравляю!";
                ChessBoard.ChessBoardMatrix[1, 0].BackColor = Color.Red;
                this.UpdateChessBoard();
                MessageBox.Show(@"Отлично! Вы поставили мат королю соперника, поздравляю!", @"Победа!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control control in this.tableLayoutPanel1.Controls)
                {
                    control.Enabled = false;
                }
            }
            else if ((initialCoord.Row == 7) && (moveCoord.Row == 0))
            {
                var blackKing = (King)ChessBoard.ChessBoardMatrix[2, 0];
                ChessBoard.ChessBoardMatrix[3, 1] = blackKing;
                ChessBoard.ChessBoardMatrix[2, 0] = null;
                this.UpdateChessBoard();
                this.MessageTextBox.Text += @"
  Найдите ход получше! Этим ходом вы не сможете обеспечить мат в 3 хода своему сопернику!";
                MessageBox.Show(@"Найдите ход получше! Этим ходом вы не сможете обеспечить мат в 3 хода своему сопернику!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                whiteRook.Clicks = 0;
                ChessBoard.Clear();
                this.LoadBishopPracticeScene();
                this.UpdateChessBoard();
            }
            else if (moveCoord.Equals(new Coordinate(0, 2)))
            {
                this.MessageTextBox.Text += @"
  Отличный ход! Продолжайте!";
                var blackKing = (King)ChessBoard.ChessBoardMatrix[1, 0];
                ChessBoard.ChessBoardMatrix[2, 0] = blackKing;
                ChessBoard.ChessBoardMatrix[1, 0] = null;
                this.UpdateChessBoard();
            }
            else if (whiteRook.Clicks == 0)
            {
                var blackPawn = (Pawn)ChessBoard.ChessBoardMatrix[0, 1];
                ChessBoard.ChessBoardMatrix[0, 2] = blackPawn;
                ChessBoard.ChessBoardMatrix[0, 1] = null;
                this.UpdateChessBoard();
                this.MessageTextBox.Text += @"
  Найдите ход получше! Этим ходом вы не сможете обеспечить мат в 3 хода своему сопернику!";
                MessageBox.Show(@"Найдите ход получше! Этим ходом вы не сможете обеспечить мат в 3 хода своему сопернику!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                whiteRook.Clicks = 0;
                ChessBoard.Clear();
                this.LoadBishopPracticeScene();
                this.UpdateChessBoard();
            }
        }

        private void Bishop_Click(object sender, EventArgs e)
        {
            var whiteBishop = (Bishop)sender;
            this._lastClickedPiece = whiteBishop;
            whiteBishop.Clicks++;
            whiteBishop.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteBishop.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidBishopMove_Click;
                    piece.Click += this.ValidBishopMove_Click;
                }
            }
        }

        private void ValidBishopMove_Click(object sender, EventArgs e)
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var         whiteBishop   = (Bishop)this._lastClickedPiece;
            int         initialColumn = whiteBishop.CurrentCoordinate.Column;
            var         move          = (ChessPiece)sender;
            Coordinate? moveCoord     = move.CurrentCoordinate;
            whiteBishop.ToggleShowValidMoves();
            whiteBishop.MoveTo(moveCoord);
            this.UpdateChessBoard();

            if (ChessBoard.ChessBoardMatrix[1, 0] is King
             || (initialColumn == 7)
             || !this._lastClickedPiece.CurrentCoordinate.Equals(new Coordinate(2, 4)))
            {
                var blackPawn = (Pawn)ChessBoard.ChessBoardMatrix[0, 1];
                ChessBoard.ChessBoardMatrix[0, 2] = blackPawn;
                ChessBoard.ChessBoardMatrix[0, 1] = null;
                this.UpdateChessBoard();
                this.MessageTextBox.Text += @"
  Найдите ход получше! Этим ходом вы не сможете обеспечить мат в 3 хода своему сопернику!";
                MessageBox.Show(@"Найдите ход получше! Этим ходом вы не сможете обеспечить мат в 3 хода своему сопернику!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this._lastClickedPiece.Clicks = 0;
                ChessBoard.Clear();
                this.LoadBishopPracticeScene();
                this.UpdateChessBoard();
            }
            else if (this._lastClickedPiece.CurrentCoordinate.Equals(new Coordinate(2, 4))
                  && (this._lastClickedPiece.Clicks == 0))
            {
                this.MessageTextBox.Text += @"
  Вот это да! Осталось поставить сам мат!";
                var blackKing = (King)ChessBoard.ChessBoardMatrix[2, 0];
                ChessBoard.ChessBoardMatrix[1, 0] = blackKing;
                ChessBoard.ChessBoardMatrix[2, 0] = null;
                this.UpdateChessBoard();
            }
        }

        #endregion Bishop

        #region Queen

        private void LoadQueenPracticeScene()
        {
            var whiteKing = new King(new Coordinate(3, 7), "White");
            whiteKing.Click   += this.King_Click;
            whiteKing.Enabled =  false;
            var whiteQueen = new Queen(new Coordinate(0, 0), "White");
            whiteQueen.Click += this.Queen_Click;
            _                =  new Pawn(new Coordinate(6, 0), "White");

            _ = new King(new Coordinate(1, 7), "Black");
            _ = new Pawn(new Coordinate(1, 6), "Black");
            this.UpdateChessBoard();
        }

        private void King_Click(object sender, EventArgs e)
        {
            var whiteKing = (King)sender;
            this._lastClickedPiece = whiteKing;
            whiteKing.Clicks++;
            whiteKing.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteKing.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidKingMoveInQueenLesson_Click;
                    piece.Click += this.ValidKingMoveInQueenLesson_Click;
                }
            }
        }

        private void ValidKingMoveInQueenLesson_Click(object sender, EventArgs e)
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var         whiteKing = (King)this._lastClickedPiece;
            var         move      = (ChessPiece)sender;
            Coordinate? moveCoord = move.CurrentCoordinate;
            whiteKing.ToggleShowValidMoves();
            whiteKing.MoveTo(moveCoord);
            this.UpdateChessBoard();

            if (move.CurrentCoordinate.Equals(new Coordinate(2, 6)))
            {
                this.MessageTextBox.Text
                    += @"
  Отлично! Найти такой ход довольно непросто, таким ходом вы отрезали королю путь через пешку,
но не торопитесь, ведь можете загнать короля оппонента в пат – когда ему некуда будет ходить, тогда будет ничья, а вам нужно поставить ему мат!";

                var blackKing = (King)ChessBoard.ChessBoardMatrix[6, 0];
                ChessBoard.ChessBoardMatrix[5, 0] = blackKing;
                ChessBoard.ChessBoardMatrix[6, 0] = null;
                this.UpdateChessBoard();
                Control? control = this.tableLayoutPanel1.GetControlFromPosition(6, 2);
                control.Enabled = false;
            }
            else
            {
                this.MessageTextBox.Text += @"  Этот ход не позволяет поставить мат королю соперника в 4 хода!";
                MessageBox.Show(@"Этот ход не позволяет поставить мат королю соперника в 4 хода!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this._lastClickedPiece.Clicks = 0;
                ChessBoard.Clear();
                this.LoadQueenPracticeScene();
                this.UpdateChessBoard();
            }
        }

        private void Queen_Click(object sender, EventArgs e)
        {
            var whiteQueen = (Queen)sender;
            this._lastClickedPiece = whiteQueen;
            whiteQueen.Clicks++;
            whiteQueen.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteQueen.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidQueenMove_Click;
                    piece.Click += this.ValidQueenMove_Click;
                }
            }
        }

        private bool _isMate;

        private void ValidQueenMove_Click(object sender, EventArgs e)
        {
            if (this._lastClickedPiece == null)
            {
                return;
            }

            var         whiteQueen    = (Queen)this._lastClickedPiece;
            int         initialColumn = whiteQueen.CurrentCoordinate.Column;
            var         move          = (ChessPiece)sender;
            Coordinate? moveCoord     = move.CurrentCoordinate;
            whiteQueen.ToggleShowValidMoves();
            whiteQueen.MoveTo(moveCoord);
            this.UpdateChessBoard();

            Coordinate[] mateCoordinates =
            {
                new Coordinate(0, 1),
                new Coordinate(0, 4),
                new Coordinate(1, 6)
            };

            if (this._isMate && mateCoordinates.Contains(moveCoord))
            {
                this.MessageTextBox.Text
                    += @"  Отлично! Вы поняли, что король может быть загнут в пат, а вам нужно поставить ему мат!
  Вы справились с матом в 4 хода, поздравляю!";
                MessageBox.Show(@"Вы справились с матом в 4 хода, поздравляю!",
                                @"Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (moveCoord.Equals(new Coordinate(4, 4)) && (initialColumn == 0))
            {
                this.MessageTextBox.Text += @"
  Хороший ход, вы дали королю соперника шах, и уйти он может только дальше за пешку. Прдолжайте!";
                var blackKing = (King)ChessBoard.ChessBoardMatrix[7, 1];
                ChessBoard.ChessBoardMatrix[6, 0] = blackKing;
                ChessBoard.ChessBoardMatrix[7, 1] = null;
                this.UpdateChessBoard();
                var whiteKing = (King)ChessBoard.ChessBoardMatrix[7, 3];
                whiteKing.Enabled = true;
                whiteKing.ValidMoves.Add(new Coordinate(2, 6));
                whiteKing.ValidMoves.Add(new Coordinate(4, 6));
                whiteKing.ValidMoves.Add(new Coordinate(4, 7));
                whiteKing.ValidMoves.Add(new Coordinate(3, 6));
            }
            else if (ChessBoard.ChessBoardMatrix[5, 0] is King)
            {
                Coordinate[] possibleMovesCoords =
                {
                    new Coordinate(3, 4),
                    new Coordinate(5, 4),
                    new Coordinate(6, 4),
                    new Coordinate(7, 4),
                };
                if (moveCoord.Equals(new Coordinate(2, 4)))
                {
                    this.MessageTextBox.Text += @"
  Сделав этот ход вы не оставили оппоненту ни хода, но шаха нет,
поэтому вы получаете пат – игра оканчивается ничьёй! Но нас это не устраивает, попробуйте снова!";
                    MessageBox.Show(@"Сделав этот ход вы не оставили оппоненту ни хода, но шаха нет,
поэтому вы получаете пат – игра оканчивается ничьёй! Но нас это не устраивает, попробуйте снова!",
                                    @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this._lastClickedPiece.Clicks = 0;
                    ChessBoard.Clear();
                    this.LoadQueenPracticeScene();
                    this.UpdateChessBoard();
                }
                else if (possibleMovesCoords.Contains(moveCoord))
                {
                    this.MessageTextBox.Text += @"
  Отличный ход, вы дали королю соперника возможность уйти и теперь он у вас в руках! Ставьте мат!";
                    var blackKing = (King)ChessBoard.ChessBoardMatrix[5, 0];
                    ChessBoard.ChessBoardMatrix[6, 0] = blackKing;
                    ChessBoard.ChessBoardMatrix[5, 0] = null;
                    this.UpdateChessBoard();
                    this._isMate = true;
                }
                else
                {
                    this.MessageTextBox.Text += @"  Этот ход не позволяет поставить мат королю соперника в 4 хода!";
                    MessageBox.Show(@"Этот ход не позволяет поставить мат королю соперника в 4 хода!",
                                    @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this._lastClickedPiece.Clicks = 0;
                    ChessBoard.Clear();
                    this.LoadQueenPracticeScene();
                    this.UpdateChessBoard();
                }
            }
            else if (!moveCoord.Equals(new Coordinate(4, 4)) && !moveCoord.Equals(new Coordinate(2, 4)))
            {
                this.MessageTextBox.Text += @"  Этот ход не позволяет поставить мат королю соперника в 4 хода!";
                MessageBox.Show(@"Этот ход не позволяет поставить мат королю соперника в 4 хода!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this._lastClickedPiece.Clicks = 0;
                ChessBoard.Clear();
                this.LoadQueenPracticeScene();
                this.UpdateChessBoard();
            }
            else if (ChessBoard.ChessBoardMatrix[6, 0] is King && moveCoord.Equals(new Coordinate(2, 4)))
            {
                this.MessageTextBox.Text += @"  Этот ход не позволяет поставить мат королю соперника в 4 хода!";
                MessageBox.Show(@"Этот ход не позволяет поставить мат королю соперника в 4 хода!",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this._lastClickedPiece.Clicks = 0;
                ChessBoard.Clear();
                this.LoadQueenPracticeScene();
                this.UpdateChessBoard();
            }
        }

        #endregion Queen

        private void LoadKnightPracticeScene()
        {
            // White
            var whiteKnightRight = new Knight(new Coordinate(5, 5), "White");
            whiteKnightRight.Click += this.Knight_Click;
            var whiteKnightLeft = new Knight(new Coordinate(5, 2), "White");
            whiteKnightLeft.Click += this.Knight_Click;
            new Rook(new Coordinate(7, 7), "White");
            new Rook(new Coordinate(7, 0), "White");
            var bishop = new Bishop(new Coordinate(4, 2), "White");
            bishop.Click += this.BishopInknightLesson_Click;
            new Bishop(new Coordinate(7, 2), "White");
            new Queen(new Coordinate(7,  3), "White");
            new King(new Coordinate(7,   4), "White");
            for (var i = 0; i < 8; i++)
            {
                _ = new Pawn(new Coordinate(6, i), "White");
            }

            var whitePawn = (Pawn)ChessBoard.ChessBoardMatrix[4, 6];
            whitePawn.MoveTo(new Coordinate(4, 4));

            // Black
            for (var i = 0; i < 8; i++)
            {
                _ = new Pawn(new Coordinate(1, i), "Black");
            }

            var blackPawn = (Pawn)ChessBoard.ChessBoardMatrix[4, 1];
            blackPawn.MoveTo(new Coordinate(3, 4));
            var blackPawn2 = (Pawn)ChessBoard.ChessBoardMatrix[3, 1];
            blackPawn2.MoveTo(new Coordinate(2, 3));
            _ = new Bishop(new Coordinate(4, 6), "Black");
            _ = new Bishop(new Coordinate(0, 5), "Black");
            _ = new Knight(new Coordinate(2, 2), "Black");
            _ = new Knight(new Coordinate(0, 6), "Black");
            _ = new Rook(new Coordinate(0,   0), "Black");
            _ = new Rook(new Coordinate(0,   7), "Black");
            _ = new Queen(new Coordinate(0,  3), "Black");
            _ = new King(new Coordinate(0,   4), "Black");

            this.UpdateChessBoard();
        }

        private void BishopInknightLesson_Click(object sender, EventArgs e)
        {
            var whiteBishop = (Bishop)sender;
            this._lastClickedPiece = whiteBishop;
            whiteBishop.Clicks++;
            whiteBishop.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteBishop.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidBishopMoveInKnightLesson_Click;
                    piece.Click += this.ValidBishopMoveInKnightLesson_Click;
                }
            }
        }

        private void ValidBishopMoveInKnightLesson_Click(object sender, EventArgs e)
        {
            if (!(this._lastClickedPiece is Bishop whiteBishop))
            {
                return;
            }

            var         move        = (ChessPiece)sender;
            Coordinate? moveCoord   = move.CurrentCoordinate;
            whiteBishop.ToggleShowValidMoves();
            whiteBishop.MoveTo(moveCoord);
            this.UpdateChessBoard();

            if (ChessBoard.ChessBoardMatrix[4, 3] is Knight && moveCoord.Equals(new Coordinate(1, 5)))
            {
                this.MessageTextBox.Text += @"
  Отлично! Началась атака на короля, а теперь завершите её красивым матом для вражеского короля!";
                var blackKing = (King)ChessBoard.ChessBoardMatrix[4, 0];
                blackKing.ValidMoves.Add(new Coordinate(1, 4));
                blackKing.MoveTo(new Coordinate(1,         4));
                this.UpdateChessBoard();
            }
            else
            {
                this.MessageTextBox.Text += @"  Этот ход не позволяет поставить мат королю соперника в 4 хода!";
                MessageBox.Show(@"Этот ход не позволяет поставить мат королю соперника! Попробуйте ещё раз.",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this._lastClickedPiece.Clicks = 0;
                ChessBoard.Clear();
                this.LoadKnightPracticeScene();
                this.UpdateChessBoard();
            }
        }

        private void Knight_Click(object sender, EventArgs e)
        {
            var whiteKnight = (Knight)sender;
            this._lastClickedPiece = whiteKnight;
            whiteKnight.Clicks++;
            whiteKnight.ToggleShowValidMoves();
            this.UpdateChessBoard();

            List<Coordinate>? validMoveCoords = whiteKnight.GetValidMoves();
            IEnumerable<ChessPiece> validMoves = validMoveCoords
               .Select(coordinate =>
                           ChessBoard.ChessBoardMatrix[coordinate.Column,
                                                       coordinate.Row]);
            foreach (ChessPiece piece in validMoves)
            {
                if ((piece != null) && (piece is ValidMove || (piece.BackColor == Color.Red)))
                {
                    piece.Click -= this.ValidKnightMove_Click;
                    piece.Click += this.ValidKnightMove_Click;
                }
            }
        }

        private void ValidKnightMove_Click(object sender, EventArgs e)
        {
            if (!(this._lastClickedPiece is Knight whiteKnight))
            {
                return;
            }

            var         move        = (ChessPiece)sender;
            Coordinate? moveCoord   = move.CurrentCoordinate;
            whiteKnight.ToggleShowValidMoves();
            whiteKnight.MoveTo(moveCoord);
            this.UpdateChessBoard();

            if (moveCoord.Equals(new Coordinate(3, 4)))
            {
                this.MessageTextBox.Text += @"
  Хорошо! Наш ферзь оказался забранным, но теперь мы можем начать атаку на короля врага!";
                var blackBishop = (Bishop)ChessBoard.ChessBoardMatrix[6, 4];
                blackBishop.MoveTo(new Coordinate(7, 3));
                this.UpdateChessBoard();
            }
            else if (ChessBoard.ChessBoardMatrix[5, 1] is Bishop && moveCoord.Equals(new Coordinate(3, 3)))
            {
                this.MessageTextBox.Text += @"
  Поздравляем! Вы смогли поставить ""мат Легаля""! Надеемся, что навыки, полученные в ходе прохождения курса не пропадут зря!
  Учитесь играть в шахматы играя!";
                MessageBox.Show("Поздравляем! Вы смогли поставить \"мат Легаля\"! Надеемся, что навыки, полученные в ходе прохождения курса не пропадут зря! Учитесь играть в шахматы играя!",
                                "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.MessageTextBox.Text += @"  Этот ход не позволяет поставить мат королю соперника в 4 хода!";
                MessageBox.Show(@"Этот ход не позволяет поставить мат королю соперника! Лучше следовать советам)",
                                @"Неверный ход!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this._lastClickedPiece.Clicks = 0;
                ChessBoard.Clear();
                this.LoadKnightPracticeScene();
                this.UpdateChessBoard();
            }
        }
    }
}
