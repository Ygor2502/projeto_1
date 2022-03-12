using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto_a.Models;

namespace Projeto_a.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>

    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("Nome");
            builder.Property(x => x.Sigla).HasColumnName("Sigla");
            

            builder.ToTable("Departamentos");
        }
    }
}
