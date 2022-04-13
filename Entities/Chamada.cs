using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UbecAvaliacao.API.Entities
{
    public class Chamada
    {
         public Chamada( bool stPresenca)
        {
            // int idTurma, int idAluno, DateTime dtChamada,
            // IdTurma = idTurma;
            // IdAluno = idAluno;
            // DtChamada = dtChamada;
            StPresenca = stPresenca;

            turma = new Turma();
            aluno = new Aluno();

        }

        public int IdTurma { get; private set; }    
        public Turma turma { get; set; }
        public int IdAluno { get; private set; }   
        public Aluno aluno { get; set; }       
         
        public DateTime DtChamada { get; private set; } 
        public bool StPresenca { get; private set; }
    }
}