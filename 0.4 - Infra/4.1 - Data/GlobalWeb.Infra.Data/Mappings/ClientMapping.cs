using GlobalWeb.Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace GlobalWeb.Infra.Data.Mappings
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
              .HasKey(i => i.Id);

            builder
                .Property(i => i.FullName)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder
                .Property(i => i.Document)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder
                .Property(i => i.BirthDate)
                .IsRequired();

            builder
                .Property(i => i.Address)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder
                .Property(i => i.DateRegister)
                .HasDefaultValue(DateTime.Now);
        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Client> data = new()
            {
                new Client()
                {
                    Id = 1,
                    FullName = "Gabriel Pantoja",
                    Document = "1111",
                    Address = "Teste",
                    BirthDate = new DateTime(1991, 09, 11),
                    Active = true
                }
            };

            data.ForEach(item => modelBuilder.Entity<Client>().HasData(item));
        }
    }
}
