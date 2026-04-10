using static System.Console;
using heranca;
PessoaFisica cesar = new PessoaFisica(12345, "Cesar");
PessoaFisica senai = new PessoaJuridica(54321, "Skaf", 12000, 00);

Console.WriteLine(cesar); // imprimir somente o obj
Console.WriteLine(senai.ToString());// imprimir e converter o obj/ p/string