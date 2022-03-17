using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_a.Data;
using Projeto_a.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WD.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]

    public class DepartamentoController : ControllerBase
    {
        private readonly WDProducersContext _context;

        public DepartamentoController(WDProducersContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var departamentos = await _context.Departamentos.ToListAsync();
            return Ok(departamentos);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(Departamento departamento)
        {
            _context.Add(departamento);
            _context.SaveChanges();
            return Ok(departamento);
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put(string nome, Departamento departamento)
        {
            var depar = _context.Departamentos.AsNoTracking().FirstOrDefault(a => a.Nome == nome);
            if (depar == null) return BadRequest("Departamento não encontrado");

            _context.Update(departamento);
            _context.SaveChanges();
            return Ok("Departamento cadastrado");
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete(string nome)
        {
            var departamento = _context.Departamentos.FirstOrDefault(a => a.Nome == nome);
            if (departamento == null) return BadRequest("Departamento não encontrado");

            _context.Remove(departamento);
            _context.SaveChanges();
            return Ok("Departamento removido");
        }

    }

}
