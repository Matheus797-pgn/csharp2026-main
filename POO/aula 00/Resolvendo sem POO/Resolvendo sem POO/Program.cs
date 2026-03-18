// entrada de dados
using static System.Console;
WriteLine("Digite a medida dos triangulo X");
WriteLine("Digite o valor de a: ");
double ax = double.Parse(ReadLine());
WriteLine("Digite o valor de b");
double bx = double.Parse(ReadLine());
WriteLine("Digite o valor de c: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite a medida dos triangulo y");
WriteLine("Digite o valor de a: ");
double ay = double.Parse(ReadLine());
WriteLine("Digite o valor de b");
double by = double.Parse(ReadLine());
WriteLine("Digite o valor de c: ");
double cy = double.Parse(ReadLine());
//processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cx));
//saida de dados
WriteLine($"a area do triangulo x é de {areax:F2}");
WriteLine($"a area do triangulo y é de {areay:F2}");
if (areax > areay)
{
    WriteLine("maior area pertence a area X");

}
else if(areay > areax)
{
    WriteLine("a area maior pentence a area Y");

    ReadKey();
}
