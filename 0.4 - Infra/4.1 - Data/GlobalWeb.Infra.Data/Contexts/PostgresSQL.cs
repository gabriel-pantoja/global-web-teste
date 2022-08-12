using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;

namespace GlobalWeb.Infra.Data.Contexts
{
    public class PostgresSQL : DbContext
    {
        public PostgresSQL(DbContextOptions<PostgresSQL> options) : base(options) { }

        public DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMapping());

            ClientMapping.PreLoadedData(modelBuilder);
        }
    }
}
