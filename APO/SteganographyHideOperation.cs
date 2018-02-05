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
            GrayscaleImage finalImage = image.Clone();
            int hiddenImageX = 0, hiddenImageY = 0, bitIndex = 0;
            byte[] pixelToHide = toBits(imageToHide.GetPixel(hiddenImageX, hiddenImageY).R);
            for (int y = 0; y < finalImage.Height && hiddenImageY < imageToHide.Height; ++y)
            {
                for (int x = 0; x < finalImage.Width && hiddenImageX < imageToHide.Width; ++x)
                {
                    byte[] pixel = toBits((byte)finalImage.GetPixel(x, y));
                    for (int i = bitsToHideIn; i > 0 && bitIndex < 8; --i)
                    {
                        pixel[8 - i] = pixelToHide[bitIndex++];
                        if (bitIndex == 8)
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
                    byte newPixel = toByte(pixel);
                    finalImage.SetPixel(x, y, newPixel);
                }
            }

            return finalImage;
        }
    }
}
