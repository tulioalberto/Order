using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Models
{
    public class OrderItemModel : EntityBase
    {
        public OrderModel Order { get; set; }
        public ProductModel Product { get; set; }
        public decimal SellValeu { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
