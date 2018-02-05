using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace APO
{

    public class LogicFilteringOperation : NeighbourhoodOperation, Operation
    {
        public enum Direction
        {
            Vertical,
            Horizontal
        }

        private Direction direction;

        public LogicFilteringOperation(Direction direction, EdgeProcessing processing)
        {
            this.direction = direction;
            this.edgeProcessing = processing;
            buildPointMask(3, 3);
        }

        public GrayscaleImage perform(GrayscaleImage image)
        {
            GrayscaleImage finalImage = image.Clone();

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    int newColor = applyOnPixel(image, x, y);
                    finalImage.SetPixel(x, y, newColor);
                }
            }

            return finalImage;
        }

        private int applyOnPixel(GrayscaleImage image, int x, int y)
        {
            int[] neigbourhood = getPixelNeighbourhood(image, x, y);
            if (neigbourhood.Length == 1)
            {
                return neigbourhood[0];
            }

            int finalColor;
            if (direction == Direction.Horizontal)
            {
                finalColor = (neigbourhood[1] == neigbourhood[7]) ? neigbourhood[1] : neigbourhood[4];
            }
            else if (direction == Direction.Vertical)
            {
                finalColor = (neigbourhood[3] == neigbourhood[5]) ? neigbourhood[3] : neigbourhood[4];
            }
            else
            {
                finalColor = neigbourhood[4]; // Should not happen
            }

            return finalColor;
        }
    }
}
