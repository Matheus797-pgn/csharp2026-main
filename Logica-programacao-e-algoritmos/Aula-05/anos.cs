using static System.Console;
int dias;
Console.WriteLine("Digite o numero de dias:");
dias = int.Parse(ReadLine());
//saida de dados
int ano = dias/365;
int mes = dias%365/30;
dias = dias%365%30;
// saida de dados
Console.WriteLine($"a quantidade de anos é {ano} e meses é {mes} e dias restantes de vida é {dias}");
