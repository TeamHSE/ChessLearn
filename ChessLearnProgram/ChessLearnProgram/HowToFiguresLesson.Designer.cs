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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToFiguresLesson));
            this.HowToFiguresLessonsLabel = new System.Windows.Forms.Label();
            this.HowToBishopButton = new System.Windows.Forms.Button();
            this.HowToKingButton = new System.Windows.Forms.Button();
            this.HowToKnightButton = new System.Windows.Forms.Button();
            this.HowToQueenButton = new System.Windows.Forms.Button();
            this.HowToRookButton = new System.Windows.Forms.Button();
            this.HowToPawnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HowToFiguresLessonsLabel
            // 
            this.HowToFiguresLessonsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HowToFiguresLessonsLabel.BackColor = System.Drawing.Color.Transparent;
            this.HowToFiguresLessonsLabel.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToFiguresLessonsLabel.Location = new System.Drawing.Point(13, -1);
            this.HowToFiguresLessonsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HowToFiguresLessonsLabel.Name = "HowToFiguresLessonsLabel";
            this.HowToFiguresLessonsLabel.Size = new System.Drawing.Size(1035, 114);
            this.HowToFiguresLessonsLabel.TabIndex = 0;
            this.HowToFiguresLessonsLabel.Text = "Как ходят фигуры";
            this.HowToFiguresLessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToBishopButton
            // 
            this.HowToBishopButton.BackColor = System.Drawing.Color.Transparent;
            this.HowToBishopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToBishopButton.BackgroundImage")));
            this.HowToBishopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowToBishopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowToBishopButton.FlatAppearance.BorderSize = 0;
            this.HowToBishopButton.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToBishopButton.Location = new System.Drawing.Point(424, 305);
            this.HowToBishopButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToBishopButton.Name = "HowToBishopButton";
            this.HowToBishopButton.Size = new System.Drawing.Size(202, 86);
            this.HowToBishopButton.TabIndex = 3;
            this.HowToBishopButton.Text = "Слон";
            this.HowToBishopButton.UseVisualStyleBackColor = false;
            this.HowToBishopButton.Click += new System.EventHandler(this.HowToBishopButton_Click);
            // 
            // HowToKingButton
            // 
            this.HowToKingButton.BackColor = System.Drawing.Color.Transparent;
            this.HowToKingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToKingButton.BackgroundImage")));
            this.HowToKingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowToKingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowToKingButton.FlatAppearance.BorderSize = 0;
            this.HowToKingButton.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToKingButton.Location = new System.Drawing.Point(424, 399);
            this.HowToKingButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToKingButton.Name = "HowToKingButton";
            this.HowToKingButton.Size = new System.Drawing.Size(202, 86);
            this.HowToKingButton.TabIndex = 2;
            this.HowToKingButton.Text = "Король";
            this.HowToKingButton.UseVisualStyleBackColor = false;
            this.HowToKingButton.Click += new System.EventHandler(this.HowToKingButton_Click);
            // 
            // HowToKnightButton
            // 
            this.HowToKnightButton.BackColor = System.Drawing.Color.Transparent;
            this.HowToKnightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToKnightButton.BackgroundImage")));
            this.HowToKnightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowToKnightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowToKnightButton.FlatAppearance.BorderSize = 0;
            this.HowToKnightButton.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToKnightButton.Location = new System.Drawing.Point(424, 587);
            this.HowToKnightButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToKnightButton.Name = "HowToKnightButton";
            this.HowToKnightButton.Size = new System.Drawing.Size(202, 86);
            this.HowToKnightButton.TabIndex = 5;
            this.HowToKnightButton.Text = "Конь";
            this.HowToKnightButton.UseVisualStyleBackColor = false;
            this.HowToKnightButton.Click += new System.EventHandler(this.HowToKnightButton_Click);
            // 
            // HowToQueenButton
            // 
            this.HowToQueenButton.BackColor = System.Drawing.Color.Transparent;
            this.HowToQueenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToQueenButton.BackgroundImage")));
            this.HowToQueenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowToQueenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowToQueenButton.FlatAppearance.BorderSize = 0;
            this.HowToQueenButton.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToQueenButton.Location = new System.Drawing.Point(424, 493);
            this.HowToQueenButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToQueenButton.Name = "HowToQueenButton";
            this.HowToQueenButton.Size = new System.Drawing.Size(202, 86);
            this.HowToQueenButton.TabIndex = 6;
            this.HowToQueenButton.Text = "Ферзь";
            this.HowToQueenButton.UseVisualStyleBackColor = false;
            this.HowToQueenButton.Click += new System.EventHandler(this.HowToQueenButton_Click);
            // 
            // HowToRookButton
            // 
            this.HowToRookButton.BackColor = System.Drawing.Color.Transparent;
            this.HowToRookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToRookButton.BackgroundImage")));
            this.HowToRookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowToRookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowToRookButton.FlatAppearance.BorderSize = 0;
            this.HowToRookButton.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToRookButton.Location = new System.Drawing.Point(424, 211);
            this.HowToRookButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToRookButton.Name = "HowToRookButton";
            this.HowToRookButton.Size = new System.Drawing.Size(202, 86);
            this.HowToRookButton.TabIndex = 4;
            this.HowToRookButton.Text = "Ладья";
            this.HowToRookButton.UseVisualStyleBackColor = false;
            this.HowToRookButton.Click += new System.EventHandler(this.HowToRookButton_Click);
            // 
            // HowToPawnButton
            // 
            this.HowToPawnButton.BackColor = System.Drawing.Color.Transparent;
            this.HowToPawnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToPawnButton.BackgroundImage")));
            this.HowToPawnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowToPawnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowToPawnButton.FlatAppearance.BorderSize = 0;
            this.HowToPawnButton.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPawnButton.Location = new System.Drawing.Point(424, 117);
            this.HowToPawnButton.Margin = new System.Windows.Forms.Padding(4);
            this.HowToPawnButton.Name = "HowToPawnButton";
            this.HowToPawnButton.Size = new System.Drawing.Size(202, 86);
            this.HowToPawnButton.TabIndex = 1;
            this.HowToPawnButton.Text = "Пешка";
            this.HowToPawnButton.UseVisualStyleBackColor = false;
            this.HowToPawnButton.Click += new System.EventHandler(this.HowToPawnButton_Click);
            // 
            // HowToFiguresLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChessLearnProgram.Properties.Resources.Фон;
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
            this.Text = "Каталог уроков";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button HowToBishopButton;
        private System.Windows.Forms.Button HowToKingButton;
        private System.Windows.Forms.Button HowToKnightButton;
        private System.Windows.Forms.Button HowToQueenButton;
        private System.Windows.Forms.Button HowToRookButton;

        private System.Windows.Forms.Label HowToFiguresLessonsLabel;

        #endregion

        private System.Windows.Forms.Button HowToPawnButton;
    }
}

