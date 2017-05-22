using BarcodeLib.Barcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.BussinessLogic;
using Web.Models;

namespace Web.Controllers
{
    public class DefaultController : ApiController
    {
        public TransferProduct GetProductWithQR(string EAN13)
        {
            var product = BussinessLogic.Product.Read(EAN13);
            QRCode baracode = Img.QRCodeInit();
            baracode.Data = EAN13;
            var QRImg = baracode.drawBarcode();
            return new TransferProduct
            {
                Manufacturer = product.Manufacturer,
                EAN13 = product.EAN13,
                Name = product.Name,
                Price = product.Price,
                ShelfLifeInDays = product.ShelfLifeInDays,
                ProductTypeId = product.ProductTypeId,
                //QRImage = QRImg
            };
        }

        public List<Models.ProductType> GetAllTypes()
        {
            return BussinessLogic.ProductType.GetAllProductTypes();
        }

        public IHttpActionResult AddProduct(Models.Product product)
        {
            new BussinessLogic.Product().Add(product);
            return Ok();
        }

        public IHttpActionResult AddType(Models.ProductType type)
        {
            new BussinessLogic.ProductType().Add(type);
            return Ok();
        }
    }
}
