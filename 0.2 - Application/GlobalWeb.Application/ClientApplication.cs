using AutoMapper;
using GlobalWeb.Application.DTOs;
using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Domain.Models;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Application
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientDomain _clientService;
        private readonly IMapper _mapper;

        public ClientApplication(IClientDomain clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<List<Client>> GetAll()
        {
            return await _clientService.GetAll();
        }

        public async Task<Client> Get(int id)
        {
            return await _clientService.Get(id);
        }

        public async Task<Client> Add(ClientDTORequest entity)
        {
            ClientModelRequest client = _mapper.Map<ClientModelRequest>(entity);
            return await _clientService.Add(client);
        }

        public async Task<Client> Update(ClientDTORequest entity)
        {
            ClientModelRequest client = _mapper.Map<ClientModelRequest>(entity);
            return await _clientService.Update(client);
        }

        public async Task<bool> Delete(int id)
        {
            return await _clientService.Delete(id);
        }
    }
}
