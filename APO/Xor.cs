using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class Xor : Operation
    {
        private GrayscaleImage baseImage;

        public Xor(GrayscaleImage baseImage)
        {
            this.baseImage = baseImage;
        }

        public GrayscaleImage perform(GrayscaleImage image)
        {
            GrayscaleImage finalImage = baseImage.Clone();
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
                        Math.Min(baseColor | addColor, baseHistogram.LevelsCount - 1)
                    );
                }
            }

            return finalImage;
        }
    }
}
