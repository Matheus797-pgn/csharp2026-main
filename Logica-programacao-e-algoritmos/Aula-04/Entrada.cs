//entrada de dados
using System.reflection;
using System.Runtime.CompilerServices;

Console.WriteLine("Digite um numero:");
string nome = Console.ReadLine();//Entrada de dados
System.Console.WriteLine($"o valor digitado é de {nome}");
System.Console.WriteLine($"digite o 1 primeiro numero: ");
double x = double.Parse(Console.ReadLine());
System.Console.WriteLine("digite o 2 numero: ");
double y = double.Parse(Console.ReadLine());
double soma = x + y;
System.Console.WriteLine($"a soma dos dois valores é de {soma}");