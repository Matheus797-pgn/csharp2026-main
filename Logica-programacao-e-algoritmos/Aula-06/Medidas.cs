using static System.Console;
try{
    double a, b, c, areaquadrado, areatriangulo, areatrapezio;
    // entrada de dados//
    WriteLine("Digite a medida a medida A:");
    a = double.Parse(ReadLine());
    WriteLine("Digite a medida b: ");
    b = double.Parse(ReadLine());
    WriteLine("Digite a medida C:");
    c = double.Parse(ReadLine());
    // processamento de dados//
    areaquadrado = a*a;
    areatriangulo = (a*b)/2;
    areatrapezio = ((a+b)*c)/2;
    //saida de dados//
    WriteLine($"area do quadrado = {areaquadrado:F4}");
    WriteLine($"Area do triangulo = {areatriangulo:F4}");
    WriteLine($"Area do trapezio = {areatrapezio:F4}");
}
catch(Exception)
{
    WriteLine("Valores invalidos inseridos, Programa encerrado!");
}