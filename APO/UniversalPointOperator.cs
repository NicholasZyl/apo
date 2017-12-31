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

        public FastBitmap perform(FastBitmap image)
        {
            FastBitmap finalImage = image.Clone();
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int level = image.GetPixel(x, y);
                    int newLevel = lut[level];

                    finalImage.SetPixel(x, y, newLevel);
                }
            }

            return finalImage;
        }
    }
}
