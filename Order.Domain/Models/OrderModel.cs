using System.Collections.Generic;

namespace Order.Domain.Models
{
    public class OrderModel : EntityBase
    {
        public ClientModel Cliente { get; set; }
        public UserModel User { get; set; }
        public List<OrderItemModel>  Itens { get; set; }
    }
}
