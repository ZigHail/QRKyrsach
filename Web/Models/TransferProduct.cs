using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TransferProduct : ProductEntity
    {
        public Bitmap EAN13Image { get; set; }
        public Bitmap QRImage { get; set; }
    }
}