using static System.Console;
using static System.ConsoleColor;
using  static Conversordemoedas.Conversor;

// entrada de dados
WriteLine("qual é a cotação do dolar?");
double cotacao = double.Parse(ReadLine());
ForegroundColor = Red;
WriteLine("Quantos dolares voce vai comprar?");
double QTD = double.Parse(ReadLine());
ResetColor();
WriteLine($"O valor a ser pago em reais é: {Converter( cotacao,  QTD)}");

