using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class And : Operation
    {
        private Bitmap baseImage;

        public And(Bitmap baseImage)
        {
            this.baseImage = baseImage;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)baseImage.Clone();
            Histogram baseHistogram = new Histogram(baseImage);
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
                            Math.Max(0, Math.Min(baseColor.R & addColor.R, baseHistogram.LevelsCount - 1)),
                            Math.Max(0, Math.Min(baseColor.G & addColor.G, baseHistogram.LevelsCount - 1)),
                            Math.Max(0, Math.Min(baseColor.B & addColor.B, baseHistogram.LevelsCount - 1))
                        )
                    );
                }
            }

            return finalImage;
        }
    }
}
