using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class King : ChessPiece
    {
        public King(Coordinate coordinate, string color) : base(coordinate, color)
        {
            AllowDrop = true;
            Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AutoSize  = true;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = color == "Black"
                                  ? new Bitmap(ResourceBlack.King)
                                  : new Bitmap(ResourceWhite.King);

            BackgroundImageLayout      = ImageLayout.Zoom;
            FlatAppearance.BorderColor = System.Drawing.Color.White;
            FlatAppearance.BorderSize  = 0;
            FlatStyle                  = FlatStyle.Flat;
            ForeColor                  = System.Drawing.Color.DarkRed;
            Location                   = new Point(173, 347);
            Margin                     = new Padding(2);
            Name                       = "King";
            Size                       = new Size(53, 54);
            TabIndex                   = 7;
            UseVisualStyleBackColor    = true;
        }

        public int Clicks { get; set; }
    }
}
