using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Domain.Interfaces
{
    public interface IClientDomain
    {
        public Task<List<Client>> GetAll();
    }
}
