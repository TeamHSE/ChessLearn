using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public class EmptyControl : Button
    {
        public EmptyControl(ICoordinate coordinate)
        {
            var control = new Button();
            control.AllowDrop = true;
            control.Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            control.AutoSize  = true;
            control.BackColor = Color.Transparent;
            control.FlatAppearance.BorderColor =  Color.White;
            control.FlatAppearance.BorderSize  =  0;
            control.FlatStyle                  =  FlatStyle.Flat;
            control.ForeColor                  =  Color.DarkRed;
            control.Location                   =  new Point(173, 347);
            control.Margin                     =  new Padding(2);
            control.Name                       =  "EmptyControl";
            control.Size                       =  new Size(53, 54);
            control.TabIndex                   =  7;
            control.UseVisualStyleBackColor    =  true;
            ChessBoard.ChessBoardMatrix[coordinate.Column, coordinate.Row] = control;
        }
    }
}
