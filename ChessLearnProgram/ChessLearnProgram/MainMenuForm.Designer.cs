using System.ComponentModel;

namespace ChessLearnProgram
{
    internal sealed partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LessonsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuLabel.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuLabel.Location = new System.Drawing.Point(271, 104);
            this.MainMenuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(450, 143);
            this.MainMenuLabel.TabIndex = 0;
            this.MainMenuLabel.Text = "Главное меню";
            this.MainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackgroundImage = global::ChessLearnProgram.Properties.Resources.Фон_для_кнопки1;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsButton.Font = new System.Drawing.Font("Old English Text MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ImageKey = "(отсутствует)";
            this.SettingsButton.Location = new System.Drawing.Point(575, 310);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.MaximumSize = new System.Drawing.Size(667, 123);
            this.SettingsButton.MinimumSize = new System.Drawing.Size(133, 25);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(333, 123);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LessonsButton
            // 
            this.LessonsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LessonsButton.BackgroundImage = global::ChessLearnProgram.Properties.Resources.Фон_для_кнопки1;
            this.LessonsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LessonsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LessonsButton.Font = new System.Drawing.Font("Old English Text MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonsButton.Location = new System.Drawing.Point(97, 310);
            this.LessonsButton.Margin = new System.Windows.Forms.Padding(4);
            this.LessonsButton.MaximumSize = new System.Drawing.Size(667, 123);
            this.LessonsButton.MinimumSize = new System.Drawing.Size(133, 25);
            this.LessonsButton.Name = "LessonsButton";
            this.LessonsButton.Size = new System.Drawing.Size(333, 123);
            this.LessonsButton.TabIndex = 2;
            this.LessonsButton.Text = "Уроки";
            this.LessonsButton.UseVisualStyleBackColor = true;
            this.LessonsButton.Click += new System.EventHandler(this.LessonsButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::ChessLearnProgram.Properties.Resources.Фон;
            this.ClientSize = new System.Drawing.Size(999, 581);
            this.Controls.Add(this.LessonsButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MainMenuLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(912, 404);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button LessonsButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.Label MainMenuLabel;

        #endregion
    }
}
