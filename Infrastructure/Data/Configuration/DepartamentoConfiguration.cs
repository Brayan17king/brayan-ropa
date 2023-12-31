using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departameto");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreDepartamento).IsRequired().HasMaxLength(40);

        builder.Property(x => x.IdPais).HasColumnType("int");
        builder.HasOne(x => x.Paises).WithMany(x => x.Departamentos).HasForeignKey(x => x.IdPais);

    }
}
