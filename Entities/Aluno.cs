using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UbecAvaliacao.API.Entities
{
    public class Aluno
    {
        public Aluno()
        {
        }

        public Aluno(string matricula, string nome, DateTime dtNascimento)
        {
            Matricula = matricula;
            Nome = nome;
            DtNascimento = dtNascimento;
        }

        public int IdAluno { get; private set; }
        public string Matricula { get; set; }
        public string Nome { get; private set; }
        public DateTime DtNascimento { get; private set; }

    }
}