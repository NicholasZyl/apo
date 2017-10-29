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
        private Bitmap baseImage;

        public Sub(Bitmap baseImage)
        {
            this.baseImage = baseImage;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)baseImage.Clone();
            for (int y = 0; y < baseImage.Height; ++y)
            {
                for (int x = 0; x < baseImage.Width; ++x)
                {
                    if (x >= image.Width || y >= image.Height)
                    {
                        continue;
                    }
                    Color baseColor = baseImage.GetPixel(x, y);
                    Color addColor = image.GetPixel(x, y);
                    finalImage.SetPixel(
                        x,
                        y,
                        Color.FromArgb(
                            Math.Max(baseColor.R - addColor.R, 0),
                            Math.Max(baseColor.G - addColor.G, 0),
                            Math.Max(baseColor.B - addColor.B, 0)
                        )
                    );
                }
            }

            return finalImage;
        }
    }
}
