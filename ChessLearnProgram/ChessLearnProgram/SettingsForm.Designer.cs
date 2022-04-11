namespace ChessLearnProgram
{
    internal sealed partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.EmptyBox1 = new System.Windows.Forms.RichTextBox();
            this.EmptyBox2 = new System.Windows.Forms.RichTextBox();
            this.EmptyBox3 = new System.Windows.Forms.RichTextBox();
            this.GraphicsSettingsLabel = new System.Windows.Forms.Label();
            this.FullScreenСheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(287, 19);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(217, 46);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Настройки";
            // 
            // EmptyBox1
            // 
            this.EmptyBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox1.Enabled = false;
            this.EmptyBox1.Location = new System.Drawing.Point(31, 83);
            this.EmptyBox1.Name = "EmptyBox1";
            this.EmptyBox1.ReadOnly = true;
            this.EmptyBox1.Size = new System.Drawing.Size(194, 337);
            this.EmptyBox1.TabIndex = 1;
            this.EmptyBox1.Text = "";
            // 
            // EmptyBox2
            // 
            this.EmptyBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox2.Enabled = false;
            this.EmptyBox2.Location = new System.Drawing.Point(295, 83);
            this.EmptyBox2.Name = "EmptyBox2";
            this.EmptyBox2.ReadOnly = true;
            this.EmptyBox2.Size = new System.Drawing.Size(194, 337);
            this.EmptyBox2.TabIndex = 2;
            this.EmptyBox2.Text = "";
            // 
            // EmptyBox3
            // 
            this.EmptyBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox3.Enabled = false;
            this.EmptyBox3.Location = new System.Drawing.Point(569, 83);
            this.EmptyBox3.Name = "EmptyBox3";
            this.EmptyBox3.ReadOnly = true;
            this.EmptyBox3.Size = new System.Drawing.Size(194, 337);
            this.EmptyBox3.TabIndex = 3;
            this.EmptyBox3.Text = "";
            // 
            // GraphicsSettingsLabel
            // 
            this.GraphicsSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsSettingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphicsSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphicsSettingsLabel.Location = new System.Drawing.Point(55, 98);
            this.GraphicsSettingsLabel.Name = "GraphicsSettingsLabel";
            this.GraphicsSettingsLabel.Size = new System.Drawing.Size(147, 64);
            this.GraphicsSettingsLabel.TabIndex = 4;
            this.GraphicsSettingsLabel.Text = "Настройки изображения";
            this.GraphicsSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FullScreenСheckBox
            // 
            this.FullScreenСheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FullScreenСheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullScreenСheckBox.Location = new System.Drawing.Point(55, 209);
            this.FullScreenСheckBox.Name = "FullScreenСheckBox";
            this.FullScreenСheckBox.Size = new System.Drawing.Size(157, 54);
            this.FullScreenСheckBox.TabIndex = 6;
            this.FullScreenСheckBox.Text = "Полноэкранный режим";
            this.FullScreenСheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FullScreenСheckBox.UseVisualStyleBackColor = true;
            this.FullScreenСheckBox.CheckedChanged += new System.EventHandler(this.FullScreenСheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FullScreenСheckBox);
            this.Controls.Add(this.GraphicsSettingsLabel);
            this.Controls.Add(this.EmptyBox3);
            this.Controls.Add(this.EmptyBox2);
            this.Controls.Add(this.EmptyBox1);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.RichTextBox EmptyBox1;
        private System.Windows.Forms.RichTextBox EmptyBox2;
        private System.Windows.Forms.RichTextBox EmptyBox3;
        private System.Windows.Forms.Label GraphicsSettingsLabel;
        private System.Windows.Forms.CheckBox FullScreenСheckBox;
    }
}