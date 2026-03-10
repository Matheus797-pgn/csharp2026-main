using static System.Console;
double nota1, nota2, resultado;
WriteLine("Digite a nota 1: ");
nota1 = double.Parse(ReadLine());
WriteLine("digite a nota 2: ");
nota2 = double.Parse(ReadLine());
resultado = nota1 + nota2;
if (resultado >= 60)
{
    WriteLine($"a sua nota final foi {resultado}");
    WriteLine("aprovado");
}
else
{
    WriteLine($"sua nota foi final foi {resultado:F2}");
    WriteLine("reprovado");
}