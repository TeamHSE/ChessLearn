using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class BoardForm : Form
    {
        public BoardForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Size += new Size(20, 20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Size -= new Size(20, 20);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private static int clickCount = 0;

        private void button9_Click(object sender, EventArgs e)
        {
            var coords = tableLayoutPanel1.GetCellPosition(button9);

            if (clickCount % 2 == 0)
            {
                var possibleMove = new Button();
                tableLayoutPanel1.Controls.Add(new Button(), coords.Column, coords.Row - 1);
                possibleMove.Click += moveButtonClick;
            }
            else
            {
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(coords.Column, coords.Row - 1));
            }
            ++clickCount;

        }

        private void moveButtonClick(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition coords = tableLayoutPanel1.GetCellPosition(button9);
            tableLayoutPanel1.Controls.Add(button9, coords.Column, coords.Row - 1);
        }

        private void TableLayoutPanel1OnCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var rectangle = e.CellBounds;
            rectangle.Inflate(-1, -1);
            ControlPaint.DrawBorder3D(e.Graphics, rectangle, Border3DStyle.Raised, Border3DSide.All); // 3D border
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition coords = tableLayoutPanel1.GetCellPosition(button9);
            tableLayoutPanel1.Controls.Add(button9, coords.Column, coords.Row - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }

}
