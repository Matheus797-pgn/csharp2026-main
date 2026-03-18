using retangulo;
using static System.Console;
try
{
    Retangulo1 x = new Retangulo1();
    Retangulo1 y = new Retangulo1();
    WriteLine("digite o valor da altura do retangulo 1");
    x.altura = double.Parse(ReadLine());
    WriteLine("digite o valor da largura do retangulo 1");
    x.largura = double.Parse(ReadLine());

    WriteLine($"a area do retangulo 1 é {x.Area()}");
    WriteLine($"o perimetro do retangulo 1 é {x.perimetro()}");
    WriteLine($" a diagonal do retangulo 1 é {x.Diagonal()}");

    WriteLine("DIGITE O SEGUNDO RETANGULO, GO");
    WriteLine("digite a altura do retangulo 2");
    y.altura = double.Parse(ReadLine());
    WriteLine("digite a largura do retangulo 2");
    y.largura = double.Parse(ReadLine());

    WriteLine($"a area do retangulo 2 é {y.Area()}");
    WriteLine($"o perimetro do retangulo 2 é {y.perimetro()}");
    WriteLine($" a diagonal do retangulo 2 é {y.Diagonal()}");

    ReadKey();
}
catch (Exception)
{
    WriteLine("Digite SÓ NUMERO ENTENDEU?, OU PRECISA DESENHAR? ");
}