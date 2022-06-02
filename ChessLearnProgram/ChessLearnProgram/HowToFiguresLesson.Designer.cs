using System.ComponentModel;

namespace ChessLearnProgram
{
    sealed partial class HowToFiguresLesson
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
            this.HowToFiguresLessonsLabel = new System.Windows.Forms.Label();
            this.HowToPawnButton = new System.Windows.Forms.Button();
            this.HowToBishopButton = new System.Windows.Forms.Button();
            this.HowToKingButton = new System.Windows.Forms.Button();
            this.HowToKnightButton = new System.Windows.Forms.Button();
            this.HowToQueenButton = new System.Windows.Forms.Button();
            this.HowToRookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HowToFiguresLessonsLabel
            // 
            this.HowToFiguresLessonsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HowToFiguresLessonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowToFiguresLessonsLabel.Location = new System.Drawing.Point(16, 11);
            this.HowToFiguresLessonsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HowToFiguresLessonsLabel.Name = "HowToFiguresLessonsLabel";
            this.HowToFiguresLessonsLabel.Size = new System.Drawing.Size(1035, 114);
            this.HowToFiguresLessonsLabel.TabIndex = 0;
            this.HowToFiguresLessonsLabel.Text = "Как ходят фигуры";
            this.HowToFiguresLessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPawnButton
            // 
            this.HowToPawnButton.Location = new System.Drawing.Point(435, 155);
            this.HowToPawnButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToPawnButton.Name = "HowToPawnButton";
            this.HowToPawnButton.Size = new System.Drawing.Size(199, 59);
            this.HowToPawnButton.TabIndex = 1;
            this.HowToPawnButton.Text = "Пешка";
            this.HowToPawnButton.UseVisualStyleBackColor = true;
            this.HowToPawnButton.Click += new System.EventHandler(this.HowToPawnButton_Click);
            // 
            // HowToBishopButton
            // 
            this.HowToBishopButton.Location = new System.Drawing.Point(435, 322);
            this.HowToBishopButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToBishopButton.Name = "HowToBishopButton";
            this.HowToBishopButton.Size = new System.Drawing.Size(199, 59);
            this.HowToBishopButton.TabIndex = 3;
            this.HowToBishopButton.Text = "Слон";
            this.HowToBishopButton.UseVisualStyleBackColor = true;
            // 
            // HowToKingButton
            // 
            this.HowToKingButton.Location = new System.Drawing.Point(435, 239);
            this.HowToKingButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToKingButton.Name = "HowToKingButton";
            this.HowToKingButton.Size = new System.Drawing.Size(199, 59);
            this.HowToKingButton.TabIndex = 2;
            this.HowToKingButton.Text = "Король";
            this.HowToKingButton.UseVisualStyleBackColor = true;
            this.HowToKingButton.Click += new System.EventHandler(this.HowToKingButton_Click);
            // 
            // HowToKnightButton
            // 
            this.HowToKnightButton.Location = new System.Drawing.Point(435, 583);
            this.HowToKnightButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToKnightButton.Name = "HowToKnightButton";
            this.HowToKnightButton.Size = new System.Drawing.Size(199, 59);
            this.HowToKnightButton.TabIndex = 5;
            this.HowToKnightButton.Text = "Конь";
            this.HowToKnightButton.UseVisualStyleBackColor = true;
            this.HowToKnightButton.Click += new System.EventHandler(this.HowToKnightButton_Click);
            // 
            // HowToQueenButton
            // 
            this.HowToQueenButton.Location = new System.Drawing.Point(435, 495);
            this.HowToQueenButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToQueenButton.Name = "HowToQueenButton";
            this.HowToQueenButton.Size = new System.Drawing.Size(199, 59);
            this.HowToQueenButton.TabIndex = 6;
            this.HowToQueenButton.Text = "Ферзь";
            this.HowToQueenButton.UseVisualStyleBackColor = true;
            this.HowToQueenButton.Click += new System.EventHandler(this.HowToQueenButton_Click);
            // 
            // HowToRookButton
            // 
            this.HowToRookButton.Location = new System.Drawing.Point(435, 407);
            this.HowToRookButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToRookButton.Name = "HowToRookButton";
            this.HowToRookButton.Size = new System.Drawing.Size(199, 59);
            this.HowToRookButton.TabIndex = 4;
            this.HowToRookButton.Text = "Ладья";
            this.HowToRookButton.UseVisualStyleBackColor = true;
            this.HowToRookButton.Click += new System.EventHandler(this.HowToRookButton_Click);
            // 
            // HowToFiguresLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 706);
            this.Controls.Add(this.HowToRookButton);
            this.Controls.Add(this.HowToQueenButton);
            this.Controls.Add(this.HowToKnightButton);
            this.Controls.Add(this.HowToKingButton);
            this.Controls.Add(this.HowToBishopButton);
            this.Controls.Add(this.HowToPawnButton);
            this.Controls.Add(this.HowToFiguresLessonsLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HowToFiguresLesson";
            this.Text = "HowToFiguresLesson";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button HowToPawnButton;
        private System.Windows.Forms.Button HowToBishopButton;
        private System.Windows.Forms.Button HowToKingButton;
        private System.Windows.Forms.Button HowToKnightButton;
        private System.Windows.Forms.Button HowToQueenButton;
        private System.Windows.Forms.Button HowToRookButton;

        private System.Windows.Forms.Label HowToFiguresLessonsLabel;

        #endregion
    }
}

