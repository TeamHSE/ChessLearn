using System.ComponentModel;

namespace ChessLearnProgram
{
    partial class HowToFiguresLesson
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
            this.HowToPawnButton          = new System.Windows.Forms.Button();
            this.HowToBishopButton        = new System.Windows.Forms.Button();
            this.HowToKingButton          = new System.Windows.Forms.Button();
            this.HowToKnightButton        = new System.Windows.Forms.Button();
            this.HowToQueenButton         = new System.Windows.Forms.Button();
            this.HowToRookButton          = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HowToFiguresLessonsLabel
            // 
            this.HowToFiguresLessonsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.HowToFiguresLessonsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowToFiguresLessonsLabel.Location  = new System.Drawing.Point(12, 9);
            this.HowToFiguresLessonsLabel.Name      = "HowToFiguresLessonsLabel";
            this.HowToFiguresLessonsLabel.Size      = new System.Drawing.Size(776, 93);
            this.HowToFiguresLessonsLabel.TabIndex  = 0;
            this.HowToFiguresLessonsLabel.Text      = "Как ходят фигуры";
            this.HowToFiguresLessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPawnButton
            // 
            this.HowToPawnButton.Location                =  new System.Drawing.Point(326, 126);
            this.HowToPawnButton.Name                    =  "HowToPawnButton";
            this.HowToPawnButton.Size                    =  new System.Drawing.Size(149, 48);
            this.HowToPawnButton.TabIndex                =  1;
            this.HowToPawnButton.Text                    =  "Пешка";
            this.HowToPawnButton.UseVisualStyleBackColor =  true;
            this.HowToPawnButton.Click                   += new System.EventHandler(this.HowToPawnButton_Click);
            // 
            // HowToBishopButton
            // 
            this.HowToBishopButton.Location                = new System.Drawing.Point(326, 262);
            this.HowToBishopButton.Name                    = "HowToBishopButton";
            this.HowToBishopButton.Size                    = new System.Drawing.Size(149, 48);
            this.HowToBishopButton.TabIndex                = 3;
            this.HowToBishopButton.Text                    = "Слон";
            this.HowToBishopButton.UseVisualStyleBackColor = true;
            // 
            // HowToKingButton
            // 
            this.HowToKingButton.Location                = new System.Drawing.Point(326, 194);
            this.HowToKingButton.Name                    = "HowToKingButton";
            this.HowToKingButton.Size                    = new System.Drawing.Size(149, 48);
            this.HowToKingButton.TabIndex                = 2;
            this.HowToKingButton.Text                    = "Король";
            this.HowToKingButton.UseVisualStyleBackColor = true;
            // 
            // HowToKnightButton
            // 
            this.HowToKnightButton.Location                = new System.Drawing.Point(326, 474);
            this.HowToKnightButton.Name                    = "HowToKnightButton";
            this.HowToKnightButton.Size                    = new System.Drawing.Size(149, 48);
            this.HowToKnightButton.TabIndex                = 5;
            this.HowToKnightButton.Text                    = "Конь";
            this.HowToKnightButton.UseVisualStyleBackColor = true;
            // 
            // HowToQueenButton
            // 
            this.HowToQueenButton.Location                = new System.Drawing.Point(326, 402);
            this.HowToQueenButton.Name                    = "HowToQueenButton";
            this.HowToQueenButton.Size                    = new System.Drawing.Size(149, 48);
            this.HowToQueenButton.TabIndex                = 6;
            this.HowToQueenButton.Text                    = "Ферзь";
            this.HowToQueenButton.UseVisualStyleBackColor = true;
            // 
            // HowToRookButton
            // 
            this.HowToRookButton.Location                = new System.Drawing.Point(326, 331);
            this.HowToRookButton.Name                    = "HowToRookButton";
            this.HowToRookButton.Size                    = new System.Drawing.Size(149, 48);
            this.HowToRookButton.TabIndex                = 4;
            this.HowToRookButton.Text                    = "Ладья";
            this.HowToRookButton.UseVisualStyleBackColor = true;
            // 
            // HowToFiguresLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.HowToRookButton);
            this.Controls.Add(this.HowToQueenButton);
            this.Controls.Add(this.HowToKnightButton);
            this.Controls.Add(this.HowToKingButton);
            this.Controls.Add(this.HowToBishopButton);
            this.Controls.Add(this.HowToPawnButton);
            this.Controls.Add(this.HowToFiguresLessonsLabel);
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

