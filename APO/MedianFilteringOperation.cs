using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class MedianFilteringOperation : NeighbourhoodOperation, Operation
    {
        public MedianFilteringOperation(int sizeX, int sizeY, EdgeProcessing edgeProcessing)
        {
            buildPointMask(sizeX, sizeY);
            this.edgeProcessing = edgeProcessing;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = applyMedianMaskOnPixel(image, x, y);
                    finalImage.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor));
                }
            }

            return finalImage;
        }

        private int applyMedianMaskOnPixel(Bitmap image, int x, int y)
        {
            int[] neigbourhood = getPixelNeighbourhood(image, x, y);
            if (neigbourhood.Length == 1) {
                return neigbourhood[0];
            }
            Array.Sort(neigbourhood);

            int finalColor;
            if (neigbourhood.Length % 2 == 1)
                finalColor = neigbourhood[neigbourhood.Length / 2];
            else
                finalColor = scaleFinalPixel(image, (neigbourhood[neigbourhood.Length / 2] + neigbourhood[(neigbourhood.Length / 2) + 1]) / 2, Scaling.ThirdMethod);

            return finalColor;
        }
    }
}
