using GlobalWeb.Domain.Models;
using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Domain.Interfaces
{
    public interface IClientDomain
    {
        Task<List<Client>> GetAll();
        Task<Client> Get(int id);
        Task<Client> Add(ClientModelRequest entity);
        Task<Client> Update(ClientModelRequest entity);
        Task<bool> Delete(int id);
    }
}
