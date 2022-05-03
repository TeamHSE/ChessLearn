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
            this.button1                      = new System.Windows.Forms.Button();
            this.printDialog1                 = new System.Windows.Forms.PrintDialog();
            this.button2                      = new System.Windows.Forms.Button();
            this.button3                      = new System.Windows.Forms.Button();
            this.button15                     = new System.Windows.Forms.Button();
            this.miniToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 32);
            this.tableLayoutPanel1.Margin   = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name     = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.55411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.33766F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size     = new System.Drawing.Size(460, 462);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                       | System.Windows.Forms.AnchorStyles.Left)
                                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize                   = true;
            this.button1.BackColor                  = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage            = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout      = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize  = 0;
            this.button1.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor                  = System.Drawing.Color.DarkRed;
            this.button1.Location                   = new System.Drawing.Point(173, 347);
            this.button1.Margin                     = new System.Windows.Forms.Padding(2);
            this.button1.Name                       = "button1";
            this.button1.Size                       = new System.Drawing.Size(53, 54);
            this.button1.TabIndex                   = 7;
            this.button1.UseVisualStyleBackColor    = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location                = new System.Drawing.Point(571, 76);
            this.button2.Margin                  = new System.Windows.Forms.Padding(2);
            this.button2.Name                    = "button2";
            this.button2.Size                    = new System.Drawing.Size(54, 48);
            this.button2.TabIndex                = 4;
            this.button2.Text                    = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location                = new System.Drawing.Point(571, 149);
            this.button3.Margin                  = new System.Windows.Forms.Padding(2);
            this.button3.Name                    = "button3";
            this.button3.Size                    = new System.Drawing.Size(53, 46);
            this.button3.TabIndex                = 5;
            this.button3.Text                    = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location                =  new System.Drawing.Point(556, 251);
            this.button15.Margin                  =  new System.Windows.Forms.Padding(2);
            this.button15.Name                    =  "button15";
            this.button15.Size                    =  new System.Drawing.Size(91, 105);
            this.button15.TabIndex                =  6;
            this.button15.Text                    =  "button15";
            this.button15.UseVisualStyleBackColor =  true;
            this.button15.Click                   += new System.EventHandler(this.button15_Click);
            // 
            // ChessBoardForm
            // 
            this.AutoScaleDimensions   = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode         = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor             = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize            = new System.Drawing.Size(798, 636);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.miniToolStrip);
            this.DoubleBuffered = true;
            this.Location       = new System.Drawing.Point(15, 15);
            this.Margin         = new System.Windows.Forms.Padding(2);
            this.Name           = "ChessBoardForm";
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        #endregion
        private MenuStrip                              miniToolStrip;
        private ToolStripMenuItem главноеМенюToolStripMenuItem;
        private TableLayoutPanel  tableLayoutPanel1;
        private PrintDialog       printDialog1;
        private Button            button2;
        private Button            button3;
        private Button            button15;
    }
}
