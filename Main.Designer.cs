
namespace CThru
{
    partial class Main
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonDec1P = new System.Windows.Forms.Button();
            this.buttonInc1P = new System.Windows.Forms.Button();
            this.buttonDec5P = new System.Windows.Forms.Button();
            this.buttonInc5P = new System.Windows.Forms.Button();
            this.labelZoom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool100PStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool75PStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool50PStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool25PStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(10, 10);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonDec1P
            // 
            this.buttonDec1P.Enabled = false;
            this.buttonDec1P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec1P.Location = new System.Drawing.Point(200, 1);
            this.buttonDec1P.Name = "buttonDec1P";
            this.buttonDec1P.Size = new System.Drawing.Size(41, 23);
            this.buttonDec1P.TabIndex = 2;
            this.buttonDec1P.Text = "-1%";
            this.buttonDec1P.UseVisualStyleBackColor = true;
            this.buttonDec1P.Click += new System.EventHandler(this.buttonDec1P_Click);
            // 
            // buttonInc1P
            // 
            this.buttonInc1P.Enabled = false;
            this.buttonInc1P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInc1P.Location = new System.Drawing.Point(532, 1);
            this.buttonInc1P.Name = "buttonInc1P";
            this.buttonInc1P.Size = new System.Drawing.Size(41, 23);
            this.buttonInc1P.TabIndex = 3;
            this.buttonInc1P.Text = "+1%";
            this.buttonInc1P.UseVisualStyleBackColor = true;
            this.buttonInc1P.Click += new System.EventHandler(this.buttonInc1P_Click);
            // 
            // buttonDec5P
            // 
            this.buttonDec5P.Enabled = false;
            this.buttonDec5P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec5P.Location = new System.Drawing.Point(158, 1);
            this.buttonDec5P.Name = "buttonDec5P";
            this.buttonDec5P.Size = new System.Drawing.Size(41, 23);
            this.buttonDec5P.TabIndex = 5;
            this.buttonDec5P.Text = "-5%";
            this.buttonDec5P.UseVisualStyleBackColor = true;
            this.buttonDec5P.Click += new System.EventHandler(this.buttonDec5P_Click);
            // 
            // buttonInc5P
            // 
            this.buttonInc5P.Enabled = false;
            this.buttonInc5P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInc5P.Location = new System.Drawing.Point(574, 1);
            this.buttonInc5P.Name = "buttonInc5P";
            this.buttonInc5P.Size = new System.Drawing.Size(41, 23);
            this.buttonInc5P.TabIndex = 6;
            this.buttonInc5P.Text = "+5%";
            this.buttonInc5P.UseVisualStyleBackColor = true;
            this.buttonInc5P.Click += new System.EventHandler(this.buttonInc5P_Click);
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(120, 6);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(37, 13);
            this.labelZoom.TabIndex = 8;
            this.labelZoom.Text = "Zoom:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.opacityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromClipboardToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fromFileToolStripMenuItem.Text = "From File";
            // 
            // fromClipboardToolStripMenuItem
            // 
            this.fromClipboardToolStripMenuItem.Name = "fromClipboardToolStripMenuItem";
            this.fromClipboardToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fromClipboardToolStripMenuItem.Text = "From Clipboard";
            this.fromClipboardToolStripMenuItem.Click += new System.EventHandler(this.fromClipboardToolStripMenuItem_Click);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool100PStripMenuItem,
            this.tool75PStripMenuItem,
            this.tool50PStripMenuItem,
            this.tool25PStripMenuItem});
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.opacityToolStripMenuItem.Text = "Opacity";
            // 
            // tool100PStripMenuItem
            // 
            this.tool100PStripMenuItem.Name = "tool100PStripMenuItem";
            this.tool100PStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tool100PStripMenuItem.Text = "100%";
            this.tool100PStripMenuItem.Click += new System.EventHandler(this.tool100PStripMenuItem_Click);
            // 
            // tool75PStripMenuItem
            // 
            this.tool75PStripMenuItem.Name = "tool75PStripMenuItem";
            this.tool75PStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tool75PStripMenuItem.Text = "75%";
            this.tool75PStripMenuItem.Click += new System.EventHandler(this.tool75PStripMenuItem_Click);
            // 
            // tool50PStripMenuItem
            // 
            this.tool50PStripMenuItem.Name = "tool50PStripMenuItem";
            this.tool50PStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tool50PStripMenuItem.Text = "50%";
            this.tool50PStripMenuItem.Click += new System.EventHandler(this.tool50PStripMenuItem_Click);
            // 
            // tool25PStripMenuItem
            // 
            this.tool25PStripMenuItem.Name = "tool25PStripMenuItem";
            this.tool25PStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tool25PStripMenuItem.Text = "25%";
            this.tool25PStripMenuItem.Click += new System.EventHandler(this.tool25PStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(241, -2);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(291, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 160);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.buttonInc5P);
            this.Controls.Add(this.buttonDec5P);
            this.Controls.Add(this.buttonInc1P);
            this.Controls.Add(this.buttonDec1P);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "CThru";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonCloseTransparentWindow;
        private System.Windows.Forms.Button buttonDec1P;
        private System.Windows.Forms.Button buttonInc1P;
        private System.Windows.Forms.Button buttonDec5P;
        private System.Windows.Forms.Button buttonInc5P;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool100PStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool75PStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool50PStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool25PStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

