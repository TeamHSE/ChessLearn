using System.ComponentModel;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class SettingsForm
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
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.WayToMoveDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.WayToMoveSettingsLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(409, 31);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(274, 58);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Настройки";
            // 
            // WayToMoveDomainUpDown
            // 
            this.WayToMoveDomainUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.WayToMoveDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveDomainUpDown.Items.Add("Перетаскивать");
            this.WayToMoveDomainUpDown.Items.Add("Кликами");
            this.WayToMoveDomainUpDown.Items.Add("Обоими способами");
            this.WayToMoveDomainUpDown.Location = new System.Drawing.Point(453, 281);
            this.WayToMoveDomainUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.WayToMoveDomainUpDown.Name = "WayToMoveDomainUpDown";
            this.WayToMoveDomainUpDown.ReadOnly = true;
            this.WayToMoveDomainUpDown.Size = new System.Drawing.Size(220, 30);
            this.WayToMoveDomainUpDown.TabIndex = 16;
            this.WayToMoveDomainUpDown.Text = "Перетаскивать";
            this.WayToMoveDomainUpDown.SelectedItemChanged += new System.EventHandler(this.WayToMoveDomainUpDown_SelectedItemChanged);
            // 
            // WayToMoveSettingsLabel
            // 
            this.WayToMoveSettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.WayToMoveSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveSettingsLabel.Image = global::ChessLearnProgram.Properties.Resources.Фон_для_кнопки1;
            this.WayToMoveSettingsLabel.Location = new System.Drawing.Point(448, 170);
            this.WayToMoveSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WayToMoveSettingsLabel.Name = "WayToMoveSettingsLabel";
            this.WayToMoveSettingsLabel.Size = new System.Drawing.Size(244, 97);
            this.WayToMoveSettingsLabel.TabIndex = 15;
            this.WayToMoveSettingsLabel.Text = "Способ перемещения фигур";
            this.WayToMoveSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Image = global::ChessLearnProgram.Properties.Resources.Фон_для_кнопки1;
            this.checkBox1.Location = new System.Drawing.Point(444, 319);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(248, 98);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Показывать допустимые ходы";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Image = global::ChessLearnProgram.Properties.Resources.Фон_для_кнопки1;
            this.checkBox2.Location = new System.Drawing.Point(444, 439);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(245, 109);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Подсветка хода";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChessLearnProgram.Properties.Resources.Фон;
            this.ClientSize = new System.Drawing.Size(1095, 688);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.WayToMoveDomainUpDown);
            this.Controls.Add(this.WayToMoveSettingsLabel);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label        SettingsLabel;
        private DomainUpDown WayToMoveDomainUpDown;
        private Label        WayToMoveSettingsLabel;
        private CheckBox     checkBox1;
        private CheckBox checkBox2;
    }
}