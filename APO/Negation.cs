using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class Negation : Operation
    {
        public GrayscaleImage perform(GrayscaleImage image)
        {
            GrayscaleImage finalImage = image.Clone();
            Histogram h = new Histogram(image);
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int level = image.GetPixel(x, y);
                    int newLevel = h.LevelsCount - 1 - level;

                    finalImage.SetPixel(x, y, newLevel);
                }
            }

            return finalImage;
        }
    }
}
