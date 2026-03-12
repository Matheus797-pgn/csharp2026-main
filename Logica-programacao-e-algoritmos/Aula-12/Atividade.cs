using static System.Console;
try{
Dictionary<int, double> produto = new Dictionary<int, double>()
{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32}
};

Write("Digite o codigo do produto: ");
int codigo = int.Parse(ReadLine());
Write("Digite a quantidade:");
int quantidade = int.Parse(ReadLine());
double valor = produto[codigo] * quantidade;
Write($"o valor é {valor}");
}
catch (Exception ex)
{
    WriteLine("ocorreu um erro, digite somente o codigo do produto desejado");
}

