// usuario vai digitar o valor de 1 a 7 e esse codigo é para mostrar o dia da semana correspondete ao numero digitado pelo usuario

// declaração de variavel
using static System.Console;

int valor;
// entrada de dados
Write("Digite um numero de 1 a 7: ");
valor = int.Parse(Console.ReadLine());
if (valor == 1)
{
    WriteLine("domingo");
}
else if (valor == 2)
{
    WriteLine("segunda");
}
else if (valor == 3)
{
    WriteLine("terça");
}
else if (valor == 4)
{
    WriteLine("quarta");
}
else if (valor == 5)
{
    WriteLine("Quinta");
}
else if (valor == 6)
{
    WriteLine("sexta");
}
else if (valor == 7)
{
    WriteLine("sabado");
}
else
{
    WriteLine("numero fora do intervalo");
}