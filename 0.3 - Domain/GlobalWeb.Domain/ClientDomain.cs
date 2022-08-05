using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Domain
{
    public class ClientDomain : IClientDomain
    {
        private readonly IClientRepository _clientRepository;
        public ClientDomain(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<List<Client>> GetAll()
        {
            return await _clientRepository.GetAll();
        }
    }
}
