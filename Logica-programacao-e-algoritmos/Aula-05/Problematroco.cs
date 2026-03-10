using static System.Console;
double Precounitario, Quantidade, Dinheirorecebido, troco;
WriteLine("preco do produto é");
Precounitario = double.Parse(ReadLine());
WriteLine("a quantidade é");
Quantidade = double.Parse(ReadLine());
WriteLine("O dinheiro recebido é");
Dinheirorecebido = double.Parse(ReadLine());
//processamento de dados
troco = Dinheirorecebido-(Precounitario*Quantidade);
// saida de dados
WriteLine($"o seu troco é {troco}");