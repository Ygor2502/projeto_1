using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_a.Data;
using Projeto_a.Models;
using System.Linq;


namespace Projeto_WD.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]

    public class FuncionarioController : ControllerBase
    {
        private readonly WDProducersContext _context;


        public FuncionarioController(WDProducersContext context)
        {
            _context = context;
        }



        [HttpGet]
        [Route("MostrarTodos")]
        public IActionResult Get()
        {
            return Ok(_context.Funcionarios);
        }


        [HttpGet]
        [Route("BuscarId")]
        public IActionResult GetFuncId(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(a => a.Id == id);
            if (funcionario == null) return BadRequest("O Funcionario não foi encontrado");

            return Ok(funcionario);
        }

        [HttpGet]
        [Route("BuscarNome")]
        public IActionResult GetFuncName(string nome)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(a =>
                a.Nome.Contains(nome));
            if (funcionario == null) return BadRequest("O Funcionario não foi encontrado");

            return Ok(funcionario);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(Funcionario funcionario)
        {
            _context.Add(funcionario);
            _context.SaveChanges();
            return Ok(funcionario);
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put(int id, Funcionario funcionario)
        {
            var func = _context.Funcionarios.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (func == null) return BadRequest("Funcionario não encontrado");

            _context.Update(funcionario);
            _context.SaveChanges();
            return Ok("Funcionario cadastrado");
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(a => a.Id == id);
            if (funcionario == null) return BadRequest("Funcionario não encontrado");

            _context.Remove(funcionario);
            _context.SaveChanges();
            return Ok("Funcionario removido");
        }

    }
}


