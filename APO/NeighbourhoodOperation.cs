﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class NeighbourhoodOperation
    {
        public enum EdgeProcessing
        {
            IgnoreEdgeLines,
            DuplicateEdges,
            OnlyExistingNeighbourhood
        }

        public enum Scaling
        {
            FirstMethod,
            SecondMethod,
            ThirdMethod
        }

        protected Point[,] pointMask;
        protected EdgeProcessing edgeProcessing;

        protected void buildPointMask(int sizeX, int sizeY)
        {
            this.pointMask = new Point[sizeX, sizeY];
            int pointIndexX = sizeX - sizeX / 2 - 1;
            int pointIndexY = sizeY - sizeY / 2 - 1;
            for (int i = -pointIndexX; i <= pointIndexX; ++i)
            {
                for (int j = -pointIndexY; j <= pointIndexY; ++j)
                {
                    pointMask[i + pointIndexX, j + pointIndexY] = new Point(i, j);
                }
            }
        }

        protected int[] getPixelNeighbourhood(Bitmap image, int x, int y)
        {
            int neighbourIndex = 0;
            int[] neighbourhood = new int[pointMask.GetLength(0) * pointMask.GetLength(1)];;
            for (int i = 0; i < pointMask.GetLength(0); ++i)
            {
                for (int j = 0; j < pointMask.GetLength(1); ++j)
                {
                    Color pixel;
                    int getX = x + pointMask[i, j].X;
                    int getY = y + pointMask[i, j].Y;
                    if (edgeProcessing == EdgeProcessing.DuplicateEdges)
                    {
                        if (getX < 0)
                        {
                            getX = 0;
                        } else if (getX >= image.Width)
                        {
                            getX = image.Width - 1;
                        }
                        if (getY < 0)
                        {
                            getY = 0;
                        } else if (getY >= image.Height)
                        {
                            getY = image.Height - 1;
                        }
                    } else if (edgeProcessing == EdgeProcessing.OnlyExistingNeighbourhood && (getX < 0 || getX >= image.Width || getY < 0 || getY >= image.Height))
                    {
                        continue;
                    } else if (edgeProcessing == EdgeProcessing.IgnoreEdgeLines && (getX <= 0 || getX >= (image.Width - 1) || getY <= 0 || getY >= (image.Height - 1)))
                    {
                        pixel = image.GetPixel(x, y);
                        return new int[1] { (pixel.R + pixel.G + pixel.B) / 3 };
                    }

                    pixel = image.GetPixel(getX, getY);
                    int oldColor = (pixel.R + pixel.G + pixel.B) / 3;
                    neighbourhood[neighbourIndex++] = oldColor;
                }
            }

            return neighbourhood;
        }

        protected int scaleFinalPixel(Bitmap image, int pixelValue, Scaling method)
        {
            switch (method)
            {
                case Scaling.FirstMethod:
                    Hisatogram histogram = new Hisatogram(image);
                    return Math.Max(histogram.Min, Math.Min(histogram.Max, pixelValue));
                case Scaling.SecondMethod:
                    if (pixelValue < 0)
                    {
                        return 0;
                    } else if (pixelValue > 255)
                    {
                        return 254;
                    } else
                    {
                        return (255 - 1) / 2;
                    }
                case Scaling.ThirdMethod:
                    return Math.Max(0, Math.Min(255, pixelValue));
                default:
                    throw new ArgumentException("Unknown scaling method used");
            }
        }
    }
}
