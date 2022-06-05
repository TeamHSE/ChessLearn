using System.Collections.Generic;
using System.Windows.Forms;

namespace Chess.Pieces
{
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
            this.Color = "White";
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
