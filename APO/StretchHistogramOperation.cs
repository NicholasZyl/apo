using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class StretchHistogramOperation : Operation
    {
        public Bitmap perform(Bitmap image)
        {
            Histogram h = new Histogram(image);
            int vMin = h.LevelsCount;
            int vMax = 0;
            int[] levels = h.Levels;
            for (int i = 0; i < h.LevelsCount; ++i)
            {
                if (0 < levels[i])
                {
                    vMin = Math.Min(vMin, i);
                    vMax = Math.Max(vMax, i);
                }
            }
            int[] changes = new int[h.LevelsCount];
            for (int i = 0; i < h.LevelsCount; ++i)
            {
                int newLevel = (int)(h.LevelsCount / (vMax - vMin) * (i - vMin));
                changes[i] = (newLevel < 0) ? 0 : newLevel;
            }

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    Color newColor = Color.FromArgb(changes[level], changes[level], changes[level]);

                    image.SetPixel(x, y, newColor);
                }
            }

            return image;
        }
    }
}
