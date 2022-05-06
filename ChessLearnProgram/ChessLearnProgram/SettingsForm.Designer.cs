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
            this.EmptyBox3 = new System.Windows.Forms.RichTextBox();
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
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(409, 31);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(274, 58);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Настройки";
            // 
            // EmptyBox3
            // 
            this.EmptyBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmptyBox3.Enabled = false;
            this.EmptyBox3.Location = new System.Drawing.Point(318, 108);
            this.EmptyBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmptyBox3.Name = "EmptyBox3";
            this.EmptyBox3.ReadOnly = true;
            this.EmptyBox3.Size = new System.Drawing.Size(472, 544);
            this.EmptyBox3.TabIndex = 3;
            this.EmptyBox3.Text = "";
            // 
            // WayToMoveDomainUpDown
            // 
            this.WayToMoveDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveDomainUpDown.Items.Add("Перетаскивать");
            this.WayToMoveDomainUpDown.Items.Add("Кликами");
            this.WayToMoveDomainUpDown.Items.Add("Обоими способами");
            this.WayToMoveDomainUpDown.Location = new System.Drawing.Point(480, 253);
            this.WayToMoveDomainUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WayToMoveDomainUpDown.Name = "WayToMoveDomainUpDown";
            this.WayToMoveDomainUpDown.ReadOnly = true;
            this.WayToMoveDomainUpDown.Size = new System.Drawing.Size(165, 30);
            this.WayToMoveDomainUpDown.TabIndex = 16;
            this.WayToMoveDomainUpDown.Text = "Перетаскивать";
            this.WayToMoveDomainUpDown.SelectedItemChanged += new System.EventHandler(this.WayToMoveDomainUpDown_SelectedItemChanged);
            // 
            // WayToMoveSettingsLabel
            // 
            this.WayToMoveSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveSettingsLabel.Location = new System.Drawing.Point(450, 164);
            this.WayToMoveSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WayToMoveSettingsLabel.Name = "WayToMoveSettingsLabel";
            this.WayToMoveSettingsLabel.Size = new System.Drawing.Size(233, 58);
            this.WayToMoveSettingsLabel.TabIndex = 15;
            this.WayToMoveSettingsLabel.Text = "Способ перемещения фигур";
            this.WayToMoveSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(455, 313);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(209, 80);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Показывать допустимые ходы";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(455, 442);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(209, 66);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Подсветка хода";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 684);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.WayToMoveDomainUpDown);
            this.Controls.Add(this.WayToMoveSettingsLabel);
            this.Controls.Add(this.EmptyBox3);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private RichTextBox  EmptyBox3;
        private DomainUpDown WayToMoveDomainUpDown;
        private Label        WayToMoveSettingsLabel;
        private CheckBox     checkBox1;
        private CheckBox checkBox2;
    }
}