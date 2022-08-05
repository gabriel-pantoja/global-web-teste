using GlobalWeb.Application.DTOs;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Application.Interfaces
{
    public interface IClientApplication
    {
        public Task<List<Client>> GetAll();
        Task<Client> Get(int id);
        Task<Client> Add(ClientDTORequest entity);
        Task<Client> Update(ClientDTORequest entity);
        Task<bool> Delete(int id);
    }
}
