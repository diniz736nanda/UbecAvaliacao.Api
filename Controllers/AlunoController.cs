namespace AlunoController.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using UbecAvaliacao.API.Context;
    using UbecAvaliacao.API.Entities;
    using UbecAvaliacao.API.Models;

    [Route("api/aluno")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly UbecContext _context;
        public AlunoController(UbecContext context)
        {
            _context = context;
        }

        //POST api/turma/4/aluno
        [HttpPost]
        public IActionResult Post(int id, AddAlunoInputModel model)
        {

            var alunos = new Aluno(
                model.Matricula,
                model.Nome,
                model.DtNascimento
            );

            _context.Alunos.Add(alunos);
            _context.SaveChanges();

            return NoContent();
        }
    }
}