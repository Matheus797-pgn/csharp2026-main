using static System.Console;
double a, b, c, delta, x1, x2;
// entrada de dados
WriteLine("digite o valor a: ");
a = double.Parse(ReadLine());
WriteLine("digite o b: ");
b = double.Parse(ReadLine());
WriteLine("Digite o c");
c = double.Parse(ReadLine());
//processamento de dados
delta = (b*b) - (4 * a * c);
// estrutura de controle - if//
if (delta < 0)
{
    WriteLine("raizes impossiveis");
}
else if (delta == 0)
{
    x1 = -b/ (2*a);
    x2 = x1;
    WriteLine($"x1 = {x1}\nx2 = {x2}");
}
else
{
    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    WriteLine($"x1 = {x1}\nx2 = {x2}");
}