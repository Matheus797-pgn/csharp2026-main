
namespace Estudante.Classe.Entidades
{
    internal class Aluno
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int RA { get; set; }
        public string Cursos { get; set; }
        public Aluno()
        {
        }

        public Aluno(string nome, int rA, string cursos)
        {

            Nome = nome;
            RA = rA;
            Cursos = cursos;
        }
        public void ExibirDados()
        {
            Console.WriteLine("Dados do aluno");
            Console.WriteLine($"Nome do aluno {Nome}");
            Console.WriteLine($"RA {RA}");
            Console.WriteLine($"Curso matriculado {Cursos}");

        }
    }
}

