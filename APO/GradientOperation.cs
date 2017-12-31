using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace APO
{
    class GradientOperation : NeighbourhoodOperation, Operation
    {
        private int[] maskOne;
        private int[] maskTwo;
        private Scaling scaling;

        public GradientOperation(int[] maskOne, int[] maskTwo, EdgeProcessing edgeProcessing, Scaling scaling)
        {
            this.maskOne = maskOne;
            this.maskTwo = maskTwo;
            this.edgeProcessing = edgeProcessing;
            this.scaling = scaling;
            buildPointMask(3, 3);
        }

        public FastBitmap perform(FastBitmap image)
        {
            FastBitmap finalImage = image.Clone();

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = scaleFinalPixel(image, applyOnPixel(image, x, y), this.scaling);
                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }

        private int applyOnPixel(FastBitmap image, int x, int y)
        {
            int[] neigbourhood = getPixelNeighbourhood(image, x, y);
            if (neigbourhood.Length == 1)
            {
                return neigbourhood[0];
            }

            return (applyMaskOnNeighbourhood(maskOne, neigbourhood) + applyMaskOnNeighbourhood(maskTwo, neigbourhood)) ^ (1/2);
        }

        private int applyMaskOnNeighbourhood(int[] mask, int[] neighbourhood)
        {
            return (mask[0] * neighbourhood[0] + mask[1] * neighbourhood[1] + mask[2] * neighbourhood[2] + mask[3] * neighbourhood[3] + mask[4] * neighbourhood[4] + mask[5] * neighbourhood[5] + mask[6] * neighbourhood[6] + mask[7] * neighbourhood[7] + mask[8] * neighbourhood[8]) ^ 2;
        }
    }
}
