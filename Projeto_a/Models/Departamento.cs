using System;
using System.Collections.Generic;

namespace Projeto_a.Models
{
    public class Departamento
    {
        public Departamento(string nome, string sigla)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Sigla = sigla;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }
    }
}
