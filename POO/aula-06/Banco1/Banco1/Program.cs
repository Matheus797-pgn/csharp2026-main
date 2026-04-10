using static System.Console;
using  Banco1;
Title = "cadastro de conta";
ContaBancaria conta;
try
{
    //entrada de dados
    Write("entre com o numero da conta: ");
    int n = int.Parse(ReadLine());
    Write("entre com o nome do titular da conta");
    string nome = ReadLine();
    Write("deseja fazer 1 deposito inicial? (s/n)");
    char resposta = char.Parse(ReadLine().ToLower());
    if (resposta == 's')
    {
        Write("entre om o valor de deposito inicial");
        double dep = double.Parse(ReadLine());
        conta = new ContaBancaria(n, nome, dep);

    }
    else
    {
        conta = new(n, nome);
    }
    conta.Saida();
    ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"ESCREVA SÓ O DESEJADO{ex.Message} ");
}