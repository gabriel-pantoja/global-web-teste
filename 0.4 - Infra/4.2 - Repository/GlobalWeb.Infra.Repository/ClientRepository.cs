using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Infra.Repository
{
    public class ClientRepository : IClientRepository
    {
        public async Task<List<Client>> GetAll()
        {
            List<Client> clients = new();
            clients.Add(new Client()
            {
                Id = 1,
                FullName = "Gabriel",
                Document = "22",
                Birthday = System.DateTime.Now,
                DateRegister = System.DateTime.Now,
                Active = true
            });
            return clients;
        }
        public Task<Client> Add(Client entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> Update(Client entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
