using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class FilteringOperation : NeighbourhoodOperation, Operation
    {
        public enum OperationType
        {
            LowPassFilter,
            HighPassFilter,
            EdgeDetection
        }

        private int[] mask;
        private int maskSize;
        private OperationType type;
        private Scaling scaling;
        private int forceDivisor = 0;

        public FilteringOperation(int[] mask, OperationType type, EdgeProcessing edgeProcessing, Scaling scaling, int divisor)
        {
            this.mask = mask;
            this.maskSize = (int) Math.Sqrt(mask.Length);
            buildPointMask(maskSize, maskSize);
            this.type = type;
            this.edgeProcessing = edgeProcessing;
            this.scaling = scaling;
            this.forceDivisor = divisor;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            switch (type)
            {
                case OperationType.LowPassFilter:
                    finalImage = applyLowPassFilter(image);
                    break;
                case OperationType.HighPassFilter:
                case OperationType.EdgeDetection:
                    finalImage = applyHighPassFilter(image);
                    break;
            }

            return finalImage;
        }

        private Bitmap applyLowPassFilter(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            int divisor;
            if (forceDivisor == 0)
            {
                divisor = 0;
                for (int i = 0; i < mask.Length; ++i)
                {
                    divisor += mask[i];
                }
            } else
            {
                divisor = forceDivisor;
            }

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = scaleFinalPixel(image, applyMaskOnPixel(image, x, y, divisor), Scaling.ThirdMethod);
                    finalImage.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor));
                }
            }

            return finalImage;
        }

        private Bitmap applyHighPassFilter(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = scaleFinalPixel(image, applyMaskOnPixel(image, x, y, 1), scaling);
                    finalImage.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor));
                }
            }

            return finalImage;
        }

        private int applyMaskOnPixel(Bitmap image, int x, int y, int divisor)
        {
        	int[] neigbourhood = getPixelNeighbourhood(image, x, y);
        	if (neigbourhood.Length == 1) {
        		return neigbourhood[0];
        	}

            int finalColor = 0;
        	for (int i = 0; i < neigbourhood.Length; ++i) {
                    finalColor += mask[i] * neigbourhood[i];
        	}
            if (divisor == 0)
            {
                divisor = 1;
            }

            return finalColor/divisor;
        }
    }
}
