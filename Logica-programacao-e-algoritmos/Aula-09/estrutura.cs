using System.Reflection;
using static System.Console;
try{
int Numero_pessoas, AlturaPorPessoa;
WriteLine("Digite o numero de pessoas que vão entrar no brinquedo: ");
Numero_pessoas = int.Parse(ReadLine());
for (int i = 0; i < Numero_pessoas; i++)
{
    WriteLine($"digite a altura da pessoa {i+1}");
    WriteLine("digite a altura da pessoa que vai entrar no brinquedo: ");
AlturaPorPessoa = int.Parse(ReadLine());
if (AlturaPorPessoa < 140)
{
    WriteLine("voce é muito baixo para entrar");
}
else if (AlturaPorPessoa > 160)
{
    WriteLine("voce é muito grande para entrar");
}
else
{
    WriteLine("Voce esta na altura correta");
}
}
}
catch (Exception)
{
    Write("é pra digitar numero, não letra");
}
