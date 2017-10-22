using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    class Binarization : ParametrisedOperation
    {
        private int levels;

        public Binarization(int levels)
        {
            this.levels = levels;
        }

        public void adaptSlider(TrackBar slider)
        {
            slider.Minimum = 0;
            slider.Maximum = levels - 1;
            slider.Value = levels / 2 - 1;
        }

        public Bitmap perform(Bitmap image, int parameter)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            for (int y = 0; y < finalImage.Height; ++y)
            {
                for (int x = 0; x < finalImage.Width; ++x)
                {
                    Color color = finalImage.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    Color newColor;

                    if (level <= parameter)
                    {
                        newColor = Color.Black;
                    } else
                    {
                        newColor = Color.White;
                    }

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
