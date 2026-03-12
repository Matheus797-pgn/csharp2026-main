using static System.Console;
// declaração de variavel
int n;
List<double> numeros = new List<double>();
// entrada de dados
Write("quantos numeros voce vai digitar? ");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write("digite 1 numero: ");
    numeros.Add(double.Parse(ReadLine()));
}
    Write("valores = ");

for (int i = 0; i < n; i++)
{
    Write($"{numeros[i]}");
}
WriteLine($"Soma= {numeros.Sum()}");

Write($"media = {numeros.Average()}");