using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleUp
{
    public class ImageManager
    {

        /// <summary>
        /// Gets the allowed images extensions
        /// </summary>
        public static string[] GetAllowedExtensions()
        {
            return new []
            {
                "png", "bmp","jpg","gif","tiff","jpeg"
            };
        }

        /// <summary>
        /// Gets the file with image extensions
        /// </summary>
        public static string[] GetAllowedFiles(string[] filePaths)
        {
            var allowedExt = GetAllowedExtensions();

            return filePaths.Where(m => allowedExt.Contains(m.Split('.').Last().ToLower())).ToArray();
        }

        /// <summary>
        /// Resizes a image proportionally
        /// </summary>
        /// <param name="imageStream">the image stream to resize</param>
        /// <param name="targetWidth">the targeted width where the targeted height is calculated accordingly</param>
        public static Stream ResizePicture(Stream imageStream, int targetWidth = 200)
        {
            if (imageStream == null)
            {
                return null;
            }

            Image image = new Bitmap(imageStream);
            
            int targetHeight= 200;
            int width = image.Width;
            int height = image.Height;
            Bitmap nImage = null;

            if (width < targetWidth && height < targetHeight)
            {
                return imageStream;
            }

            targetHeight = height * targetHeight / width;

            nImage = new Bitmap(targetWidth, targetHeight);

            using (var gr = Graphics.FromImage(nImage))
            {
                var sourceRect = new RectangleF(0, 0, width, height);
                var destinationRect = new RectangleF(0, 0, targetWidth, targetHeight);
                gr.DrawImage(
                    image,
                    destinationRect,
                    sourceRect,
                    GraphicsUnit.Pixel);
            }
            
            Stream nStream = new MemoryStream();
            nImage.Save(nStream, ImageFormat.Png);
            nImage.Dispose();
            return nStream;
        }

    }
}
