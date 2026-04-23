using Estudante.Classe.Dados;
using Estudante.Classe.Entidades;
using Microsoft.EntityFrameworkCore;

using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Clodoaldo", 12345, "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges(); 


