using static System.Console;
//declaração de variaveis
int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, alturas = 0;
try
{    
//entrada de dados
Write("Digite o numero de visitantes: ");
visitantes = int.Parse(ReadLine());
Write("digite a altura maxima: ");
altura_max = double.Parse(ReadLine());
Write("Digite a altura minima:");
altura_min = double.Parse(ReadLine());
//processamento de dados
for (int i = 0; i < visitantes; i++)
{
    Write($"digite a altura da pessoa N{i+1}:");
    alturas = int.Parse(ReadLine());
    if ((alturas >= altura_min) & (alturas <= altura_max))
    {
        contagem++;
    }
    Write($"o numero de pessoas que podem entrar no parque é de {contagem}");
}
}
catch (Exception)
{
    Write("Digite numero, Não letra");
}