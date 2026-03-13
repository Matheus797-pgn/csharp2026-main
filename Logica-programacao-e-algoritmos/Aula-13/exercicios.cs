using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;
using static System.Console;
try{
Write("digite o valor da matriz em N: ");
int N = int.Parse(ReadLine());
if (N > 10)
{
    Write("a matriz ultrapassou o limite de 10x10");
}
else if (N < 10)
{
    Write("a matriz é menor que 10x10");
}
else
{
    Write("a matriz esta perfeita");
}
int [,] matriz = new int[N,N];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Write($"digite o valor para a posição [{i},{j}]:");
        matriz[i,j] = int.Parse(ReadLine());

    }
}
Write("matriz preenchida: ");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Write(matriz[i,j] + "\t");
    }
    WriteLine();
}
}
catch (Exception ex)
{
    Write("é pra digitar o tamanho da matriz, Não letra");
}


