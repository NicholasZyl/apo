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
        private int max = 0;

        public int Max {
             get
            {
                return max;
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

        public Histogram(Bitmap image)
        {
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    int level = (color.R + color.G + color.B) / 3;
                    histogram[level]++;
                    if (max < histogram[level])
                    {
                        max = histogram[level];
                    }
                }
            }
        }
    }
}
