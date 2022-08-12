using GlobalWeb.Infra.Data.Entities;
using GlobalWeb.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;

namespace GlobalWeb.Infra.Data.Contexts
{
    public class PostgresSQL : DbContext
    {
        //public string connectionString = "Host=127.0.0.1;Port=5432;Database=your_db;Username=your_user;Password=your_secret";
        //public string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(connectionString);

        public PostgresSQL(DbContextOptions<PostgresSQL> options) : base(options) { }

        public DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMapping());

            ClientMapping.PreLoadedData(modelBuilder);
        }
    }
}
