using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain.Interfaces;
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
    }
}
