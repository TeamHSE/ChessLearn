using System.ComponentModel;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class ChessBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessBoardForm));
            this.miniToolStrip                = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1            = new System.Windows.Forms.TableLayoutPanel();
            this.printDialog1                 = new System.Windows.Forms.PrintDialog();
            this.MessageTextBox               = new System.Windows.Forms.RichTextBox();
            this.SizeTrackBar                 = new System.Windows.Forms.TrackBar();
            this.BoardSizeSliderLabel         = new System.Windows.Forms.Label();
            this.PlayButton                   = new System.Windows.Forms.Button();
            this.PracticeButton               = new System.Windows.Forms.Button();
            this.miniToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize         = false;
            this.miniToolStrip.Dock             = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.главноеМенюToolStripMenuItem });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name     = "miniToolStrip";
            this.miniToolStrip.Padding  = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.miniToolStrip.Size     = new System.Drawing.Size(741, 24);
            this.miniToolStrip.TabIndex = 1;
            this.miniToolStrip.Visible  = false;
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop             = true;
            this.tableLayoutPanel1.BackgroundImage       = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount           = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location  = new System.Drawing.Point(63, 79);
            this.tableLayoutPanel1.Margin    = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name      = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount  = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.55411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.33766F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size     = new System.Drawing.Size(504, 496);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.BulletIndent = 3;
            this.MessageTextBox.Font         = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location     = new System.Drawing.Point(602, 32);
            this.MessageTextBox.Name         = "MessageTextBox";
            this.MessageTextBox.ReadOnly     = true;
            this.MessageTextBox.Size         = new System.Drawing.Size(347, 592);
            this.MessageTextBox.TabIndex     = 8;
            this.MessageTextBox.Text         = "";
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.Location =  new System.Drawing.Point(63, 37);
            this.SizeTrackBar.Maximum  =  1000;
            this.SizeTrackBar.Minimum  =  460;
            this.SizeTrackBar.Name     =  "SizeTrackBar";
            this.SizeTrackBar.Size     =  new System.Drawing.Size(154, 37);
            this.SizeTrackBar.TabIndex =  9;
            this.SizeTrackBar.Value    =  460;
            this.SizeTrackBar.Scroll   += new System.EventHandler(this.SizeTrackBar_Scroll);
            // 
            // BoardSizeSliderLabel
            // 
            this.BoardSizeSliderLabel.Font     = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoardSizeSliderLabel.Location = new System.Drawing.Point(63, 9);
            this.BoardSizeSliderLabel.Name     = "BoardSizeSliderLabel";
            this.BoardSizeSliderLabel.Size     = new System.Drawing.Size(127, 18);
            this.BoardSizeSliderLabel.TabIndex = 10;
            this.BoardSizeSliderLabel.Text     = "Размер доски";
            // 
            // PlayButton
            // 
            this.PlayButton.Font                    =  new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location                =  new System.Drawing.Point(223, 12);
            this.PlayButton.Name                    =  "PlayButton";
            this.PlayButton.Size                    =  new System.Drawing.Size(145, 56);
            this.PlayButton.TabIndex                =  11;
            this.PlayButton.Text                    =  "Включить демонстрацию";
            this.PlayButton.UseVisualStyleBackColor =  true;
            this.PlayButton.Click                   += new System.EventHandler(this.PlayButton_Click);
            // 
            // PracticeButton
            // 
            this.PracticeButton.Font                    =  new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PracticeButton.Location                =  new System.Drawing.Point(378, 12);
            this.PracticeButton.Name                    =  "PracticeButton";
            this.PracticeButton.Size                    =  new System.Drawing.Size(189, 56);
            this.PracticeButton.TabIndex                =  12;
            this.PracticeButton.Text                    =  "Перейти к практике";
            this.PracticeButton.UseVisualStyleBackColor =  true;
            this.PracticeButton.Click                   += new System.EventHandler(this.PracticeButton_Click);
            // 
            // ChessBoardForm
            // 
            this.AutoScaleDimensions   = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode         = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor             = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize            = new System.Drawing.Size(961, 636);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.BoardSizeSliderLabel);
            this.Controls.Add(this.SizeTrackBar);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.miniToolStrip);
            this.DoubleBuffered =  true;
            this.Location       =  new System.Drawing.Point(15, 15);
            this.Margin         =  new System.Windows.Forms.Padding(2);
            this.Name           =  "ChessBoardForm";
            this.FormClosed     += new System.Windows.Forms.FormClosedEventHandler(this.ChessBoardForm_FormClosed);
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button PracticeButton;

        private System.Windows.Forms.Button PlayButton;

        private System.Windows.Forms.Label BoardSizeSliderLabel;

        private System.Windows.Forms.TrackBar SizeTrackBar;

        private System.Windows.Forms.RichTextBox MessageTextBox;

        #endregion
        private MenuStrip                             miniToolStrip;
        private ToolStripMenuItem                     главноеМенюToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private PrintDialog                           printDialog1;
    }
}
