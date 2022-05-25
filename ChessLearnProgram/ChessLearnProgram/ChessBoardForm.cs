using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Chess;
using Chess.Pieces;
using ChessLearnProgram.Properties;

namespace ChessLearnProgram
{
    internal sealed partial class ChessBoardForm : Form
    {
        private readonly SoundPlayer[] _sounds =
        {
            new SoundPlayer(Resource.pawn_train),
        };

        private SoundPlayer _currentSound;

        private int _playButtonClicks;

        public ChessBoardForm()
        {
            this.InitializeComponent();
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    this.tableLayoutPanel1.Controls.Add(new EmptyControl(new Coordinate(j, i)), i, j);
                }
            }
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
            SoundPlayer soundPlayer = this._currentSound;
            if ((this._playButtonClicks % 2) != 0)
            {
                soundPlayer.Play();
            }
            else
            {
                soundPlayer.Stop();
                return;
            }

            var thread = new Thread(() =>
                                    {
                                        // sleep 23 seconds
                                        Thread.Sleep(22000);
                                        // Берем фигуру.
                                        Control centralWhitePawn
                                            = this.tableLayoutPanel1.GetControlFromPosition(4, 6);
                                        // Ставим на новую позицию.
                                        this.tableLayoutPanel1.Controls.Add(centralWhitePawn, 4, 5);
                                        Thread.Sleep(2000);
                                        Control centralBlackPawn = this.tableLayoutPanel1.GetControlFromPosition(3, 1);
                                        this.tableLayoutPanel1.Controls.Add(centralBlackPawn, 3, 3);
                                        Thread.Sleep(3000);
                                        Control nearWhitePawn = this.tableLayoutPanel1.GetControlFromPosition(3, 6);
                                        this.tableLayoutPanel1.Controls.Add(nearWhitePawn, 3, 4);
                                        Thread.Sleep(5000);
                                        Control nearBlackPawn
                                            = this.tableLayoutPanel1.GetControlFromPosition(2, 1);
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
                                    });
            thread.Start();
        }

        public void LoadPawnScene()
        {
            for (var i = 0; i < 8; i++)
            {
                var blackPawn = new Pawn(new Coordinate(1, i), "Black");
                blackPawn.Click += this.PawnOnClick;
                var whitePawn = new Pawn(new Coordinate(6, i), "White");
                whitePawn.Click += this.PawnOnClick;
            }

            this.UpdateChessBoard();
            this._currentSound = this._sounds[0];

            this.MessageTextBox.Text = Resource.pawn_train_text;
        }

        public void LoadKingScene()
        {
            var blackKing = new King(new Coordinate(4, 2), "Black");
            blackKing.Click += this.KingOnClick;
            var whiteKing = new King(new Coordinate(3, 6), "White");
            whiteKing.Click += this.KingOnClick;

            this.UpdateChessBoard();
            this._currentSound = this._sounds[0];

            // this.MessageTextBox.Text = Resource.king_train_text;
            this.MessageTextBox.Text = "Resource.king_train_text";
        }

        private void KingOnClick(object sender, EventArgs e)
        {
            ((King)sender).Clicks++;
            if ((((King)sender).Clicks % 2) != 0)
            {
                foreach (Button cell in ((King)sender).ValidMoves.Select(coordinate =>
                                                                             ChessBoard.ChessBoardMatrix
                                                                                 [coordinate.Column, coordinate.Row]))
                {
                    cell.BackColor = Color.Aquamarine;
                }
            }
            else
            {
                foreach (Button cell in ((King)sender).ValidMoves.Select(coordinate =>
                                                                             ChessBoard.ChessBoardMatrix
                                                                                 [coordinate.Column, coordinate.Row]))
                {
                    cell.BackColor = Color.Transparent;
                }
            }

            this.UpdateChessBoard();
        }

        private void PawnOnClick(object sender, EventArgs e)
        {
            ((Pawn)sender).Clicks++;
            if ((((Pawn)sender).Clicks % 2) != 0)
            {
                foreach (Button cell in ((Pawn)sender).ValidMoves.Select(coordinate =>
                                                                             ChessBoard.ChessBoardMatrix
                                                                                 [coordinate.Column, coordinate.Row]))
                {
                    cell.BackColor = Color.Aquamarine;
                }
            }
            else
            {
                foreach (Button cell in ((Pawn)sender).ValidMoves.Select(coordinate =>
                                                                             ChessBoard.ChessBoardMatrix
                                                                                 [coordinate.Column, coordinate.Row]))
                {
                    cell.BackColor = Color.Transparent;
                }
            }

            this.UpdateChessBoard();
        }
    }
}
