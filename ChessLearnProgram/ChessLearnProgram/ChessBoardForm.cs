using System;
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
        private SoundPlayer[] _sounds =
        {
            new SoundPlayer("C:\\Users\\aleks\\RiderProjects\\ChessLearn\\"
                          + "ChessLearnProgram\\ChessLearnProgram\\Properties\\Audio\\pawn_train.wav"),
        };

        private SoundPlayer _currentSound;

        private int _playButtonClicks;

        private Pawn _pawn;

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
            SoundPlayer soundPlayer = this._currentSound;
            if ((this._playButtonClicks % 2) != 0)
            {
                soundPlayer.Play();
            }
            else
            {
                soundPlayer.Stop();
            }

            var thread = new Thread(() =>
                                    {
                                        // sleep 23 seconds
                                        Thread.Sleep(22000);
                                        Control centralWhitePawn
                                            = this.tableLayoutPanel1.GetControlFromPosition(4, 6);
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
                var whitePawn = new Pawn(new Coordinate(6, i), "White");
            }

            this.UpdateChessBoard();
            this._currentSound = this._sounds[0];

            this.MessageTextBox.Text
                = @"    Шахматы – популярная развивающая игра и полезно начать её изучение с того, как ходят фигуры на шахматной доске.
    Начнём с пешки. Всего пешек в начале игры 8 – как у вас, так и у противника. Располагаются пешки на двух горизонталях в ряд, занимая всю ширину доски.
    Пешка ходит только вперед на одну или две клетки, если на пути пешки стоит другая фигура, то ход невозможен.
    Первым ходом с начальной горизонтали пешка может пойти как на одну, так и на две клетки вперёд.
    Если пешка уже не на начальной горизонтали, то она может продвигаться только на одну клетку вперёд.";
        }
    }
}
