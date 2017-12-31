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

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            for (int y = 0; y < finalImage.Height; ++y)
            {
                for (int x = 0; x < finalImage.Width; ++x)
                {
                    Color color = finalImage.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    Color newColor;

                    if (level <= lowerBound)
                    {
                        newColor = Color.Black;
                    }
                    else if (level >= upperBound)
                    {
                        newColor = Color.Black;
                    }
                    else
                    {
                        newColor = color;
                    }

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
