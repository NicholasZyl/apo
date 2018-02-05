using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class GrayscaleImage : IDisposable
    {
        private Bitmap baseImage;
        private BitmapData data;
        private byte[] pixelsMap;

        public Bitmap BaseBitmap
        {
            get
            {
                unlockImage();

                return (Bitmap)baseImage.Clone();
            }
        }

        public int Height
        {
            get
            {
                return baseImage.Height;
            }
        }

        public int Width
        {
            get
            {
                return baseImage.Width;
            }
        }

        public GrayscaleImage(string path)
        {
            initImage(new Bitmap(Image.FromFile(path, false)));
        }

        public GrayscaleImage(Bitmap image)
        {
            initImage(image);
        }

        unsafe private void initImage(Bitmap image)
        {
            baseImage = new Bitmap(image.Width, image.Height, PixelFormat.Format8bppIndexed);
            baseImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            ColorPalette pallete = baseImage.Palette;
            for (int i = 0; i < pallete.Entries.Length; ++i)
            {
                pallete.Entries[i] = Color.FromArgb(i, i, i);
            }
            baseImage.Palette = pallete;

            data = baseImage.LockBits(new Rectangle(0, 0, baseImage.Width, baseImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            Byte* pixelPointer = (Byte*)data.Scan0;
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    byte pixel = (byte)((30 * color.R + 59 * color.G + 11 * color.B) / 100);
                    pixelPointer[x] = pixel;
                }
                pixelPointer += data.Stride;
            }
            pixelsMap = new byte[Width * Height];
            Marshal.Copy(data.Scan0, pixelsMap, 0, pixelsMap.Length);
        }

        unsafe public int GetPixel(int x, int y)
        {
            lockImage();

            return pixelsMap[((y * Width) + x)];
        }

        unsafe public void SetPixel(int x, int y, int pixel)
        {
            lockImage();
            pixelsMap[((y * Width) + x)] = (byte) pixel;
        }

        public GrayscaleImage Clone()
        {
            unlockImage();

            return new GrayscaleImage((Bitmap)baseImage.Clone());
        }

        private void lockImage()
        {
            if (data == null)
            {
                data = baseImage.LockBits(new Rectangle(0, 0, baseImage.Width, baseImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

                pixelsMap = new byte[Width * Height];
                IntPtr baseImagePixel = data.Scan0;
                Marshal.Copy(baseImagePixel, pixelsMap, 0, pixelsMap.Length);
            }
        }

        private void unlockImage()
        {
            if (data != null)
            {
                IntPtr firstPixel = data.Scan0;
                Marshal.Copy(pixelsMap, 0, firstPixel, pixelsMap.Length);

                baseImage.UnlockBits(data);
                data = null;
            }
        }

        public void Dispose()
        {
            unlockImage();
            baseImage = null;
        }
    }
}
