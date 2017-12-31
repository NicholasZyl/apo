using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace APO
{
    public class MorphologicalOperation : NeighbourhoodOperation, Operation
    {
        public enum Operator
        {
            Erosion,
            Dilatation,
            Opening,
            Closing
        }

        public enum Structuring
        {
            VonNeumann,
            Moore
        }

        private Operator desiredOperator;
        private Structuring structuring;
        private Dictionary<Point, int[]> cachedNeighbourhoods = new Dictionary<Point, int[]>();

        public MorphologicalOperation(Operator desiredOperator, Structuring structuring, EdgeProcessing edgeProcessing)
        {
            this.desiredOperator = desiredOperator;
            this.structuring = structuring;
            this.edgeProcessing = edgeProcessing;
            buildPointMask(3, 3);
        }

        public FastBitmap perform(FastBitmap image)
        {
            FastBitmap finalImage;
            switch (desiredOperator)
            {
                case Operator.Erosion:
                    finalImage = erosion(image);
                    break;
                case Operator.Dilatation:
                    finalImage = dilatation(image);
                    break;
                case Operator.Opening:
                    finalImage = erosion(image);
                    finalImage = dilatation(finalImage);
                    break;
                case Operator.Closing:
                    finalImage = dilatation(image);
                    finalImage = erosion(finalImage);
                    break;
                default:
                    throw new ArgumentException("Unknown operator");
            }

            return finalImage;
        }

        private FastBitmap erosion(FastBitmap image)
        {
            FastBitmap finalImage = image.Clone();
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int[] neighbourhood = getStructuredNeighbourhood(image, x, y);
                    int newColor = neighbourhood.Min();
                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }

        private FastBitmap dilatation(FastBitmap image)
        {
            FastBitmap finalImage = image.Clone();
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int[] neighbourhood = getStructuredNeighbourhood(image, x, y);
                    int newColor = neighbourhood.Max();
                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }

        private int[] getStructuredNeighbourhood(FastBitmap image, int x, int y)
        {
            Point point = new Point(x, y);
            if (cachedNeighbourhoods.ContainsKey(point))
            {
                return cachedNeighbourhoods[point];
            }

            int[] neigbourhood = getPixelNeighbourhood(image, x, y);
            if (neigbourhood.Length == 1)
            {
                cachedNeighbourhoods[point] = new int[] { neigbourhood[0] };
                return cachedNeighbourhoods[point];
            }

            switch (structuring)
            {
                case Structuring.VonNeumann:
                    cachedNeighbourhoods[point] = new int[] { neigbourhood[1], neigbourhood[3], neigbourhood[5], neigbourhood[7] };
                    break;
                case Structuring.Moore:
                    cachedNeighbourhoods[point] = new int[] { neigbourhood[0], neigbourhood[1], neigbourhood[2], neigbourhood[3], neigbourhood[5], neigbourhood[6], neigbourhood[7], neigbourhood[8] };
                    break;
                default:
                    throw new ArgumentException("Unknown structuring");
            }

            return cachedNeighbourhoods[point];
        }
    }
}
