
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
            this.buttonImageClipboard = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonRed1P = new System.Windows.Forms.Button();
            this.buttonInc1P = new System.Windows.Forms.Button();
            this.buttonDec10P = new System.Windows.Forms.Button();
            this.buttonDec5P = new System.Windows.Forms.Button();
            this.buttonInc5P = new System.Windows.Forms.Button();
            this.buttonInc10P = new System.Windows.Forms.Button();
            this.labelZoom = new System.Windows.Forms.Label();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.radioButton100P = new System.Windows.Forms.RadioButton();
            this.radioButton75P = new System.Windows.Forms.RadioButton();
            this.radioButton50P = new System.Windows.Forms.RadioButton();
            this.radioButton25P = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImageClipboard
            // 
            this.buttonImageClipboard.Location = new System.Drawing.Point(2, 3);
            this.buttonImageClipboard.Name = "buttonImageClipboard";
            this.buttonImageClipboard.Size = new System.Drawing.Size(183, 23);
            this.buttonImageClipboard.TabIndex = 0;
            this.buttonImageClipboard.Text = "Get image from clipboard";
            this.buttonImageClipboard.UseVisualStyleBackColor = true;
            this.buttonImageClipboard.Click += new System.EventHandler(this.buttonImageClipboard_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(10, 10);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonRed1P
            // 
            this.buttonRed1P.Location = new System.Drawing.Point(548, 4);
            this.buttonRed1P.Name = "buttonRed1P";
            this.buttonRed1P.Size = new System.Drawing.Size(41, 23);
            this.buttonRed1P.TabIndex = 2;
            this.buttonRed1P.Text = "-1%";
            this.buttonRed1P.UseVisualStyleBackColor = true;
            this.buttonRed1P.Click += new System.EventHandler(this.buttonRed1P_Click);
            // 
            // buttonInc1P
            // 
            this.buttonInc1P.Location = new System.Drawing.Point(592, 4);
            this.buttonInc1P.Name = "buttonInc1P";
            this.buttonInc1P.Size = new System.Drawing.Size(41, 23);
            this.buttonInc1P.TabIndex = 3;
            this.buttonInc1P.Text = "+1%";
            this.buttonInc1P.UseVisualStyleBackColor = true;
            this.buttonInc1P.Click += new System.EventHandler(this.buttonInc1P_Click);
            // 
            // buttonDec10P
            // 
            this.buttonDec10P.Location = new System.Drawing.Point(460, 4);
            this.buttonDec10P.Name = "buttonDec10P";
            this.buttonDec10P.Size = new System.Drawing.Size(41, 23);
            this.buttonDec10P.TabIndex = 4;
            this.buttonDec10P.Text = "-10%";
            this.buttonDec10P.UseVisualStyleBackColor = true;
            this.buttonDec10P.Click += new System.EventHandler(this.buttonDec10P_Click);
            // 
            // buttonDec5P
            // 
            this.buttonDec5P.Location = new System.Drawing.Point(504, 4);
            this.buttonDec5P.Name = "buttonDec5P";
            this.buttonDec5P.Size = new System.Drawing.Size(41, 23);
            this.buttonDec5P.TabIndex = 5;
            this.buttonDec5P.Text = "-5%";
            this.buttonDec5P.UseVisualStyleBackColor = true;
            this.buttonDec5P.Click += new System.EventHandler(this.buttonDec5P_Click);
            // 
            // buttonInc5P
            // 
            this.buttonInc5P.Location = new System.Drawing.Point(636, 4);
            this.buttonInc5P.Name = "buttonInc5P";
            this.buttonInc5P.Size = new System.Drawing.Size(41, 23);
            this.buttonInc5P.TabIndex = 6;
            this.buttonInc5P.Text = "+5%";
            this.buttonInc5P.UseVisualStyleBackColor = true;
            this.buttonInc5P.Click += new System.EventHandler(this.buttonInc5P_Click);
            // 
            // buttonInc10P
            // 
            this.buttonInc10P.Location = new System.Drawing.Point(680, 4);
            this.buttonInc10P.Name = "buttonInc10P";
            this.buttonInc10P.Size = new System.Drawing.Size(41, 23);
            this.buttonInc10P.TabIndex = 7;
            this.buttonInc10P.Text = "+10%";
            this.buttonInc10P.UseVisualStyleBackColor = true;
            this.buttonInc10P.Click += new System.EventHandler(this.buttonInc10P_Click);
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(422, 9);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(37, 13);
            this.labelZoom.TabIndex = 8;
            this.labelZoom.Text = "Zoom:";
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(191, 8);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(46, 13);
            this.labelOpacity.TabIndex = 9;
            this.labelOpacity.Text = "Opacity:";
            // 
            // radioButton100P
            // 
            this.radioButton100P.AutoSize = true;
            this.radioButton100P.Location = new System.Drawing.Point(243, 7);
            this.radioButton100P.Name = "radioButton100P";
            this.radioButton100P.Size = new System.Drawing.Size(51, 17);
            this.radioButton100P.TabIndex = 10;
            this.radioButton100P.TabStop = true;
            this.radioButton100P.Text = "100%";
            this.radioButton100P.UseVisualStyleBackColor = true;
            this.radioButton100P.CheckedChanged += new System.EventHandler(this.radioButton100P_CheckedChanged);
            // 
            // radioButton75P
            // 
            this.radioButton75P.AutoSize = true;
            this.radioButton75P.Location = new System.Drawing.Point(291, 7);
            this.radioButton75P.Name = "radioButton75P";
            this.radioButton75P.Size = new System.Drawing.Size(45, 17);
            this.radioButton75P.TabIndex = 11;
            this.radioButton75P.TabStop = true;
            this.radioButton75P.Text = "75%";
            this.radioButton75P.UseVisualStyleBackColor = true;
            this.radioButton75P.CheckedChanged += new System.EventHandler(this.radioButton75P_CheckedChanged);
            // 
            // radioButton50P
            // 
            this.radioButton50P.AutoSize = true;
            this.radioButton50P.Location = new System.Drawing.Point(331, 7);
            this.radioButton50P.Name = "radioButton50P";
            this.radioButton50P.Size = new System.Drawing.Size(45, 17);
            this.radioButton50P.TabIndex = 12;
            this.radioButton50P.TabStop = true;
            this.radioButton50P.Text = "50%";
            this.radioButton50P.UseVisualStyleBackColor = true;
            this.radioButton50P.CheckedChanged += new System.EventHandler(this.radioButton50P_CheckedChanged);
            // 
            // radioButton25P
            // 
            this.radioButton25P.AutoSize = true;
            this.radioButton25P.Location = new System.Drawing.Point(371, 7);
            this.radioButton25P.Name = "radioButton25P";
            this.radioButton25P.Size = new System.Drawing.Size(45, 17);
            this.radioButton25P.TabIndex = 13;
            this.radioButton25P.TabStop = true;
            this.radioButton25P.Text = "25%";
            this.radioButton25P.UseVisualStyleBackColor = true;
            this.radioButton25P.CheckedChanged += new System.EventHandler(this.radioButton25P_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 174);
            this.Controls.Add(this.radioButton25P);
            this.Controls.Add(this.radioButton50P);
            this.Controls.Add(this.radioButton75P);
            this.Controls.Add(this.radioButton100P);
            this.Controls.Add(this.labelOpacity);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.buttonInc10P);
            this.Controls.Add(this.buttonInc5P);
            this.Controls.Add(this.buttonDec5P);
            this.Controls.Add(this.buttonDec10P);
            this.Controls.Add(this.buttonInc1P);
            this.Controls.Add(this.buttonRed1P);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonImageClipboard);
            this.Name = "Main";
            this.Text = "CThru";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImageClipboard;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonCloseTransparentWindow;
        private System.Windows.Forms.Button buttonRed1P;
        private System.Windows.Forms.Button buttonInc1P;
        private System.Windows.Forms.Button buttonDec10P;
        private System.Windows.Forms.Button buttonDec5P;
        private System.Windows.Forms.Button buttonInc5P;
        private System.Windows.Forms.Button buttonInc10P;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.RadioButton radioButton100P;
        private System.Windows.Forms.RadioButton radioButton75P;
        private System.Windows.Forms.RadioButton radioButton50P;
        private System.Windows.Forms.RadioButton radioButton25P;
    }
}

