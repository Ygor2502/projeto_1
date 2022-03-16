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

            modelBuilder.Entity<Departamento>()
                .HasData(
                new Departamento { Id = 1, Nome = "Tecnologia", Sigla = "TI" },
                new Departamento { Id = 2, Nome = "Recursos Humando", Sigla = "RH" },
                new Departamento { Id = 3, Nome = "Marketing", Sigla = "MKT" });;


            modelBuilder.Entity<Funcionario>()
                .HasData(
                new Funcionario { Id = 1, Nome = "Joao", Foto = "Pmg", RG = 88888888},
                new Funcionario { Id = 2, Nome = "Maria", Foto = "Pmg", RG = 77777777},
                new Funcionario { Id = 3, Nome = "Pedro", Foto = "Pmg", RG = 99999999 });
          
        }

        
    }
}
