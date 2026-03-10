using static System.Console;
double A, B, C, area, trapezio, p;
WriteLine("Bem vindo ao Laboratorio");
WriteLine("digite o valor A");
A = double.Parse(ReadLine());
WriteLine("Digite o valor B");
B = double.Parse(ReadLine());
WriteLine("Digite o valor c");
C = double.Parse(ReadLine());
if (A+B>C & A+C>B & B+C>A)
{
    p = (A+B+C)/2;
    area = Math.Sqrt(p*(p-A) * (p-B) * (p-C));
    WriteLine($"se forma triangulo vai calcular a area {area}e o perimetro {p}");
}
else
{
    trapezio = (A+B*C)/2;
    WriteLine($"se não for triangulo vai calcular a area do trapezio, a area do trapezio é {trapezio}");
}




