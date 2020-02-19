using CRUD.AirLiquide.Data.Extensions;
using CRUD.AirLiquide.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.AirLiquide.Data.Mappings
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnType("bit");

            builder.ToTable("Cliente");
        }
    }
}
