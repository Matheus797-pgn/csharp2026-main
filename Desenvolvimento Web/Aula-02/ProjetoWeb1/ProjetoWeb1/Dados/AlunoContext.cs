using Microsoft.EntityFrameworkCore;
using ProjetoWeb1.Classes.Entidades;
namespace ProjetoWeb1.Dados


{
    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
     
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    } 
}
