using ExemploComPOO;

using ExemploComPOO;
    using static System.Console;
    Triangulo x = new Triangulo();
    Triangulo y = new Triangulo();
WriteLine("Digite as medidas do triangulo x");
Write("Digite a medida A");
x.ladoA = double.Parse(ReadLine());
Write("digite a medida B");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida C");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite as medidas do triangulo y");
Write("Digite a medida A");
y.ladoA = double.Parse(ReadLine());
Write("digite a medida B");
y.ladoB = double.Parse(ReadLine());
Write("Digite a medida C");
y.ladoC = double.Parse(ReadLine());

// saida de dados
WriteLine($"a area do triangulo x é de {x.Area}");
WriteLine($"a area do triangulo y é de {y.Area}");
ReadKey();