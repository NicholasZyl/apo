using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class FastBitmap
    {
        private Dictionary<Point, int> pixels = new Dictionary<Point, int>();
        private Bitmap baseImage;

        public Bitmap BaseBitmap
        {
            get
            {
                return baseImage;
            }
        }

        public int Height
        {
            get
            {
                return baseImage.Height;
            }
        }

        public int Width
        {
            get
            {
                return baseImage.Width;
            }
        }

        public FastBitmap(string path)
        {
            baseImage = new Bitmap(Image.FromFile(path, false));
            mapImage(baseImage);
        }

        public FastBitmap(Bitmap image)
        {
            baseImage = image;
            mapImage(baseImage);
        }

        private void mapImage(Bitmap image)
        {
            for (int x = 0; x < image.Width; ++x)
            {
                for (int y = 0; y < image.Height; ++y)
                {
                    Point coords = new Point(x, y);
                    Color color = image.GetPixel(x, y);
                    int pixel = (color.R + color.G + color.B) / 3; ;
                    pixels.Add(coords, pixel);
                }
            }
        }

        public int GetPixel(int x, int y)
        {
            return pixels[new Point(x, y)];
        }

        public void SetPixel(int x, int y, int pixel)
        {
            baseImage.SetPixel(x, y, Color.FromArgb(pixel, pixel, pixel));
        }

        public FastBitmap Clone()
        {
            return new FastBitmap((Bitmap)baseImage.Clone());
        }
    }
}
