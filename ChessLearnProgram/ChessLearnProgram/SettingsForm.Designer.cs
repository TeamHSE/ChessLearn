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
            // WayToMoveDomainUpDown
            // 
            this.WayToMoveDomainUpDown.BackColor = System.Drawing.Color.BurlyWood;
            this.WayToMoveDomainUpDown.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveDomainUpDown.Items.Add("Перетаскивать");
            this.WayToMoveDomainUpDown.Items.Add("Кликами");
            this.WayToMoveDomainUpDown.Items.Add("Обоими способами");
            this.WayToMoveDomainUpDown.Location            =  new System.Drawing.Point(343, 187);
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
            this.WayToMoveSettingsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WayToMoveSettingsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveSettingsLabel.Image     = ((System.Drawing.Image)(resources.GetObject("WayToMoveSettingsLabel.Image")));
            this.WayToMoveSettingsLabel.Location  = new System.Drawing.Point(329, 137);
            this.WayToMoveSettingsLabel.Name      = "WayToMoveSettingsLabel";
            this.WayToMoveSettingsLabel.Size      = new System.Drawing.Size(191, 47);
            this.WayToMoveSettingsLabel.TabIndex  = 15;
            this.WayToMoveSettingsLabel.Text      = "Способ перемещения фигур";
            this.WayToMoveSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor               = System.Drawing.Color.BurlyWood;
            this.checkBox1.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("checkBox1.BackgroundImage")));
            this.checkBox1.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox1.CheckAlign              = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font                    = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location                = new System.Drawing.Point(329, 249);
            this.checkBox1.Name                    = "checkBox1";
            this.checkBox1.Size                    = new System.Drawing.Size(191, 65);
            this.checkBox1.TabIndex                = 17;
            this.checkBox1.Text                    = "Показывать допустимые ходы";
            this.checkBox1.TextAlign               = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor               = System.Drawing.Color.BurlyWood;
            this.checkBox2.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("checkBox2.BackgroundImage")));
            this.checkBox2.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox2.CheckAlign              = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font                    = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location                = new System.Drawing.Point(329, 342);
            this.checkBox2.Name                    = "checkBox2";
            this.checkBox2.Size                    = new System.Drawing.Size(191, 54);
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
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon            =  ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name            =  "SettingsForm";
            this.StartPosition   =  System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            =  "Настройки";
            this.TopMost         =  true;
            this.Load            += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label        SettingsLabel;
        private System.Windows.Forms.DomainUpDown WayToMoveDomainUpDown;
        private System.Windows.Forms.Label        WayToMoveSettingsLabel;
        private System.Windows.Forms.CheckBox     checkBox1;
        private System.Windows.Forms.CheckBox     checkBox2;
    }
}