using GlobalWeb.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Application.Interfaces
{
    public interface IClientApplication
    {
        public Task<List<Client>> GetAll();
    }
}
