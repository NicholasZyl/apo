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

        public MorphologicalOperation(Operator desiredOperator, Structuring structuring, EdgeProcessing edgeProcessing)
        {
            this.desiredOperator = desiredOperator;
            this.structuring = structuring;
            this.edgeProcessing = edgeProcessing;
            buildPointMask(3, 3);
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage;
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

        private Bitmap erosion(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = applyErosionOnPixel(image, x, y);
                    finalImage.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor));
                }
            }

            return finalImage;
        }

        private int applyErosionOnPixel(Bitmap image, int x, int y)
        {
            int[] neigbourhood = getPixelNeighbourhood(image, x, y);
            if (neigbourhood.Length == 1)
            {
                return neigbourhood[0];
            }

            int finalColor;
            switch (structuring)
            {
                case Structuring.VonNeumann:
                    finalColor = Math.Min(Math.Min(neigbourhood[1], neigbourhood[3]), Math.Min(neigbourhood[5], neigbourhood[7]));
                    break;
                case Structuring.Moore:
                    finalColor = Math.Min(Math.Min(Math.Min(neigbourhood[0], neigbourhood[1]), Math.Min(neigbourhood[2], neigbourhood[3])), Math.Min(Math.Min(neigbourhood[5], neigbourhood[6]), Math.Min(neigbourhood[7], neigbourhood[8])));
                    break;
                default:
                    throw new ArgumentException("Unknown structuring");
            }

            return finalColor;
        }

        private Bitmap dilatation(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = applyDilatationOnPixel(image, x, y);
                    finalImage.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor));
                }
            }

            return finalImage;
        }

        private int applyDilatationOnPixel(Bitmap image, int x, int y)
        {
            int[] neigbourhood = getPixelNeighbourhood(image, x, y);
            if (neigbourhood.Length == 1)
            {
                return neigbourhood[0];
            }

            int finalColor;
            switch (structuring)
            {
                case Structuring.VonNeumann:
                    finalColor = Math.Min(Math.Min(neigbourhood[1], neigbourhood[3]), Math.Min(neigbourhood[5], neigbourhood[7]));
                    break;
                case Structuring.Moore:
                    finalColor = Math.Min(Math.Min(Math.Min(neigbourhood[0], neigbourhood[1]), Math.Min(neigbourhood[2], neigbourhood[3])), Math.Min(Math.Min(neigbourhood[5], neigbourhood[6]), Math.Min(neigbourhood[7], neigbourhood[8])));
                    break;
                default:
                    throw new ArgumentException("Unknown structuring");
            }

            return finalColor;
        }
    }
}
