using static System.Console;
double resultado = 1;
//entrada de dados//
WriteLine("Digite um numero");
int entrada = int.Parse(Console.ReadLine());
//processamento de dados//
if (entrada > 0)
{
    resultado = 2 + entrada;
}
// saida de dados
System.Console.WriteLine($"o resultado é {resultado}");