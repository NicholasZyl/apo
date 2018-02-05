using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class Histogram
    {
        private int levels = 256;
        private int[] histogram = new int[256];
        private int mostPixels = 0;
        private int max = 0;
        private int min = 255;

        public int MostPixels
        {
            get
            {
                return mostPixels;
            }
        }

        public int Max {
             get
            {
                return max;
            }
        }

        public int Min {
            get
            {
                return min;
            }
        }

        public int[] Levels
        {
            get
            {
                return histogram;
            }
        }

        public int LevelsCount
        {
            get
            {
                return levels;
            }
        }

        public Histogram(GrayscaleImage image)
        {
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int level = image.GetPixel(x, y);
                    histogram[level]++;
                    mostPixels = Math.Max(mostPixels, histogram[level]);
                    max = Math.Max(max, level);
                    min = Math.Min(min, level);
                }
            }
        }
    }
}
