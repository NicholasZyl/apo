using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class FastBitmap : IDisposable
    {
        private Bitmap baseImage;
        private BitmapData data;

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

        public FastBitmap(string path)
        {
            initImage(new Bitmap(Image.FromFile(path, false)));
        }

        public FastBitmap(Bitmap image)
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
            lockImage();

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
        }

        unsafe public int GetPixel(int x, int y)
        {
            lockImage();

            return (int)*((byte*)data.Scan0 + (y * data.Stride) + x);
        }

        unsafe public void SetPixel(int x, int y, int pixel)
        {
            lockImage();
            byte* pixelPointer = ((byte*)data.Scan0 + (y * data.Stride) + x);
            *pixelPointer = (byte)pixel;
        }

        public FastBitmap Clone()
        {
            unlockImage();

            return new FastBitmap((Bitmap)baseImage.Clone());
        }

        private void lockImage()
        {
            if (data == null)
            {
                data = baseImage.LockBits(new Rectangle(0, 0, baseImage.Width, baseImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            }
        }

        private void unlockImage()
        {
            if (data != null)
            {
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
