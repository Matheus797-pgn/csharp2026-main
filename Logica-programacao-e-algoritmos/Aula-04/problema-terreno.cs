
using static System.Console;
double largura, comprimento, valor, area, preco;
//entrada de dados
Console.WriteLine("digite a largura");
largura = double.Parse(ReadLine());
Console.WriteLine("digite o comprimento");
comprimento = double.Parse(ReadLine());
Console.WriteLine("digite o valor");
valor = double.Parse(ReadLine());
//processamento de dados
area = largura * comprimento;
preco = area * valor;
// saida de dados
Console.WriteLine($"a area do terreno é de {area} e o preco do terreno é de R${preco}");
