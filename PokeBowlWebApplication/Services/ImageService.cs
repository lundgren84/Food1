using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace PokeBowlWebApplication.Services
{
    public class ImageService
    {
        public void Resize(string imageFile, string outputFile, double scaleFactor)
        {
            using (var srcImage = Image.FromFile(imageFile))
            {
                var newWidth = (int)(srcImage.Width * scaleFactor);
                var newHeight = (int)(srcImage.Height * scaleFactor);
                using (var newImage = new Bitmap(newWidth, newHeight))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                    newImage.Save(outputFile, ImageFormat.Jpeg);
                }
            }
        }

        public double GetScaleFactor(int contentLength)
        {
            contentLength = contentLength / 1000;
            var result = 1.0;
            if (contentLength > 2500)
            {
                result = 0.3;
            }
            else if (contentLength > 2000)
            {
                result = 0.4;
            }
            else if (contentLength > 1500)
            {
                result = 0.5;
            }
            else if (contentLength > 1000)
            {
                result = 0.6;
            }
            else if (contentLength > 500)
            {
                result = 0.7;
            }
            return result;
        }

        public Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);

            }
            return bitmap;
        }
    }
}