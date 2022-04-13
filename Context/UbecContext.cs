using Microsoft.EntityFrameworkCore;
using UbecAvaliacao.API.Entities;

namespace UbecAvaliacao.API.Context
{
    public class UbecContext : DbContext 
    {
        public UbecContext(DbContextOptions<UbecContext> options) : base (options)
        {
            
            // Alunos = new List<Aluno>();
            // Turmas = new List<Turma>();
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Chamada> Chamadas { get; set; }
        
        

        protected override void OnModelCreating(ModelBuilder builder) {  
            
            builder.Entity<Turma>(x =>  {   
            x.HasKey(i => i.IdTurma);
            // x.ToTable("tb_Alunos");

            // x.HasMany(y => y.Alunos)
            //     .WithOne()
            //     .HasForeignKey(xy => xy.IdAluno )
            //     .OnDelete(DeleteBehavior.Restrict);
            });
            
            builder.Entity<Aluno>(x => {
                x.HasKey(i => i.IdAluno);
                
            });

            builder.Entity<Chamada>(x => {
                x.HasKey(i => new {i.IdAluno, i.IdTurma, i.DtChamada});

            });
        } 
    }
}