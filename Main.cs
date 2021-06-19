using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CThru
{
    public partial class Main : Form
    {
        private Image clipboardImage;
        private Image actualImage;
        private int actualSizePercentage = 100;
        private float opacity = 1.0f;
        private bool nowClickableThrough = false;
        private bool imageUploaded = false;

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;

        public Main()
        {
            HotkeyManager.Current.AddOrReplace("ClickThrough", Keys.Alt | Keys.G, ClickThrough);
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            this.TopMost = true;
            this.Icon = CThru.Properties.Resources.icon;
            this.Text = "CThru - Enable/Disable clickable through (Alt+G)";
        }

        private void buttonImageClipboard_Click(object sender, EventArgs e)
        {
            clipboardImage = Clipboard.GetImage();
            if (clipboardImage != null)
            {
                setImage(clipboardImage);
            }
        }

        private void buttonDec5P_Click(object sender, EventArgs e)
        {
            setZoom(actualSizePercentage - 5);
        }

        private void buttonDec1P_Click(object sender, EventArgs e)
        {
            setZoom(actualSizePercentage - 1);
        }

        private void buttonInc1P_Click(object sender, EventArgs e)
        {
            setZoom(actualSizePercentage + 1);
        }

        private void buttonInc5P_Click(object sender, EventArgs e)
        {
            setZoom(actualSizePercentage + 5);
        }
        private void setImage(Image image)
        {
            actualImage = image;
            pictureBox.Size = new Size(actualImage.Width, actualImage.Height);
            pictureBox.Image = actualImage;
            imageUploaded = true;
            buttonsState();
        }
        private void setZoom(int change)
        {
            actualSizePercentage = change;
            trackBar1.Value = actualSizePercentage;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }
        private void buttonsState()
        {
            buttonDec5P.Enabled = imageUploaded;
            buttonDec1P.Enabled = imageUploaded;
            buttonInc1P.Enabled = imageUploaded;
            buttonInc5P.Enabled = imageUploaded;
        }
        public static Image ScaleByPercent(Image imgPhoto, int Percent)
        {
            float nPercent = ((float)Percent / 100);

            int sourceWidth = (int)imgPhoto.Width;
            int sourceHeight = (int)imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;

            int destX = 0;
            int destY = 0;
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void ClickThrough(object sender, HotkeyEventArgs e)
        {
            Debug.WriteLine("HOTKEY!!!");
            if (nowClickableThrough)
            {
                setNotClickableThrough();
            } 
            else
            {
                setClickableThrough();
            }
            nowClickableThrough = !nowClickableThrough;
        }

        private void setClickableThrough()
        {
            Debug.WriteLine("Now Clickable!!!");
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }
        private void setNotClickableThrough()
        {
            Debug.WriteLine("Now NOT Clickable!!!");
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style & ~WS_EX_TRANSPARENT);
        }

        private void setOpacity()
        {
            this.Opacity = opacity;
        }

        private void fromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboardImage = Clipboard.GetImage();
            if (clipboardImage != null)
            {
                setImage(clipboardImage);
            }
        }

        private void tool100PStripMenuItem_Click(object sender, EventArgs e)
        {
            opacity = 1.0f;
            setOpacity();
        }

        private void tool75PStripMenuItem_Click(object sender, EventArgs e)
        {
            opacity = 0.75f;
            setOpacity();
        }

        private void tool50PStripMenuItem_Click(object sender, EventArgs e)
        {
            opacity = 0.5f;
            setOpacity();
        }

        private void tool25PStripMenuItem_Click(object sender, EventArgs e)
        {
            opacity = 0.25f;
            setOpacity();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            setZoom(trackBar1.Value);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
