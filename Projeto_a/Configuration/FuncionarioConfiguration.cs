using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto_a.Models;

namespace Projeto_a.Configuration
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>

    {
        public void Configure(EntityTypeBuilder<Funcionario>builder)
        {
            

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("Nome");
            builder.Property(x => x.Foto).HasColumnName("Foto");
            builder.Property(x => x.RG).HasColumnName("RG");

            builder.ToTable("Funcionarios");

        }
    }
}
