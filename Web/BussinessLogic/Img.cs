using BarcodeLib.Barcode;
using BarcodeLib.BarcodeReader;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace Web.BussinessLogic
{
    public class Img
    {
        public static QRCode QRCodeInit()
        {
            return new QRCode()
            {
                ModuleSize = 20,
                LeftMargin = 10,
                RightMargin = 10,
                TopMargin = 10,
                BottomMargin = 10,

                BackgroundColor = Color.BlueViolet,
                ModuleColor = Color.White,

                Encoding = QRCodeEncoding.Auto,
                Version = QRCodeVersion.V2,
                ECL = QRCodeErrorCorrectionLevel.Q,
                ImageFormat = ImageFormat.Png
            };
        }

        public static QRCode QRCodeInit(Color backgroundColor, Color moduleColor)
        {
            return new QRCode()
            {
                ModuleSize = 20,
                LeftMargin = 10,
                RightMargin = 10,
                TopMargin = 10,
                BottomMargin = 10,

                BackgroundColor = backgroundColor,
                ModuleColor = moduleColor,

                Encoding = QRCodeEncoding.Auto,
                Version = QRCodeVersion.V2,
                ECL = QRCodeErrorCorrectionLevel.Q,
                ImageFormat = ImageFormat.Png
            };
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static string ReadEAN13(string pathImg) => BarcodeReader.read(pathImg, BarcodeReader.EAN13)[0];
        public static string ReadEAN13(Bitmap image) => BarcodeReader.read(image, BarcodeReader.EAN13)[0];
        public static string ReadEAN13(Image image) => BarcodeReader.read((Bitmap)image, BarcodeReader.EAN13)[0];
    }
}