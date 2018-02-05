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
        private string path;
        private FastBitmap bmp;
        private Graphics histogramGraphic;
        private Bitmap histogramImage;

        public FastBitmap currentImage
        {
            get
            {
                return bmp;
            }
        }

        public string currentPath
        {
            get
            {
                return path;
            }
        }

        public ImageForm(string file)
        {
            InitializeComponent();

            path = file;
            Text = Path.GetFileName(path);
            setImage(new FastBitmap(path));
        }
        
        public ImageForm(FastBitmap image)
        {
            InitializeComponent();
            
            Text = "*";
            setImage(image);
        }
        
        public void setImage(FastBitmap image)
        {
            bmp = image;
            pictureBox.Image = bmp.BaseBitmap;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            Histogram histogram = new Histogram(bmp);
            drawHistogram(histogram);
            histogramPanel.Refresh();
        }

        public void resetImage()
        {
            setImage(new FastBitmap(path));
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
