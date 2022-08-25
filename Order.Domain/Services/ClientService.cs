using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository _lientRepository)
        {

        }
        public Task CreateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(ClientModel cliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFiltersAsync(string clientId = null, string name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
