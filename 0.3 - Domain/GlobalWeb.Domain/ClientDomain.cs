using AutoMapper;
using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Domain.Models;
using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Domain
{
    public class ClientDomain : IClientDomain
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientDomain(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<List<Client>> GetAll()
        {
            return await _clientRepository.GetAll();
        }

        public async Task<Client> Get(int id)
        {
            return await _clientRepository.Get(id);
        }

        public async Task<Client> Add(ClientModelRequest entity)
        {
            Client client = _mapper.Map<Client>(entity);
            return await _clientRepository.Add(client);
        }

        public async Task<Client> Update(ClientModelRequest entity)
        {
            Client client = _mapper.Map<Client>(entity);
            return await _clientRepository.Update(client);
        }

        public async Task<bool> Delete(int id)
        {
            return await _clientRepository.Delete(id);
        }
    }
}
