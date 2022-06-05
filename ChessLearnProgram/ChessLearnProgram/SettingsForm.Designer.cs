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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsLabel          = new System.Windows.Forms.Label();
            this.EmptyBox3              = new System.Windows.Forms.RichTextBox();
            this.WayToMoveDomainUpDown  = new System.Windows.Forms.DomainUpDown();
            this.WayToMoveSettingsLabel = new System.Windows.Forms.Label();
            this.checkBox1              = new System.Windows.Forms.CheckBox();
            this.checkBox2              = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLabel.AutoSize  = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location  = new System.Drawing.Point(307, 25);
            this.SettingsLabel.Name      = "SettingsLabel";
            this.SettingsLabel.Size      = new System.Drawing.Size(217, 46);
            this.SettingsLabel.TabIndex  = 0;
            this.SettingsLabel.Text      = "Настройки";
            // 
            // EmptyBox3
            // 
            this.EmptyBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                         | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox3.BackColor   = System.Drawing.Color.BurlyWood;
            this.EmptyBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmptyBox3.Enabled     = false;
            this.EmptyBox3.Location    = new System.Drawing.Point(238, 114);
            this.EmptyBox3.Name        = "EmptyBox3";
            this.EmptyBox3.ReadOnly    = true;
            this.EmptyBox3.Size        = new System.Drawing.Size(354, 359);
            this.EmptyBox3.TabIndex    = 3;
            this.EmptyBox3.Text        = "";
            // 
            // WayToMoveDomainUpDown
            // 
            this.WayToMoveDomainUpDown.BackColor = System.Drawing.Color.BurlyWood;
            this.WayToMoveDomainUpDown.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveDomainUpDown.Items.Add("Перетаскивать");
            this.WayToMoveDomainUpDown.Items.Add("Кликами");
            this.WayToMoveDomainUpDown.Items.Add("Обоими способами");
            this.WayToMoveDomainUpDown.Location            =  new System.Drawing.Point(339, 188);
            this.WayToMoveDomainUpDown.Name                =  "WayToMoveDomainUpDown";
            this.WayToMoveDomainUpDown.ReadOnly            =  true;
            this.WayToMoveDomainUpDown.Size                =  new System.Drawing.Size(165, 26);
            this.WayToMoveDomainUpDown.TabIndex            =  16;
            this.WayToMoveDomainUpDown.Text                =  "Перетаскивать";
            this.WayToMoveDomainUpDown.SelectedItemChanged += new System.EventHandler(this.WayToMoveDomainUpDown_SelectedItemChanged);
            // 
            // WayToMoveSettingsLabel
            // 
            this.WayToMoveSettingsLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.WayToMoveSettingsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveSettingsLabel.Location  = new System.Drawing.Point(329, 137);
            this.WayToMoveSettingsLabel.Name      = "WayToMoveSettingsLabel";
            this.WayToMoveSettingsLabel.Size      = new System.Drawing.Size(175, 47);
            this.WayToMoveSettingsLabel.TabIndex  = 15;
            this.WayToMoveSettingsLabel.Text      = "Способ перемещения фигур";
            this.WayToMoveSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor               = System.Drawing.Color.BurlyWood;
            this.checkBox1.CheckAlign              = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font                    = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location                = new System.Drawing.Point(341, 247);
            this.checkBox1.Name                    = "checkBox1";
            this.checkBox1.Size                    = new System.Drawing.Size(157, 65);
            this.checkBox1.TabIndex                = 17;
            this.checkBox1.Text                    = "Показывать допустимые ходы";
            this.checkBox1.TextAlign               = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor               = System.Drawing.Color.BurlyWood;
            this.checkBox2.CheckAlign              = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font                    = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location                = new System.Drawing.Point(341, 340);
            this.checkBox2.Name                    = "checkBox2";
            this.checkBox2.Size                    = new System.Drawing.Size(157, 54);
            this.checkBox2.TabIndex                = 18;
            this.checkBox2.Text                    = "Подсветка хода";
            this.checkBox2.TextAlign               = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage     = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize          = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.WayToMoveDomainUpDown);
            this.Controls.Add(this.WayToMoveSettingsLabel);
            this.Controls.Add(this.EmptyBox3);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name            =  "SettingsForm";
            this.StartPosition   =  System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            =  "Form2";
            this.TopMost         =  true;
            this.Load            += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label        SettingsLabel;
        private System.Windows.Forms.RichTextBox  EmptyBox3;
        private System.Windows.Forms.DomainUpDown WayToMoveDomainUpDown;
        private System.Windows.Forms.Label        WayToMoveSettingsLabel;
        private System.Windows.Forms.CheckBox     checkBox1;
        private System.Windows.Forms.CheckBox     checkBox2;
    }
}