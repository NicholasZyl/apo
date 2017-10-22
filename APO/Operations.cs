﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class Operations
    {
        public enum EqualizationMethod
        {
            Mean,
            Random,
            Neighbours,
            Custom,
        }

        public Bitmap stretchHistogram(Bitmap image)
        {
            Histogram h = new Histogram(image);
            int vMin = h.LevelsCount;
            int vMax = 0;
            int[] levels = h.Levels;
            for (int i = 0; i < h.LevelsCount; ++i)
            {
                if (0 < levels[i])
                {
                    vMin = Math.Min(vMin, i);
                    vMax = Math.Max(vMax, i);
                }
            }
            int[] changes = new int[h.LevelsCount];
            for (int i = 0; i < h.LevelsCount; ++i)
            {
                int newLevel = (int)(h.LevelsCount / (vMax - vMin) * (i - vMin));
                changes[i] = (newLevel < 0) ? 0 : newLevel;
            }
            
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    int level = (color.R + color.G + color.B)/3;
                    Color newColor = Color.FromArgb(changes[level], changes[level], changes[level]);

                    image.SetPixel(x, y, newColor);
                }
            }

            return image;
        }
        public Bitmap meanEqualizationHistogram(Bitmap image, EqualizationMethod method)
        {
            Histogram h = new Histogram(image);
            int Havg = 0;
            for (int i = 0; i < h.LevelsCount; i++)
                Havg += h.Levels[i];
            Havg /= h.LevelsCount;

            int R = 0;
            int Hint = 0;
            int[] left = new int[h.LevelsCount];
            int[] right = new int[h.LevelsCount];
            int[] _new = new int[h.LevelsCount];

            for (int z = 0; z < h.LevelsCount; z++)
            {
                left[z] = R;
                Hint += h.Levels[z];
                while (Hint > Havg)
                {
                    Hint -= Havg;
                    R++;
                }
                if (R > h.LevelsCount - 1) R = h.LevelsCount - 1;
                right[z] = R;

                switch (method)
                {
                    case EqualizationMethod.Mean:
                        _new[z] = (left[z] + right[z]) / 2;
                        break;

                    case EqualizationMethod.Random:
                        _new[z] = right[z] - left[z];
                        break;

                    case EqualizationMethod.Custom:
                        _new[z] = (left[z] + right[z]) / 2;
                        break;

                    default:
                        break;
                }
            }

            Random random = new Random();

            for (int i = 0; i < image.Width; ++i)
            {
                for (int j = 0; j < image.Height; ++j)
                {
                    int color = 0;

                    int val = (image.GetPixel(i, j).R+ image.GetPixel(i, j).G+ image.GetPixel(i, j).B)/3;

                    if (left[val] == right[val])
                    {
                        color = left[val];
                    }
                    else
                    {
                        switch (method)
                        {
                            case EqualizationMethod.Mean:
                                color = _new[val];
                                break;

                            case EqualizationMethod.Random:
                                int value = random.Next(0, _new[val]);
                                color = (left[val] + value);
                                break;

                            case EqualizationMethod.Neighbours:
                                double average = 0;
                                int count = 0;
                                foreach (Point offset in new Point[] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1), new Point(1, 1), new Point(-1, -1), new Point(-1, 1), new Point(1, -1) })
                                {
                                    if (i + offset.X >= 0 && i + offset.X < image.Width && j + offset.Y >= 0 && j + offset.Y < image.Height)
                                    {
                                        average += (image.GetPixel(i + offset.X, j + offset.Y).R+ image.GetPixel(i + offset.X, j + offset.Y).G+ image.GetPixel(i + offset.X, j + offset.Y).B)/3;
                                        ++count;
                                    }
                                }
                                average /= count;
                                if (average > right[val])
                                    color = (byte)right[val];
                                else if (average < left[val])
                                    color = (byte)left[val];
                                else
                                    color = (byte)((int)average);
                                break;

                            case EqualizationMethod.Custom:
                                int rand = random.Next(0, _new[val]);
                                color = (left[val] + rand);
                                color = 255 < color ? left[val] : color;
                                break;

                            default:
                                break;
                        }
                    }

                    image.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }

            return image;
        }
    }
}
