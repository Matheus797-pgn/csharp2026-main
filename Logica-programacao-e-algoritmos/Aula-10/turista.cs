using static System.Console;
int entrada1, saida3, Turista_saida, Turista_entrada, saida1, saida2;
while (true) {
Write("O que voce deseja fazer? (entrada/sair) ");
string fluxo = ReadLine();
if (fluxo == "entrada")
    {
        Write("bem vindo ao sistema)");
    }
else if (fluxo == "sair")
    {
        Write("Saindo do sistema...");
        break;}
Write("Digite o numero de carros que vai entrar: ");
entrada1 = int.Parse(ReadLine());
Write("Digite o numero de pessoas que entraram");
Turista_entrada = int.Parse(ReadLine());
    Write($"o total de carros dentro do parque é {entrada1} o total de turista dentro do carro é de  {Turista_entrada} ");
    Write("Quanto carros sairam do parque? ");
    saida3 = int. Parse(ReadLine());
    Write("Quantas pessoas sairam do parque? ");
    Turista_saida = int.Parse(ReadLine());
    saida1 = entrada1 - saida3;
    Write($"faltou sair {saida1} carro do parque ");
    saida2 = Turista_entrada - Turista_saida;
    Write($"faltou sair {saida2} pessoas do parque ");
   
//}
    }







