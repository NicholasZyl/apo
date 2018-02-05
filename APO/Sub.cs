using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class Sub: Operation
    {
        private GrayscaleImage baseImage;

        public Sub(GrayscaleImage baseImage)
        {
            this.baseImage = baseImage;
        }

        public GrayscaleImage perform(GrayscaleImage image)
        {
            GrayscaleImage finalImage = baseImage.Clone();
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
                        Math.Max(baseColor - addColor, 0)
                    );
                }
            }

            return finalImage;
        }
    }
}
