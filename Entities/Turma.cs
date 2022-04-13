using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UbecAvaliacao.API.Entities
{
    public class Turma
    {
        public Turma()
        {
        }

        public Turma(string nome, EnumTurno Turno)
        {
            Nome = nome;
            TurnosEnum = Turno;

            chamada = new List<Chamada>();
        }

        public int IdTurma { get; private set; }
        public string Nome { get; private set; }
        public  EnumTurno TurnosEnum { get; private set; }
        public List<Chamada> chamada { get; private set; }

        internal void Update( string nome, EnumTurno Turno)
        {
            throw new NotImplementedException();
        }

    }
}