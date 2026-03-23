



namespace Atividade_3
{
    internal class Notas
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string nome;
        public string NotaFinal;
        public double resultado;

        public void notas()
        {
            Console.WriteLine($"Nome do estudante {nome}");
            Console.WriteLine($"Nota 1 {Nota1}");
            Console.WriteLine($"Nota 2{Nota2}");
            Console.WriteLine($"Nota 3{Nota3}");
        }
        public double Result()
        {
            return resultado = Nota1 + Nota2 + Nota3;
        }
        public void Saidas()
        {
            if (resultado < 60)
            {
                Console.WriteLine("REPROVADO");

            }
            else if (resultado >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            
        }
    }
}
