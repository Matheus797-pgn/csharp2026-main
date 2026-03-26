
using banco;
using static System.Console;
try
{
    Title = "abertura de conta";
    Conta conta;

    WriteLine("Abertura de conta - Nika investment");
    Write("entre com um numero de conta");
    int numero = int.Parse(ReadLine());
    Write("Entre com o nome do titular ");
    string nome = ReadLine();
    Write("deseja fazer deposito (s/n)");
    char resposta = char.Parse(ReadLine().ToLower());

    if (resposta == 's')
    {
        Write("Entre com valor de deposito inicial");
        double deposito = double.Parse(ReadLine());
        conta = new Conta(numero, nome, deposito);
    }
    else
    {
        conta = new Conta(numero, nome);
    }
    conta.Dados();
    WriteLine("Entre com um valor para deposito");
    double quantia = double.Parse(ReadLine());
    conta.Deposito(quantia);
    WriteLine("Entr com um valor para saque R$");
    conta.Saque(quantia);
    ReadKey();
}
catch (Exception ex)
{
    WriteLine($"DIGITE SOMENTE O NECESSARIO MULA {ex.Message}");
}
