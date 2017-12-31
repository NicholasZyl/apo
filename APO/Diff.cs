using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class Diff : Operation
    {
        private FastBitmap baseImage;

        public Diff(FastBitmap baseImage)
        {
            this.baseImage = baseImage;
        }

        public FastBitmap perform(FastBitmap image)
        {
            FastBitmap finalImage = baseImage.Clone();
            Histogram baseHistogram = new Histogram(baseImage);
            for (int y = 0; y < baseImage.Height; ++y)
            {
                for (int x = 0; x < baseImage.Width; ++x)
                {
                    if (x >= image.Width || y >= image.Height)
                    {
                        continue;
                    }
                    int baseColor = baseImage.GetPixel(x, y);
                    int addColor = image.GetPixel(x, y);
                    finalImage.SetPixel(
                        x,
                        y,
                        Math.Min(Math.Abs(baseColor - addColor), baseHistogram.LevelsCount - 1)
                    );
                }
            }

            return finalImage;
        }
    }
}
