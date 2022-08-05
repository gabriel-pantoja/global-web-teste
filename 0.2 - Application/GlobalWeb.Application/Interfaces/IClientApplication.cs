using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Application.Interfaces
{
    public interface IClientApplication
    {
        public Task<List<Client>> GetAll();
        Task<Client> Get(int id);
        Task<Client> Add(ClientRequest entity);
        Task<Client> Update(ClientRequest entity);
        Task<bool> Delete(int id);
    }
}
