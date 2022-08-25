using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(string productId);
        Task<ProductModel> GetByIdAsync(string productId);
        Task<List<ProductModel>> ListByFilterAsync(string productId = null, string description = null);
        Task<bool> ExistByIdAsync(string productId);
    }
}
