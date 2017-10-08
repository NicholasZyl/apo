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
        private Bitmap bmp;
        private Graphics histogramGraphic;
        private Bitmap histogramImage;

        public ImageForm(string file)
        {
            InitializeComponent();

            path = file;
            Text = Path.GetFileName(path);

            openImage(file);
        }

        private void openImage(string file)
        {
            bmp = (Bitmap) Image.FromFile(file);
            pictureBox.Image = bmp;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Histogram histogram = new Histogram(bmp);
            drawHistogram(histogram);
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
                    float percentage = levels[x] / histogram.Max;
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
    }
}
