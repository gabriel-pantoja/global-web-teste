using GlobalWeb.Infra.Data.Contexts;
using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalWeb.Infra.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly PostgresSQL _context;
        public ClientRepository(PostgresSQL context)
        {
            _context = context;
        }
        public async Task<List<Client>> GetAll()
        {
            List<Client> clients = await _context.Client.ToListAsync();
            return clients;
        }

        public async Task<Client> Get(int id)
        {
            Client client = await _context.Client.SingleOrDefaultAsync(x => x.Id.Equals(id));
            return client;
        }

        public async Task<Client> GetByDocument(string document)
        {
            Client client = await _context.Client.FirstOrDefaultAsync(x => x.Document == document);
            return client;
        }

        public async Task Add(Client entity)
        {
            _context.Client.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Client entity)
        {
            _context.Client.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Client entity)
        {
            _context.Client.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
