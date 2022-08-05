using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Domain.Models;
using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Application
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientDomain _clientService;

        public ClientApplication(IClientDomain clientService)
        {
            _clientService = clientService;
        }

        public async Task<List<Client>> GetAll()
        {
            return await _clientService.GetAll();
        }

        public async Task<Client> Get(int id)
        {
            return await _clientService.Get(id);
        }

        public async Task<Client> Add(ClientRequest entity)
        {
            return await _clientService.Add(entity);
        }

        public async Task<Client> Update(ClientRequest entity)
        {
            return await _clientService.Update(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _clientService.Delete(id);
        }
    }
}
