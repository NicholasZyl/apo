using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class SteganographyHideDialog : Form
    {
        private OpenFileDialog ofd;
        private GrayscaleImage baseImage;
        private Bitmap imageToHide;
        private int minBits = 0;

        private Bitmap loadedImage;
        private Bitmap displayImage;
        private Graphics displayGraphics;

        private bool isDrawing = false;
        private Point startingPoint, endPoint;

        public int BitsNumber
        {
            get
            {
                return (int) bitsNumberInput.Value;
            }
        }

        public Bitmap ImageToHide
        {
            get
            {
                return imageToHide;
            }
        }

        public SteganographyHideDialog(GrayscaleImage image, OpenFileDialog openFileDialog)
        {
            InitializeComponent();
            ofd = openFileDialog;
            baseImage = image;
            baseImageWidth.Text = image.Width.ToString();
            baseImageHeight.Text = image.Height.ToString();
        }

        private void onChooseFileClick(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadedImage = new Bitmap(Image.FromFile(ofd.FileName));
                imageToHide = (Bitmap)loadedImage.Clone();
                displayImage = (Bitmap)loadedImage.Clone();
                displayGraphics = Graphics.FromImage(displayImage);
                imageToHideBox.Image = displayImage;
                onImageChange();
            }
        }

        private void onCropImageMouseDown(object sender, MouseEventArgs e)
        {
            if (imageToHide == null)
            {
                return;
            }

            isDrawing = true;
            startingPoint = e.Location;
            endPoint = e.Location;
            drawCropRectangle();
        }

        private void onCropImageMouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == false)
            {
                return;
            }
            endPoint = e.Location;
            drawCropRectangle();
        }

        private void onCropImageMouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing == false)
            {
                return;
            }
            isDrawing = false;
            if (startingPoint.X != endPoint.X && startingPoint.Y != endPoint.Y)
            {
                cropImage();
            }
        }

        private void drawCropRectangle()
        {
            if (endPoint.X < 0)
            {
                endPoint.X = 0;
            } else if (endPoint.X > loadedImage.Width)
            {
                endPoint.X = loadedImage.Width - 1;
            }
            if (endPoint.Y < 0)
            {
                endPoint.Y = 0;
            }
            else if (endPoint.Y > loadedImage.Height)
            {
                endPoint.Y = loadedImage.Height - 1;
            }

            int x = Math.Min(startingPoint.X, endPoint.X);
            int y = Math.Min(startingPoint.Y, endPoint.Y);
            int width = Math.Abs(startingPoint.X - endPoint.X);
            int height = Math.Abs(startingPoint.Y - endPoint.Y);
            displayGraphics.DrawImageUnscaled(loadedImage, 0, 0);
            displayGraphics.DrawRectangle(Pens.Red, x, y, width, height);
            imageToHideBox.Refresh();
        }

        private void cropImage()
        {
            int x = Math.Min(startingPoint.X, endPoint.X);
            int y = Math.Min(startingPoint.Y, endPoint.Y);
            int width = Math.Abs(startingPoint.X - endPoint.X);
            int height = Math.Abs(startingPoint.Y - endPoint.Y);
            Rectangle source = new Rectangle(x, y, width, height);
            Rectangle destination = new Rectangle(0, 0, width, height);

            imageToHide = new Bitmap(width, height);
            Graphics copyGraphics = Graphics.FromImage(imageToHide);
            copyGraphics.DrawImage(loadedImage, destination, source, GraphicsUnit.Pixel);
            onImageChange();
        }

        private void onImageChange()
        {
            try
            {
                validateImages();
                hideButton.Enabled = true;
            }
            catch (ArgumentException exception)
            {
                hideButton.Enabled = false;
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                widthInfo.Text = imageToHide.Width.ToString();
                heightInfo.Text = imageToHide.Height.ToString();
            }
        }

        private void validateImages()
        {
            int imagePixels = baseImage.Width * baseImage.Height;
            int imageToHidePixels = imageToHide.Width * imageToHide.Height;
            if (imageToHidePixels > imagePixels)
            {
                throw new ArgumentException("Image to hide is too big! Missing at least " + (imageToHidePixels - imagePixels).ToString() + " pixels.");
            }
            minBits = (int)Math.Ceiling(((imageToHidePixels * 8.0) / imagePixels));
            if (bitsNumberInput.Value < minBits)
            {
                throw new ArgumentException("Not possible to hide picture using just " + bitsNumberInput.Value + " bits. Need to use at least " + minBits + " to hide chosen image in the current image.");
            }
        }

        private void onBitsValueChanged(object sender, EventArgs e)
        {
            if (minBits != 0 && minBits <= bitsNumberInput.Value)
            {
                hideButton.Enabled = true;
            } else
            {
                hideButton.Enabled = false;
                MessageBox.Show("Not possible to hide picture using just " + bitsNumberInput.Value + " bits.Need to use at least " + minBits + " to hide chosen image in the current image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
