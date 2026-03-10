using System.Reflection;
using System.Text;
using static System.Console;

// declaração de variaveis
int codigo, quantidade;
//entrada de dados//
Write("Digite o codigo do produto");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade de produto");
codigo = int.Parse(ReadLine());
switch (codigo)
{
    case 1:
    WriteLine($"o valor total é de {quantidade * 5.00}");
    break;
    case 2:
    WriteLine($"o valor total é de {quantidade * 4.50}");
    break;
    case 3:
    WriteLine($"o valor é de {quantidade * 3.75}");
    break;
    case 4:
    WriteLine($"o valor total é de {quantidade * 8.99}");
    break;
    case 5:
    WriteLine($"o valor total é de {quantidade * 11.33}");
    break;
}