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
            radioButton100P.Checked = true;
        }

        private void buttonImageClipboard_Click(object sender, EventArgs e)
        {
            clipboardImage = Clipboard.GetImage();
            if (clipboardImage != null)
            {
                setImage(clipboardImage);
            }
        }

        private void buttonDec10P_Click(object sender, EventArgs e)
        {
            actualSizePercentage -= 10;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }

        private void buttonDec5P_Click(object sender, EventArgs e)
        {
            actualSizePercentage -= 5;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }

        private void buttonRed1P_Click(object sender, EventArgs e)
        {
            actualSizePercentage--;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }

        private void buttonInc1P_Click(object sender, EventArgs e)
        {
            actualSizePercentage++;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }

        private void buttonInc5P_Click(object sender, EventArgs e)
        {
            actualSizePercentage += 5;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }

        private void buttonInc10P_Click(object sender, EventArgs e)
        {
            actualSizePercentage += 10;
            actualImage = ScaleByPercent(clipboardImage, actualSizePercentage);
            setImage(actualImage);
        }
        private void setImage(Image image)
        {
            actualImage = image;
            pictureBox.Size = new Size(actualImage.Width, actualImage.Height);
            pictureBox.Image = actualImage;
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

        private void radioButton100P_CheckedChanged(object sender, EventArgs e)
        {
            opacity = 1.0f;
            setOpacity();
        }

        private void radioButton75P_CheckedChanged(object sender, EventArgs e)
        {
            opacity = 0.75f;
            setOpacity();
        }

        private void radioButton50P_CheckedChanged(object sender, EventArgs e)
        {
            opacity = 0.5f;
            setOpacity();
        }

        private void radioButton25P_CheckedChanged(object sender, EventArgs e)
        {
            opacity = 0.25f;
            setOpacity();
        }

        private void setOpacity()
        {
            this.Opacity = opacity;
        }
    }
}
