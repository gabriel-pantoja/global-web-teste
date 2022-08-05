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

        public async Task<Client> Get(int id)
        {
            return new Client()
            {
                Id = 1,
                FullName = "Gabriel",
                Document = "22",
                Birthday = System.DateTime.Now,
                DateRegister = System.DateTime.Now,
                Active = true
            };
        }


        public async Task<Client> Add(Client entity)
        {
            return new Client()
            {
                Id = entity.Id,
                FullName = entity.FullName,
                Document = entity.Document,
                Birthday = entity.Birthday,
                DateRegister = System.DateTime.Now,
                Active = true
            };
        }

        public async Task<Client> Update(Client entity)
        {
            return new Client()
            {
                Id = entity.Id,
                FullName = entity.FullName,
                Document = entity.Document,
                Birthday = entity.Birthday,
                DateRegister = System.DateTime.Now,
                Active = true
            };
        }

        public async Task<bool> Delete(int id)
        {
            return true;
        }
    }
}
