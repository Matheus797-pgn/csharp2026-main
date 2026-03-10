using static System.Console;
try
{
int valor_A, valor_B, valor_C;
WriteLine("Digite o valor A");
valor_A = int.Parse(ReadLine());
WriteLine("Digite o valor B");
valor_B = int.Parse(ReadLine());
WriteLine("Digite o valor C");
valor_C = int.Parse(ReadLine());
// entrada de dados//
bool pergunta1 = valor_A == valor_C;
WriteLine($"o primeiro valor é igual ao terceiro valor?R {pergunta1}");
bool pergunta2 = valor_B != valor_A;
WriteLine($"O segundo valor é diferente do primeiro valor?R {pergunta2}");
bool pergunta3 = valor_B > valor_C;
WriteLine($"o segundo valor é maior que o terceiro valor?R {pergunta3}");
bool pergunta4 = valor_A <= valor_C;
WriteLine($"o primeiro valor é menor ou igual que terceiro valor?R {pergunta4}");
// segunda entrada de dados//
bool resultado = pergunta1 & pergunta3;
WriteLine($"se a 1 pergunta e pergunta 3 são verdadeiros? {resultado}");
bool resultado2 = pergunta2 | pergunta4;
WriteLine($"se a 2 pergunta e 4 pergunta pelo menos uma é verdadeira? {resultado2}");
bool resultado3 = pergunta1 & pergunta1;
WriteLine($"se a negação da primeira pergunta é verdadeira {resultado3}");
}
catch (Exception)
{
    WriteLine("ocorreu um erro, Tente novamente");
}


