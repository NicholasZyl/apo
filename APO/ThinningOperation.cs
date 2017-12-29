using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class ThinningOperation : NeighbourhoodOperation, Operation
    {
        public ThinningOperation(EdgeProcessing edgeProcessing)
        {
            buildPointMask(3, 3);
            this.edgeProcessing = edgeProcessing;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = (Bitmap)image.Clone();
            Point[] neighboursCoordinates = { new Point(0, 1), new Point(1, 1), new Point(1, 0), new Point(1, -1), new Point(0, -1), new Point(-1, -1), new Point(-1, 0), new Point(1, 0) };
            bool[,] skeleton = initSkeleton(image);
            bool pass = false;
            LinkedList<Point> pointsToRemove;

            do {
                pass = !pass;
                pointsToRemove = new LinkedList<Point> { };

                for (int x = 0; x < image.Width; ++x) 
                {
                    for (int y = 0; y < image.Height; ++y)
                    {
                        if (edgeProcessing == EdgeProcessing.DuplicateEdges)
                        {
                            if (x < 0)
                            {
                                x = 0;
                            }
                            else if (x >= image.Width)
                            {
                                x = image.Width - 1;
                            }
                            if (y < 0)
                            {
                                y = 0;
                            }
                            else if (y >= image.Height)
                            {
                                y = image.Height - 1;
                            }
                        }
                        else if (edgeProcessing == EdgeProcessing.OnlyExistingNeighbourhood && (x < 0 || x >= image.Width || y < 0 || y >= image.Height))
                        {
                            continue;
                        }
                        else if (edgeProcessing == EdgeProcessing.IgnoreEdgeLines && (x <= 0 || x >= (image.Width - 1) || y <= 0 || y >= (image.Height - 1)))
                        {
                            continue;
                        }
                        if (!skeleton[x, y]) {
                            continue;
                        }

                        int transitionsCount = 0;
                        int nonZeroNeighbours = 0;
                        bool previousNeighbour = skeleton[x - 1, y + 1];
                        foreach (Point point in neighboursCoordinates)
                        {
                            bool actualNeighbour = skeleton[x + point.X, y + point.Y];
                            nonZeroNeighbours += actualNeighbour ? 1 : 0;
                            transitionsCount += (previousNeighbour && !actualNeighbour) ? 1 : 0;
                            previousNeighbour = actualNeighbour;
                        }
                        if (nonZeroNeighbours > 1 && nonZeroNeighbours < 7 && transitionsCount == 1) {
                            if (pass && (!skeleton[x + 1, y] || !skeleton[x, y + 1] || !skeleton[x, y - 1] && !skeleton[x - 1, y])) {
                                pointsToRemove.AddLast(new Point(x, y));
                            }
                            if (!pass && (!skeleton[x - 1, y] || !skeleton[x, y - 1] || !skeleton[x, y + 1] && !skeleton[x + 1, y])) {
                                pointsToRemove.AddLast(new Point(x, y));
                            }
                        }
                    }
                }
                foreach (Point point in pointsToRemove) {
                    skeleton[point.X, point.Y] = false;
                }
            } while (pointsToRemove.ToArray().Length > 0);

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    if (edgeProcessing == EdgeProcessing.IgnoreEdgeLines && (x <= 0 || x >= (image.Width - 1) || y <= 0 || y >= (image.Height - 1)))
                    {
                        continue;
                    }
                    int[] neigbourhood = getPixelNeighbourhood(image, x, y);
                    if (neigbourhood.Length == 1) {
                    finalImage.SetPixel(x, y, skeleton[x, y] ? Color.Black : Color.White);
                    }
                    finalImage.SetPixel(x, y, skeleton[x, y] ? Color.Black : Color.White);
                }
            }

            return finalImage;
        }

        private bool[,] initSkeleton(Bitmap image)
        {
            bool[,] skeleton = new bool[image.Width, image.Height];
            for (int x = 0; x < image.Width; ++x) 
            {
                for (int y = 0; y < image.Height; ++y)
                {
                    Color color = image.GetPixel(x, y);
                    int oldColor = (color.R + color.G + color.B) / 3;
                    skeleton[x, y] = oldColor < 128;
                }
            }

            return skeleton;
        }
    }
}
