﻿using System.ComponentModel;

namespace ChessLearnProgram
{
    partial class LessonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LessonsLabel        = new System.Windows.Forms.Label();
            this.LessonFiguresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LessonsLabel
            // 
            this.LessonsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.LessonsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonsLabel.Location  = new System.Drawing.Point(12, 9);
            this.LessonsLabel.Name      = "LessonsLabel";
            this.LessonsLabel.Size      = new System.Drawing.Size(776, 124);
            this.LessonsLabel.TabIndex  = 0;
            this.LessonsLabel.Text      = "Каталог уроков";
            this.LessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LessonFiguresButton
            // 
            this.LessonFiguresButton.Location                =  new System.Drawing.Point(327, 136);
            this.LessonFiguresButton.Name                    =  "LessonFiguresButton";
            this.LessonFiguresButton.Size                    =  new System.Drawing.Size(149, 48);
            this.LessonFiguresButton.TabIndex                =  1;
            this.LessonFiguresButton.Text                    =  "Фигуры";
            this.LessonFiguresButton.UseVisualStyleBackColor =  true;
            this.LessonFiguresButton.Click                   += new System.EventHandler(this.LessonFiguresButton_Click);
            // 
            // LessonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.LessonFiguresButton);
            this.Controls.Add(this.LessonsLabel);
            this.Name = "LessonsForm";
            this.Text = "LessonsForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button LessonFiguresButton;

        private System.Windows.Forms.Label LessonsLabel;

        #endregion
    }
}
