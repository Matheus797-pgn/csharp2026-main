using static System.Console;
double Base, altura, area, perimetro, diagonal;
Console.WriteLine("Digite a Base do retangulo ");
Base = double.Parse(ReadLine());
Console.WriteLine("Digite a altura do retangulo");
altura = double.Parse(ReadLine());
// processamento de dados
area = Base * altura;
perimetro = 2*Base + 2*altura;
diagonal = Math.Sqrt((Base*Base)+(altura*altura));
// saida de dados
Console.WriteLine($"A area é igual a {area} perimetro é igual a {perimetro} diagonal é igual a {diagonal}");