using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class ImageForm : Form
    {
        private GrayscaleImage initialImage;
        private GrayscaleImage image;
        private Graphics histogramGraphic;
        private Bitmap histogramImage;

        public GrayscaleImage currentImage
        {
            get
            {
                return image;
            }
        }

        public ImageForm(string file)
        {
            InitializeComponent();
            
            Text = Path.GetFileName(file);
            setImage(new GrayscaleImage(file));
            initialImage = image;
        }
        
        public ImageForm(GrayscaleImage image)
        {
            InitializeComponent();
            
            Text = "*";
            initialImage = image;
            setImage(image);
        }
        
        public void setImage(GrayscaleImage image)
        {
            this.image = image;
            pictureBox.Image = this.image.BaseBitmap;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            Histogram histogram = new Histogram(this.image);
            drawHistogram(histogram);
            histogramPanel.Refresh();
        }

        public void setPath(string path)
        {
            Text = Path.GetFileName(path);
        }

        public void resetImage( )
        {
            setImage(initialImage);
        }

        private void drawHistogram(Histogram histogram)
        {
            histogramPanel.Size = new Size(256, 266);

            histogramGraphic = histogramPanel.CreateGraphics();
            int[] levels = histogram.Levels;

            histogramImage = new Bitmap(256, 266);
            using (Graphics graph = Graphics.FromImage(histogramImage))
            {
                graph.Clear(Color.White);
                for (int x = 0; x < levels.Length; ++x)
                {
                    float percentage = (float)levels[x] / (float)histogram.MostPixels;
                    graph.DrawLine(
                        Pens.Black, 
                        new Point(x, histogramImage.Height), 
                        new Point(x, histogramImage.Height - (int)(percentage * 256f))
                    );
                }
            }
        }

        private void onHistogramPaint(object sender, PaintEventArgs e)
        {
            histogramGraphic.DrawImage(histogramImage, new Point());
        }

        private void ImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main appForm = (Main)MdiParent;
            if (MdiParent != null)
            {
                appForm.onImageClosed();
            }
        }
    }
}
