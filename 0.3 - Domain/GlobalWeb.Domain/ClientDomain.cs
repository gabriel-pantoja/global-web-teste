using FluentValidation.Results;
using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Middleware;
using GlobalWeb.Infra.Repository.Interfaces;
using System;
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

        public async Task Add(ClientRequest entity)
        {
            var validator = new ClientRequestValidator();
            ValidationResult validationResult = validator.Validate(entity);

            if (!validationResult.IsValid)
                throw new CustomException(validationResult.Errors[0].ToString(), (int)HttpStatusCode.UnprocessableEntity, "Invalid Attribute");

            Client res = await _clientRepository.GetByDocument(entity.Document);
            if(res != null)
                throw new CustomException("Documento já existente", (int)HttpStatusCode.BadRequest, "Rule Validation");

            Client client = new()
            {
                FullName = entity.FullName,
                Document = entity.Document,
                Address = entity.Address,
                BirthDate = entity.BirthDate,
                DateRegister = DateTime.Now,
                Active = true
            };

            await _clientRepository.Add(client);
        }

        public async Task Update(int id, ClientRequest entity)
        {
            var validator = new ClientRequestValidator();
            ValidationResult validationResult = validator.Validate(entity);

            if (!validationResult.IsValid)
                throw new CustomException(validationResult.Errors[0].ToString(), (int)HttpStatusCode.UnprocessableEntity, "Invalid Attribute");

            Client client = await _clientRepository.Get(id);
            if (client == null)
                throw new CustomException("Cliente não encontrado", (int)HttpStatusCode.BadRequest, "Rule Validation");
           
            client.FullName = entity.FullName;
            client.Document = entity.Document;
            client.Address = entity.Address;
            client.BirthDate = entity.BirthDate;
           
            await _clientRepository.Update(client);
        }

        public async Task Delete(int id)
        {
            Client client = await _clientRepository.Get(id);
            if (client == null)
                throw new CustomException("Cliente não encontrado", (int)HttpStatusCode.BadRequest, "Rule Validation");

            await _clientRepository.Delete(client);
        }
    }
}
