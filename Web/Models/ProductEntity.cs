using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ProductEntity
    {
        public int Id { get; set; }
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Display(Name = "Штрих-код")]
        public string EAN13 { get; set; }
        [Display(Name = "Виробник")]
        public string Manufacturer { get; set; }
        [Display(Name = "Ціна")]
        public double Price { get; set; }
        [Display(Name = "Термін придатності(днів)")]
        public int ShelfLifeInDays { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}