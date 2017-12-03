using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class UniversalPointOperator : Operation
    {
        private int[] lut;

        public UniversalPointOperator(int[] lut)
        {
            this.lut = lut;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    int newLevel = lut[level];
                    Color newColor = Color.FromArgb(newLevel, newLevel, newLevel);

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
