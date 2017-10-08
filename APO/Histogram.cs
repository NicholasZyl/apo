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

        public Histogram(Bitmap image)
        {
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int level = image.GetPixel(x, y).R;
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
