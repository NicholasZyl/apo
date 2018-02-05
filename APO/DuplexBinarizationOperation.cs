using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class DuplexBinarizationOperation : Operation
    {
        private int lowerBound;
        private int upperBound;

        public DuplexBinarizationOperation(int lowerBound, int upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
        }

        public GrayscaleImage perform(GrayscaleImage image)
        {
            GrayscaleImage finalImage = image.Clone();
            for (int y = 0; y < finalImage.Height; ++y)
            {
                for (int x = 0; x < finalImage.Width; ++x)
                {
                    int level = finalImage.GetPixel(x, y);
                    int newColor;

                    if (level <= lowerBound)
                    {
                        newColor = 0;
                    }
                    else if (level >= upperBound)
                    {
                        newColor = 255;
                    }
                    else
                    {
                        newColor = level;
                    }

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
