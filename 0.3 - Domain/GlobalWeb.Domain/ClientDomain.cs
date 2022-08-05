using FluentValidation.Results;
using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Middleware;
using GlobalWeb.Infra.Repository.Interfaces;
using System.Collections.Generic;
using System.Net;
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

        public async Task<Client> Get(int id)
        {
            return await _clientRepository.Get(id);
        }

        public async Task<Client> Add(ClientRequest entity)
        {
            var validator = new ClientRequestValidator();
            ValidationResult validationResult = validator.Validate(entity);

            if (!validationResult.IsValid)
                throw new CustomException(validationResult.Errors[0].ToString(), (int)HttpStatusCode.UnprocessableEntity, "Invalid Attribute");

            Client client = new()
            {
                FullName = entity.FullName,
                Document = entity.Document,
                Address = entity.Address,
                BirthDate = entity.BirthDate,
            };

            return await _clientRepository.Add(client);
        }

        public async Task<Client> Update(ClientRequest entity)
        {
            Client client = new()
            {
                FullName = entity.FullName,
                Document = entity.Document,
                Address = entity.Address,
                BirthDate = entity.BirthDate,
            };
            return await _clientRepository.Update(client);
        }

        public async Task<bool> Delete(int id)
        {
            return await _clientRepository.Delete(id);
        }
    }
}
