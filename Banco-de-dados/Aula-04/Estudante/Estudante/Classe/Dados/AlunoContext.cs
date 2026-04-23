using Microsoft.EntityFrameworkCore;
using Estudante.Classe.Entidades;

namespace Estudante.Classe.Dados
{
    internal class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ECFP507D1319380\SQLEXPRESS;Database = AlunoDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Aluno>(entity =>
    {
        entity.HasKey(a => a.Id);        
        entity.Property(a => a.RA);
        entity.Property(a => a.Nome).IsRequired().HasMaxLength(50);
        entity.Property(a => a.Cursos).HasMaxLength(50);
    });
}

    }
}
