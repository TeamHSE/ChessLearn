using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    public partial class LessonsForm : Form
    {
        public LessonsForm()
        {
            this.InitializeComponent();
        }

        private void LessonFiguresButton_Click(object sender, EventArgs e)
        {
            var howToFiguresLesson = new HowToFiguresLesson();
            howToFiguresLesson.ShowDialog();
        }
    }
}
