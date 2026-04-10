using static System.Console;
using static System.ConsoleColor;
using Circuferencia2;
//entrada de dados
Write("digite o raio da circunferencia");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//criar o objeto do tipo Calculadora
Circuferencia c1 = new Circuferencia(raio);
// saida de dados
WriteLine($"Circunferecia {c1.circuferencia():F2}");
WriteLine($"Volume {c1.Volume():F2}");
WriteLine($"PI: {c1.Pi}");