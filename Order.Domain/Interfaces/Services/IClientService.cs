using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(string clientId);
        Task<ClientModel> GetByIdAsync(ClientModel cliente);
        Task<List<ClientModel>> ListByFiltersAsync(string clientId = null, string name = null);

    }
}
