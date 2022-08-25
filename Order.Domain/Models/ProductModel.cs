using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Models
{
    public class ProductModel : EntityBase
    {
        public string Description { get; set; }
        public double SellValue { get; set; }
        public int Stock { get; set; }
    }
}
