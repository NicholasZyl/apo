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
    public partial class UniversalPointOperatorDialog : Form
    {
        private Graphics graphGraphic;
        private Bitmap graphImage;
        private int[] lut;

        public int[] Lut
        {
            get
            {
                return lut;
            }
        }

        public UniversalPointOperatorDialog()
        {
            InitializeComponent();
            lut = new int[256];
            for (int i = 0; i < lut.Length; ++i)
            {
                lut[i] = i;
            }
            drawGraph();
            lutGraphPanel.Refresh();
        }

        private void drawGraph()
        {
            lutGraphPanel.Size = new Size(256, 266);

            graphGraphic = lutGraphPanel.CreateGraphics();

            graphImage = new Bitmap(256, 266);
            using (Graphics graph = Graphics.FromImage(graphImage))
            {
                graph.Clear(Color.White);
                for (int x = 0; x < lut.Length; ++x)
                {
                    float percentage = (float)lut[x] / (float)lut.Length;
                    graph.DrawLine(
                        Pens.Black,
                        new Point(x, graphImage.Height),
                        new Point(x, graphImage.Height - (int)(percentage * 256f))
                    );
                }
            }
        }

        private void onLutGraphPaint(object sender, PaintEventArgs e)
        {
            graphGraphic.DrawImage(graphImage, new Point());
        }

        private void onLutGraphMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.X > 0 && e.X < 256 && e.Y > 0 && e.Y < 256)
            {
                lut[e.X] = (255 - e.Y);
                drawGraph();
                lutGraphPanel.Refresh();
            }
        }
    }
}
