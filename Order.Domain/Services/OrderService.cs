using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Services
{
    public class OrderService : IOrderService
    {
        public Task CreateAsync(OrderModel Order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string OrderId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetByIdAsync(OrderModel Ordere)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> ListByFiltersAsync(string orderId = null, string clientid = null, string userId = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(OrderModel Order)
        {
            throw new NotImplementedException();
        }
    }
}
