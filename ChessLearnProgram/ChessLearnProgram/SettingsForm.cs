using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    public sealed partial class SettingsForm : Form
    {
        public static bool IsShowMoves = true;
        public static bool IsHilightLastMove = true;
        public SettingsForm()
        {
            this.InitializeComponent();
            this.ValidMovesCheckBox.Checked = true;
            this.MoveSoundsCheckBox.Checked = true;
        }

        private void ValidMovesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsShowMoves = this.ValidMovesCheckBox.Checked;
        }

        private void MoveSoundsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsHilightLastMove = this.MoveSoundsCheckBox.Checked;
        }
    }
}
