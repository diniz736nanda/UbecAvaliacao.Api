
using UbecAvaliacao.API.Entities;

namespace UbecAvaliacao.API.Models
{
    public record AddTurnoInputModel(
        string Nome, 
        EnumTurno Turno
        )
    {
        
    }
}