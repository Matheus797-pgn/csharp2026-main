using static System.Console;
using static System.Linq.Enumerable;
//entrada de dados
int n;
//entrada de dados
Write("quantos numeros voce vai digitar");
n = int.Parse(ReadLine());
if (n < 0)
{
    Write("valor invalido, Digite valores positivos");
}
else if (n > 10)
{
    Write("maximo de valores para digitar igual a 10");
    Write("tente novamente");
}
else
{
    //declaração do vetor
    int [] numeros = new int [n];
    for (int i = 0; i<numeros.Length; i++)
    {
        Write($"digite o {i+1} numero");
        numeros [i] = int.Parse(ReadLine());
    }
    Write("NUMEROS NEGATIVOS");
    foreach (int item in Range(0, numeros.Length))
    {
        if (numeros[item]<0){
            Write(numeros[item]);
        }
    }
}