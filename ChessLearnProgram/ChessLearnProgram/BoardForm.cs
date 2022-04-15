using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class BoardForm : Form
    {
        public BoardForm() => this.InitializeComponent();

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) => this.tableLayoutPanel1.Size += new Size(20, 20);

        private void button3_Click(object sender, EventArgs e) => this.tableLayoutPanel1.Size -= new Size(20, 20);

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private static int clickCount;

        private void button9_Click(object sender, EventArgs e)
        {
            var coords = this.tableLayoutPanel1.GetCellPosition(this.button9);

            if (clickCount % 2 == 0)
            {
                var possibleMove = new Button();
                this.tableLayoutPanel1.Controls.Add(new Button(), coords.Column, coords.Row - 1);
                possibleMove.Click += this.moveButtonClick;
            }
            else
            {
                this.tableLayoutPanel1.Controls.Remove(this.tableLayoutPanel1.GetControlFromPosition(coords.Column, coords.Row - 1));
            }
            ++clickCount;

        }

        private void moveButtonClick(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition coords = this.tableLayoutPanel1.GetCellPosition(this.button9);
            this.tableLayoutPanel1.Controls.Add(this.button9, coords.Column, coords.Row - 1);
        }

        private void TableLayoutPanel1OnCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var rectangle = e.CellBounds;
            rectangle.Inflate(-1, -1);
            ControlPaint.DrawBorder3D(e.Graphics, rectangle, Border3DStyle.Raised, Border3DSide.All); // 3D border
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition coords = this.tableLayoutPanel1.GetCellPosition(this.button9);
            this.tableLayoutPanel1.Controls.Add(this.button9, coords.Column, coords.Row - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }

}
