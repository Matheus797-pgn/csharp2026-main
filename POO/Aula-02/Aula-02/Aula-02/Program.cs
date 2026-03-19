
using Aula_02;
using static System.Console;
using static Aula_02.Terreno;
try
{
   
    Write("Digite a largura do terreno");
    double largura = double.Parse(ReadLine());
    Write("digite o comprimento do terreno");
    double comprimento = double.Parse(ReadLine());
    Write("digite o valor por metro quadrado");
    double valor = double.Parse(ReadLine());

    Terreno t = new Terreno(largura, comprimento, valor);
    t.Saida();
    ReadKey();
}
catch (Exception)
{
    Write("DIGITE SOMENTE AS MEDIDAS ENTENDEU? OU QUER QUE EU DESENHE?");
}
