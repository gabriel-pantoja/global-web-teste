using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Domain.Interfaces
{
    public interface IClientDomain
    {
        Task<List<Client>> GetAll();
        Task<Client> Get(int id);
        Task Add(ClientRequest entity);
        Task Update(int id, ClientRequest entity);
        Task Delete(int id);
    }
}
