using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.Calculadora;

Title = "calculadora 03";
Write("Digite o raio da circunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//saida de dados
WriteLine($"Circunferencia: {Circunferencia(raio)}");
WriteLine($"volume: {Volume(raio)}");
Write($"PI: {PI}");

