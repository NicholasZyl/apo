using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    class Reduction : ParametrisedOperation
    {
        private int levels;

        public Reduction(int levels)
        {
            this.levels = levels;
        }

        public void adaptSlider(TrackBar slider)
        {
            slider.Minimum = 2;
            slider.Maximum = levels;
            slider.Value = levels;
        }

        public string name()
        {
            return "Grey levels reduction";
        }

        public Bitmap perform(Bitmap image, int parameter)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            float param1 = (float)(levels - 1) / (parameter - 1);
            float param2 = (float)levels / parameter;

            int[] lut = new int[levels];
            for (int i = 0; i < levels; ++i)
            {
                lut[i] = (int)((int)(i / param2) * param1);
            }

            for (int y = 0; y < finalImage.Height; ++y)
            {
                for (int x = 0; x < finalImage.Width; ++x)
                {
                    Color color = finalImage.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    Color newColor = Color.FromArgb(lut[level], lut[level], lut[level]);

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
