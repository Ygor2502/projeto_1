using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_a.Data;
using Projeto_a.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

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
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var funcionarios = await _context.Funcionarios.ToListAsync();
            return Ok(funcionarios);
        }


        [HttpGet]
        [Route("byId")]
        public async Task<IActionResult> GetFuncId([FromQuery] Guid id)
        {
            var funcionario = await _context.Funcionarios.Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();

            if (funcionario == null) 
                return BadRequest("O Funcionario não foi encontrado");

            return Ok(funcionario);
        }

        [HttpGet]
        [Route("BuscarNome")]
        public async Task<IActionResult> GetFuncName(string nome)
        {
            var funcionario = await _context.Funcionarios.Where(a =>
                a.Nome.Contains(nome)).FirstOrDefaultAsync();

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
        public async Task<IActionResult> Put(Guid id, Funcionario funcionario)
        {
            var func = await _context.Funcionarios.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (func == null) return BadRequest("Funcionario não encontrado");

            _context.Update(funcionario);
            _context.SaveChanges();
            return Ok("Funcionario cadastrado");
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete(Guid id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(a => a.Id == id);
            if (funcionario == null) return BadRequest("Funcionario não encontrado");

            _context.Remove(funcionario);
            _context.SaveChanges();
            return Ok("Funcionario removido");
        }

    }
}


