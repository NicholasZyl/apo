using System;
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

        public SteganographyRevealOperation(int bitsUsedToHide)
        {
            this.bitsUsedToHide = bitsUsedToHide;
        }

        public GrayscaleImage perform(GrayscaleImage image)
        {
            Bitmap finalImage = prepareImageFromHiddenHeader(image);
            int hiddenImageX = 0, hiddenImageY = 0, bitIndex = 0, bitsRead = 0;
            byte[] hiddenPixel = new byte[8];
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    byte[] pixel = toBits((byte)image.GetPixel(x, y));
                    for (int i = bitsUsedToHide; i > 0; --i)
                    {
                        if (bitsRead++ < HIDDEN_HEADER_LENGTH)
                        {
                            continue;
                        }
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
                                    return new GrayscaleImage(finalImage); // TODO: Very ugly, refactor
                                }
                            }
                        }
                    }
                }
            }

            return new GrayscaleImage(finalImage);
        }

        private Bitmap prepareImageFromHiddenHeader(GrayscaleImage image)
        {
            // Method is duplicating main loop logic, should be refactored
            int imageWidth = 0, imageHeight = 0, headerIndex = 0;
            byte[] header = new byte[8];
            for (int y = 0; y < image.Height && (imageWidth == 0 || imageHeight == 0); ++y)
            {
                for (int x = 0; x < image.Width && (imageWidth == 0 || imageHeight == 0); ++x)
                {
                    byte[] pixel = toBits((byte)image.GetPixel(x, y));
                    for (int i = bitsUsedToHide; i > 0; --i)
                    {
                        header[headerIndex++] = pixel[8 - i];
                        if (headerIndex == 8)
                        {
                            byte foundValue = toByte(header);
                            header = new byte[8];
                            headerIndex = 0;

                            if (imageWidth == 0)
                            {
                                imageWidth = (int)foundValue;
                            }
                            else
                            {
                                imageHeight = (int)foundValue;
                            }
                        }
                    }
                }
            }
            return new Bitmap(imageWidth, imageHeight);
        }
    }
}
