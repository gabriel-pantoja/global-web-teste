using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<List<Client>> GetAll();
        Task<Client> Get(int id);
        Task Add(ClientRequest entity);
        Task Update(int id, ClientRequest entity);
        Task Delete(int id);
    }
}
