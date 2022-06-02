using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Queen: ChessPiece
    {
        public int Clicks = 0;

        public Queen(Coordinate coordinate, string color) : base(coordinate, color)
        {
            AllowDrop = true;
            Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AutoSize  = true;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = color == "Black"
                ? new Bitmap(ResourceBlack.Queen)
                : new Bitmap(ResourceWhite.Queen);

            BackgroundImageLayout      =  ImageLayout.Zoom;
            FlatAppearance.BorderColor =  System.Drawing.Color.White;
            FlatAppearance.BorderSize  =  0;
            FlatStyle                  =  FlatStyle.Flat;
            ForeColor                  =  System.Drawing.Color.DarkRed;
            Location                   =  new Point(173, 347);
            Margin                     =  new Padding(2);
            Name                       =  "Queen";
            Size                       =  new Size(53, 54);
            TabIndex                   =  7;
            UseVisualStyleBackColor    =  true;
        }
    }
}
