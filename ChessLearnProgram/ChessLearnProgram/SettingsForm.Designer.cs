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
            this.SettingsLabel          = new System.Windows.Forms.Label();
            this.EmptyBox1              = new System.Windows.Forms.RichTextBox();
            this.EmptyBox2              = new System.Windows.Forms.RichTextBox();
            this.EmptyBox3              = new System.Windows.Forms.RichTextBox();
            this.GraphicsSettingsLabel  = new System.Windows.Forms.Label();
            this.FullScreenСheckBox     = new System.Windows.Forms.CheckBox();
            this.AudioSettingsLabel     = new System.Windows.Forms.Label();
            this.DeskSettingsLabel      = new System.Windows.Forms.Label();
            this.MoveVolumeTrackBar     = new System.Windows.Forms.TrackBar();
            this.MoveVolumeSliderLabel  = new System.Windows.Forms.Label();
            this.VoiceVolumeSliderLabel = new System.Windows.Forms.Label();
            this.VoiceVolumeTrackBar    = new System.Windows.Forms.TrackBar();
            this.MoveSpeedSettingsLabel = new System.Windows.Forms.Label();
            this.MoveSpeedDomainUpDown  = new System.Windows.Forms.DomainUpDown();
            this.WayToMoveDomainUpDown  = new System.Windows.Forms.DomainUpDown();
            this.WayToMoveSettingsLabel = new System.Windows.Forms.Label();
            this.checkBox1              = new System.Windows.Forms.CheckBox();
            this.checkBox2              = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoveVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceVolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font     = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(287, 19);
            this.SettingsLabel.Name     = "SettingsLabel";
            this.SettingsLabel.Size     = new System.Drawing.Size(217, 46);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text     = "Настройки";
            // 
            // EmptyBox1
            // 
            this.EmptyBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                         | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmptyBox1.Enabled     = false;
            this.EmptyBox1.Location    = new System.Drawing.Point(31, 83);
            this.EmptyBox1.Name        = "EmptyBox1";
            this.EmptyBox1.ReadOnly    = true;
            this.EmptyBox1.Size        = new System.Drawing.Size(215, 443);
            this.EmptyBox1.TabIndex    = 1;
            this.EmptyBox1.Text        = "";
            // 
            // EmptyBox2
            // 
            this.EmptyBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                         | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmptyBox2.Enabled     = false;
            this.EmptyBox2.Location    = new System.Drawing.Point(295, 83);
            this.EmptyBox2.Name        = "EmptyBox2";
            this.EmptyBox2.ReadOnly    = true;
            this.EmptyBox2.Size        = new System.Drawing.Size(215, 443);
            this.EmptyBox2.TabIndex    = 2;
            this.EmptyBox2.Text        = "";
            // 
            // EmptyBox3
            // 
            this.EmptyBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                         | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmptyBox3.Enabled     = false;
            this.EmptyBox3.Location    = new System.Drawing.Point(569, 83);
            this.EmptyBox3.Name        = "EmptyBox3";
            this.EmptyBox3.ReadOnly    = true;
            this.EmptyBox3.Size        = new System.Drawing.Size(215, 443);
            this.EmptyBox3.TabIndex    = 3;
            this.EmptyBox3.Text        = "";
            // 
            // GraphicsSettingsLabel
            // 
            this.GraphicsSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                                  | System.Windows.Forms.AnchorStyles.Left)
                                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsSettingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphicsSettingsLabel.Font        = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphicsSettingsLabel.Location    = new System.Drawing.Point(55, 98);
            this.GraphicsSettingsLabel.Name        = "GraphicsSettingsLabel";
            this.GraphicsSettingsLabel.Size        = new System.Drawing.Size(168, 59);
            this.GraphicsSettingsLabel.TabIndex    = 4;
            this.GraphicsSettingsLabel.Text        = "Настройки изображения";
            this.GraphicsSettingsLabel.TextAlign   = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FullScreenСheckBox
            // 
            this.FullScreenСheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                               | System.Windows.Forms.AnchorStyles.Left)
                                                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenСheckBox.CheckAlign              =  System.Drawing.ContentAlignment.MiddleRight;
            this.FullScreenСheckBox.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullScreenСheckBox.Location                =  new System.Drawing.Point(65, 245);
            this.FullScreenСheckBox.Name                    =  "FullScreenСheckBox";
            this.FullScreenСheckBox.Size                    =  new System.Drawing.Size(158, 148);
            this.FullScreenСheckBox.TabIndex                =  6;
            this.FullScreenСheckBox.Text                    =  "Полноэкранный режим";
            this.FullScreenСheckBox.TextAlign               =  System.Drawing.ContentAlignment.MiddleCenter;
            this.FullScreenСheckBox.UseVisualStyleBackColor =  true;
            this.FullScreenСheckBox.CheckedChanged          += new System.EventHandler(this.FullScreenСheckBox_CheckedChanged);
            // 
            // AudioSettingsLabel
            // 
            this.AudioSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                               | System.Windows.Forms.AnchorStyles.Left)
                                                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioSettingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AudioSettingsLabel.Font        = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AudioSettingsLabel.Location    = new System.Drawing.Point(325, 98);
            this.AudioSettingsLabel.Name        = "AudioSettingsLabel";
            this.AudioSettingsLabel.Size        = new System.Drawing.Size(168, 59);
            this.AudioSettingsLabel.TabIndex    = 7;
            this.AudioSettingsLabel.Text        = "Настройки звука";
            this.AudioSettingsLabel.TextAlign   = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskSettingsLabel
            // 
            this.DeskSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                              | System.Windows.Forms.AnchorStyles.Left)
                                                                  | System.Windows.Forms.AnchorStyles.Right)));
            this.DeskSettingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeskSettingsLabel.Font        = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeskSettingsLabel.Location    = new System.Drawing.Point(596, 98);
            this.DeskSettingsLabel.Name        = "DeskSettingsLabel";
            this.DeskSettingsLabel.Size        = new System.Drawing.Size(168, 59);
            this.DeskSettingsLabel.TabIndex    = 8;
            this.DeskSettingsLabel.Text        = "Доска и фигуры";
            this.DeskSettingsLabel.TextAlign   = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveVolumeTrackBar
            // 
            this.MoveVolumeTrackBar.Location = new System.Drawing.Point(325, 245);
            this.MoveVolumeTrackBar.Name     = "MoveVolumeTrackBar";
            this.MoveVolumeTrackBar.Size     = new System.Drawing.Size(147, 37);
            this.MoveVolumeTrackBar.TabIndex = 9;
            this.MoveVolumeTrackBar.Value    = 10;
            // 
            // MoveVolumeSliderLabel
            // 
            this.MoveVolumeSliderLabel.AutoSize = true;
            this.MoveVolumeSliderLabel.Font     = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveVolumeSliderLabel.Location = new System.Drawing.Point(314, 217);
            this.MoveVolumeSliderLabel.Name     = "MoveVolumeSliderLabel";
            this.MoveVolumeSliderLabel.Size     = new System.Drawing.Size(175, 20);
            this.MoveVolumeSliderLabel.TabIndex = 10;
            this.MoveVolumeSliderLabel.Text     = "Громкость звука хода";
            // 
            // VoiceVolumeSliderLabel
            // 
            this.VoiceVolumeSliderLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VoiceVolumeSliderLabel.Location  = new System.Drawing.Point(314, 355);
            this.VoiceVolumeSliderLabel.Name      = "VoiceVolumeSliderLabel";
            this.VoiceVolumeSliderLabel.Size      = new System.Drawing.Size(175, 49);
            this.VoiceVolumeSliderLabel.TabIndex  = 12;
            this.VoiceVolumeSliderLabel.Text      = "Громкость голоса в обучении";
            this.VoiceVolumeSliderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoiceVolumeTrackBar
            // 
            this.VoiceVolumeTrackBar.Location = new System.Drawing.Point(325, 411);
            this.VoiceVolumeTrackBar.Name     = "VoiceVolumeTrackBar";
            this.VoiceVolumeTrackBar.Size     = new System.Drawing.Size(147, 37);
            this.VoiceVolumeTrackBar.TabIndex = 11;
            this.VoiceVolumeTrackBar.Value    = 10;
            // 
            // MoveSpeedSettingsLabel
            // 
            this.MoveSpeedSettingsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveSpeedSettingsLabel.Location  = new System.Drawing.Point(588, 190);
            this.MoveSpeedSettingsLabel.Name      = "MoveSpeedSettingsLabel";
            this.MoveSpeedSettingsLabel.Size      = new System.Drawing.Size(175, 47);
            this.MoveSpeedSettingsLabel.TabIndex  = 13;
            this.MoveSpeedSettingsLabel.Text      = "Скорость перемещения фигур";
            this.MoveSpeedSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveSpeedDomainUpDown
            // 
            this.MoveSpeedDomainUpDown.Items.Add("Медленная");
            this.MoveSpeedDomainUpDown.Items.Add("Средняя");
            this.MoveSpeedDomainUpDown.Items.Add("Быстрая");
            this.MoveSpeedDomainUpDown.Location = new System.Drawing.Point(608, 240);
            this.MoveSpeedDomainUpDown.Name     = "MoveSpeedDomainUpDown";
            this.MoveSpeedDomainUpDown.ReadOnly = true;
            this.MoveSpeedDomainUpDown.Size     = new System.Drawing.Size(124, 20);
            this.MoveSpeedDomainUpDown.TabIndex = 14;
            this.MoveSpeedDomainUpDown.Text     = "Медленная";
            // 
            // WayToMoveDomainUpDown
            // 
            this.WayToMoveDomainUpDown.Items.Add("Перетаскивать");
            this.WayToMoveDomainUpDown.Items.Add("Кликами");
            this.WayToMoveDomainUpDown.Items.Add("Обоими способами");
            this.WayToMoveDomainUpDown.Location = new System.Drawing.Point(608, 331);
            this.WayToMoveDomainUpDown.Name     = "WayToMoveDomainUpDown";
            this.WayToMoveDomainUpDown.ReadOnly = true;
            this.WayToMoveDomainUpDown.Size     = new System.Drawing.Size(124, 20);
            this.WayToMoveDomainUpDown.TabIndex = 16;
            this.WayToMoveDomainUpDown.Text     = "Перетаскивать";
            // 
            // WayToMoveSettingsLabel
            // 
            this.WayToMoveSettingsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayToMoveSettingsLabel.Location  = new System.Drawing.Point(592, 281);
            this.WayToMoveSettingsLabel.Name      = "WayToMoveSettingsLabel";
            this.WayToMoveSettingsLabel.Size      = new System.Drawing.Size(175, 47);
            this.WayToMoveSettingsLabel.TabIndex  = 15;
            this.WayToMoveSettingsLabel.Text      = "Способ перемещения фигур";
            this.WayToMoveSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign              = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font                    = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location                = new System.Drawing.Point(596, 371);
            this.checkBox1.Name                    = "checkBox1";
            this.checkBox1.Size                    = new System.Drawing.Size(157, 65);
            this.checkBox1.TabIndex                = 17;
            this.checkBox1.Text                    = "Показывать допустимые ходы";
            this.checkBox1.TextAlign               = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.CheckAlign              = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font                    = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location                = new System.Drawing.Point(596, 455);
            this.checkBox2.Name                    = "checkBox2";
            this.checkBox2.Size                    = new System.Drawing.Size(157, 54);
            this.checkBox2.TabIndex                = 18;
            this.checkBox2.Text                    = "Подсветка хода";
            this.checkBox2.TextAlign               = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(821, 556);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.WayToMoveDomainUpDown);
            this.Controls.Add(this.WayToMoveSettingsLabel);
            this.Controls.Add(this.MoveSpeedDomainUpDown);
            this.Controls.Add(this.MoveSpeedSettingsLabel);
            this.Controls.Add(this.VoiceVolumeSliderLabel);
            this.Controls.Add(this.VoiceVolumeTrackBar);
            this.Controls.Add(this.MoveVolumeSliderLabel);
            this.Controls.Add(this.MoveVolumeTrackBar);
            this.Controls.Add(this.DeskSettingsLabel);
            this.Controls.Add(this.AudioSettingsLabel);
            this.Controls.Add(this.FullScreenСheckBox);
            this.Controls.Add(this.GraphicsSettingsLabel);
            this.Controls.Add(this.EmptyBox3);
            this.Controls.Add(this.EmptyBox2);
            this.Controls.Add(this.EmptyBox1);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer  =  true;
            this.Name            =  "SettingsForm";
            this.StartPosition   =  System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            =  "Form2";
            this.TopMost         =  true;
            this.Load            += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoveVolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceVolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label        SettingsLabel;
        private RichTextBox  EmptyBox1;
        private RichTextBox  EmptyBox2;
        private RichTextBox  EmptyBox3;
        private Label        GraphicsSettingsLabel;
        private CheckBox     FullScreenСheckBox;
        private Label        AudioSettingsLabel;
        private Label        DeskSettingsLabel;
        private TrackBar     MoveVolumeTrackBar;
        private Label        MoveVolumeSliderLabel;
        private Label        VoiceVolumeSliderLabel;
        private TrackBar     VoiceVolumeTrackBar;
        private Label        MoveSpeedSettingsLabel;
        private DomainUpDown MoveSpeedDomainUpDown;
        private DomainUpDown WayToMoveDomainUpDown;
        private Label        WayToMoveSettingsLabel;
        private CheckBox     checkBox1;
        private CheckBox     checkBox2;
    }
}