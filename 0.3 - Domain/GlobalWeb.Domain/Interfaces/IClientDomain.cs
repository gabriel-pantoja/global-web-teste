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
        Task<Client> Add(ClientRequest entity);
        Task<Client> Update(ClientRequest entity);
        Task<bool> Delete(int id);
    }
}
