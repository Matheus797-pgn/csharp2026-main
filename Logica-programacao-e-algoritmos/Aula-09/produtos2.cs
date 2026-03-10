using static System.Console;
static void Total(int qtd, double valor)
{
    WriteLine($"o valor total é de {qtd * valor}");
}



// declaração de variaveis
int codigo, quantidade;
try{
//entrada de dados//
Write("Digite o codigo do produto");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade de produto");
quantidade = int.Parse(ReadLine());
switch (codigo)
{
    case 1:
    Total(quantidade, 5.00);
    break;
    case 2:
    Total(quantidade, 4.50);
 break;
    case 3:
    Total(quantidade, 3.75);
    break;
    case 4:
    Total(quantidade, 8.99);
    break;
    case 5:
    Total(quantidade, 11.33);
    break;
    default: //comtempla todos os valores que estão dentro do case, Caso o usuario digitar 1 valor que não esteja dentro do case ele vai dar a mensagem que estiver escrito dentro do WriteLine.
    WriteLine("Codigo do produto não cadastrado");
    break;
    }
}
catch (Exception ex)
{
    WriteLine($"Digite valores validos, erro:{ex.Message}");
} 