using Microsoft.EntityFrameworkCore;
using Projeto_a.Configuration;
using Projeto_a.Models;
using System;
using System.Collections.Generic;

namespace Projeto_a.Data
{
    public class WDProducersContext : DbContext
    {
        

        public WDProducersContext(DbContextOptions<WDProducersContext> options) : base(options)
        {
        }
            

        public DbSet <Departamento> Departamentos { get; set; }

        public DbSet <Funcionario> Funcionarios { get; set; }

        internal List<Departamento> GetDepartamento()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DepartamentoConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            

            modelBuilder.Entity<Departamento>()
                .Property(p => p.Nome)
                .HasMaxLength(50);
        }
    }
}
