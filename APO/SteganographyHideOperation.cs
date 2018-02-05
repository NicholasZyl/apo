using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class SteganographyHideOperation : SteganographyOperation, Operation
    {
        private Bitmap imageToHide;
        private int bitsToHideIn;

        public SteganographyHideOperation(Bitmap imageToHide, int numberOfBits)
        {
            this.imageToHide = imageToHide;
            bitsToHideIn = numberOfBits;
        }

        public GrayscaleImage perform(GrayscaleImage image)
        {
            bool hideWidth = true, hideHeight = true;
            int hiddenImageX = 0, hiddenImageY = 0, bitIndex = 0;
            byte[] pixelToHide = toBits((byte)imageToHide.Width);
            // Below loops are ugly, should be refactored to be more readable
            for (int y = 0; y < image.Height && hiddenImageY < imageToHide.Height; ++y)
            {
                for (int x = 0; x < image.Width && hiddenImageX < imageToHide.Width; ++x)
                {
                    byte[] pixel = toBits((byte)image.GetPixel(x, y));
                    for (int i = bitsToHideIn; i > 0 && bitIndex < 8; --i)
                    {
                        pixel[8 - i] = pixelToHide[bitIndex++];
                        if (bitIndex == 8)
                        {
                            if (hideWidth)
                            {
                                hideWidth = false;
                                pixelToHide = toBits((byte)imageToHide.Height);
                                bitIndex = 0;
                            }
                            else if (hideHeight)
                            {
                                hideHeight = false;
                                pixelToHide = toBits(imageToHide.GetPixel(hiddenImageX, hiddenImageY).R);
                                bitIndex = 0;
                            }
                            else
                            {
                                if (++hiddenImageX >= imageToHide.Width)
                                {
                                    hiddenImageX = 0;
                                    ++hiddenImageY;
                                }

                                if (hiddenImageY < imageToHide.Height)
                                {
                                    bitIndex = 0;
                                    pixelToHide = toBits(imageToHide.GetPixel(hiddenImageX, hiddenImageY).R);
                                }
                            }
                        }
                    }
                    byte newPixel = toByte(pixel);
                    image.SetPixel(x, y, newPixel);
                }
            }

            return image;
        }
    }
}
