using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task CreateAsync(OrderModel Order);
        Task UpdateAsync(OrderModel Order);
        Task DeleteAsync(string OrderId);
        Task<OrderModel> GetByIdAsync(OrderModel Ordere);
        Task<List<OrderModel>> ListByFiltersAsync(string orderId = null, string clientid = null, string userId = null);
    }
}
