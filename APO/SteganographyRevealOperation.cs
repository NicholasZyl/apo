﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class SteganographyRevealOperation : SteganographyOperation, Operation
    {
        private readonly int bitsUsedToHide;
        private readonly int imageWidth;
        private readonly int imageHeight;

        public SteganographyRevealOperation(int bitsUsedToHide, int imageWidth, int imageHeight)
        {
            this.bitsUsedToHide = bitsUsedToHide;
            this.imageWidth = imageWidth;
            this.imageHeight = imageHeight;
        }

        public Bitmap perform(Bitmap image)
        {
            Bitmap finalImage = new Bitmap(imageWidth, imageHeight);
            int hiddenImageX = 0, hiddenImageY = 0, bitIndex = 0;
            byte[] hiddenPixel = new byte[8];
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    byte[] pixel = toBits(image.GetPixel(x, y).R);
                    for (int i = bitsUsedToHide; i > 0; --i)
                    {
                        hiddenPixel[bitIndex++] = pixel[8-i];
                        if (bitIndex == 8)
                        {
                            byte finalPixel = toByte(hiddenPixel);
                            hiddenPixel = new byte[8];
                            bitIndex = 0;

                            finalImage.SetPixel(hiddenImageX, hiddenImageY, Color.FromArgb(finalPixel, finalPixel, finalPixel));
                            if (++hiddenImageX >= finalImage.Width)
                            {
                                hiddenImageX = 0;
                                if (++hiddenImageY >= finalImage.Height)
                                {
                                    return finalImage; // TODO: Very ugly, refactor
                                }
                            }
                        }
                    }
                }
            }

            return finalImage;
        }
    }
}
