using System.Collections.Generic;

namespace Projeto_a.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IEnumerable<Funcionario> Funcionario { get; set; }

        public string Sigla { get; set; }
        
        
    }
}
