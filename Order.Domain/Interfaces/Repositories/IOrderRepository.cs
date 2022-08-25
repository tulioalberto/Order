using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Repositories
{
    interface IOrderRepository
    {
        Task CreateAsync(OrderModel order);
        Task CreateItemAsync(OrderModel item);
        Task UptadeItemAsync(OrderModel item);
        Task UpdateAsync(OrderModel order);
        Task DeleteAsync(string orderId);
        Task DeleteItemAsync(string itemId);
        Task<OrderModel> GetByIdAsync(string orderId);
        Task<List<OrderModel>> ListByFilterAsync(string orderId = null, string clientid = null, string userId= null);
        Task<List<OrderModel>> ListItensByOrderIdAsync(string orderId);
        Task<bool> ExistByIdAsync(string orderId);
    }
}
