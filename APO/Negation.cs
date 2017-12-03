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
        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            Histogram h = new Histogram(image);
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    int newLevel = h.LevelsCount - 1 - level;
                    Color newColor = Color.FromArgb(newLevel, newLevel, newLevel);

                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }
    }
}
