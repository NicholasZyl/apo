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

        public String name()
        {
            return "Binarization";
        }

        public void adaptSlider(TrackBar slider)
        {
            slider.Minimum = 0;
            slider.Maximum = levels - 1;
            slider.Value = levels / 2 - 1;
        }

        public GrayscaleImage perform(GrayscaleImage image, int parameter)
        {
            GrayscaleImage finalImage = image.Clone();
            for (int y = 0; y < finalImage.Height; ++y)
            {
                for (int x = 0; x < finalImage.Width; ++x)
                {
                    int level = finalImage.GetPixel(x, y);
                    int newColor;

                    if (level <= parameter)
                    {
                        newColor = 0;
                    } else
                    {
                        newColor = 255;
                    }

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
