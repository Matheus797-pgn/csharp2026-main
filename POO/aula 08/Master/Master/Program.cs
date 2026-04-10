using Master;
/*
Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupanca);
Console.WriteLine(Tipo.ContaPJ);
*/
Conta conta = new Conta(12345, 1500.56, new Pessoa("Cloadoaldo", 12345));
var a = conta.ToString();
Console.WriteLine(a);   
ContaPj pj = new ContaPj(54321, 500000000, new Pessoa("cesar",5342324342), 20000);
var b = pj.ToString();
Console.WriteLine(b);
Contapoupanca pp = new Contapoupanca(200000, 222.22, new Pessoa("lu", 222222222), 20);
pp.Consulta();
Console.ReadKey();
