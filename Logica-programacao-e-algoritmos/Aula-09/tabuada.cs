// declaração de variavel
using static System.Console;

//decalração de variavel
int numero;
// entrada de dados
WriteLine("digite o numero entre 0 e 10");
numero = int.Parse(ReadLine());
//processamento de dados
for (int i = 0; i < 99999999999999999; i++)
{
    //saida de dados
    WriteLine($"{numero} x {i+1} = {numero * (i+1)}");
}