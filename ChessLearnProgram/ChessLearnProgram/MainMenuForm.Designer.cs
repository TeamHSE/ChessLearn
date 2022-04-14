namespace ChessLearnProgram
{
    internal sealed partial class MainMenuForm
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
            this.MainMenuLabel  = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LessonsButton  = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuLabel.Location  = new System.Drawing.Point(225, 73);
            this.MainMenuLabel.Name      = "MainMenuLabel";
            this.MainMenuLabel.Size      = new System.Drawing.Size(359, 95);
            this.MainMenuLabel.TabIndex  = 0;
            this.MainMenuLabel.Text      = "Главное меню";
            this.MainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location                =  new System.Drawing.Point(483, 252);
            this.SettingsButton.MaximumSize             =  new System.Drawing.Size(500, 100);
            this.SettingsButton.MinimumSize             =  new System.Drawing.Size(100, 20);
            this.SettingsButton.Name                    =  "SettingsButton";
            this.SettingsButton.Size                    =  new System.Drawing.Size(250, 100);
            this.SettingsButton.TabIndex                =  1;
            this.SettingsButton.Text                    =  "Настройки";
            this.SettingsButton.UseVisualStyleBackColor =  true;
            this.SettingsButton.Click                   += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LessonsButton
            // 
            this.LessonsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                            | System.Windows.Forms.AnchorStyles.Left)));
            this.LessonsButton.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonsButton.Location                =  new System.Drawing.Point(66, 252);
            this.LessonsButton.MaximumSize             =  new System.Drawing.Size(500, 100);
            this.LessonsButton.MinimumSize             =  new System.Drawing.Size(100, 20);
            this.LessonsButton.Name                    =  "LessonsButton";
            this.LessonsButton.Size                    =  new System.Drawing.Size(250, 100);
            this.LessonsButton.TabIndex                =  2;
            this.LessonsButton.Text                    =  "Уроки";
            this.LessonsButton.UseVisualStyleBackColor =  true;
            this.LessonsButton.Click                   += new System.EventHandler(this.LessonsButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(825, 515);
            this.Controls.Add(this.LessonsButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MainMenuLabel);
            this.IsMdiContainer = true;
            this.MinimumSize    = new System.Drawing.Size(700, 500);
            this.Name           = "MainMenuForm";
            this.StartPosition  = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text           = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button LessonsButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.Label MainMenuLabel;

        #endregion
    }
}
