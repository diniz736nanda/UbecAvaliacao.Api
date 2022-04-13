namespace TurmaController.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using UbecAvaliacao.API.Models;
    using UbecAvaliacao.API.Context;
    using UbecAvaliacao.API.Entities;
    using Microsoft.EntityFrameworkCore;

    [Route("api/turma")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly UbecContext _context;
        public TurmaController(UbecContext context)
        {
            _context = context;
        }
        
        // GET api/aluno/4  (PEGAR A LISTA)
        [HttpGet]
        public IActionResult GetAll()
        {
            var turmas = _context.Turmas;
            return Ok(turmas);
        }
    
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var turma = _context.Turmas
            // .Include(x => x.Alunos)
            .SingleOrDefault(x => x.IdTurma == id);
            
            if(turma == null)
                return NotFound();
            
            return Ok(turma);
        }

        // POST api/aluno  (CADASTRAR)
        [HttpPost]
        public IActionResult Post(AddTurnoInputModel model)
        {
            var turma = new Turma(
                model.Nome,
                model.Turno
            );

            _context.Turmas.Add(turma);
            _context.SaveChanges();

            return CreatedAtAction("GetById", 
            new {id = turma.IdTurma}, 
            turma);
        }

        // PUT api/aluno/4 (ALUATIZAR)
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateTurmaInputModel model)
        {
            var turma = _context.Turmas
            .SingleOrDefault(x => x.IdTurma == id);
            
            if(turma == null)
                return NotFound();

            turma.Update(model.Nome, model.Turno);
            _context.SaveChanges();

            return NoContent();
        }

    }
}