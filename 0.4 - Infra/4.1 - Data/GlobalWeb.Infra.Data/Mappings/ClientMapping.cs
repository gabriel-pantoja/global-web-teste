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
            builder.ToTable("client");

            builder
              .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .HasColumnName("id");

            builder
                .Property(i => i.FullName)
                .IsRequired()
                .HasColumnType("varchar(250)")
                .HasColumnName("fullname");

            builder
                .Property(i => i.Document)
                .IsRequired()
                .HasColumnType("varchar(20)")
                .HasColumnName("document");

            builder
                .Property(i => i.BirthDate)
                .IsRequired()
                .HasColumnName("birthdate");

            builder
                .Property(i => i.Address)
                .IsRequired()
                .HasColumnType("varchar(250)")
                .HasColumnName("address");

            builder
                .Property(i => i.DateRegister)
                .HasDefaultValue(DateTime.Now)
                .HasColumnName("dateregister");

            builder
                .Property(i => i.Active)
                .HasColumnName("active");
        }
        public static void PreLoadedData(ModelBuilder modelBuilder)
        {
            List<Client> data = new()
            {
                new Client()
                {
                    Id = 1,
                    FullName = "Guilherme Enrico Pietro Nascimento",
                    Document = "08276305903",
                    Address = "Quadra SGAN 914 Módulo C",
                    BirthDate = new DateTime(2001, 01, 08),
                    DateRegister = new DateTime(2022, 08, 12),
                    Active = true
                }
            };

            data.ForEach(item => modelBuilder.Entity<Client>().HasData(item));
        }
    }
}
