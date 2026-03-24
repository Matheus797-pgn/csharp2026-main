using static System.Console;
using static System.ConsoleColor;
Title = "calculadora 01";
double raio, circunferencia, volume;
const double PI = 3.14;

// entrada de dados
Write("entre com o valor do raio da circuferencia");
raio = double.Parse(ReadLine());
ResetColor();

//saida de dados
WriteLine($"Circuferencia: {Circuferencia(raio):.F2}");
WriteLine($"Volume: {Volume(raio):.F2}");
WriteLine($"PI: {PI}");
// calculo da circuferencia
double Circuferencia(double r)
{
    return 2 * PI * r;
}
double Volume(double r)
{
    return (4 / 3) * PI * r;
}

