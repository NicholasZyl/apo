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
        public int BitsNumber
        {
            get
            {
                return (int) numericUpDown1.Value;
            }
        }

        public SteganographyHideDialog(Bitmap image, Bitmap imageToHide)
        {
            InitializeComponent();
            initWithImages(image, imageToHide);
        }

        private void initWithImages(Bitmap image, Bitmap imageToHide)
        {
            int imagePixels = image.Width * image.Height;
            int imageToHidePixels = imageToHide.Width * imageToHide.Height;
            if (imageToHidePixels > imagePixels)
            {
                throw new ArgumentException("Image to hide is too big!");
            }
            imageToHideBox.Image = imageToHide;
            imageToHideBox.SizeMode = PictureBoxSizeMode.CenterImage;
            widthInfo.Text = imageToHide.Width.ToString();
            heightInfo.Text = imageToHide.Height.ToString();
            int minBits = (int) Math.Ceiling(((imageToHidePixels * 8.0) / imagePixels));
            numericUpDown1.Minimum = minBits;
            numericUpDown1.Value = minBits;
        }
    }
}
