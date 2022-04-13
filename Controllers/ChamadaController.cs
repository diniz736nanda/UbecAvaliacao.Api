namespace UbecAvaliacao.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using UbecAvaliacao.API.Context;

    [Route("api/chamada")]
    [ApiController]
    public class ChamadaController : ControllerBase
    {
        private readonly UbecContext _context;
        public ChamadaController(UbecContext context)
        {
            _context = context;
        }
        
        //PEGAR A LISTA
        [HttpGet]
        public IActionResult GetAll()
        {
            var chamadas = _context.Chamadas;
            return Ok(chamadas);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var chamada = _context.Chamadas
            .Include(x => x.aluno)
            .Include(x => x.turma);
            
            if(chamada == null)
                return NotFound();
            
            return Ok(chamada);
        }
        

    }
}