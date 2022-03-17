using System;
using System.Collections.Generic;

namespace Projeto_a.Models
{
    public class Funcionario
    {
        public Funcionario(string nome, string foto, int rG, Guid idDepartamento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Foto = foto;
            RG = rG;
            IdDepartamento = idDepartamento;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }

        public int RG { get; set; }

        public Guid IdDepartamento { get; set; }
        
    }
}
