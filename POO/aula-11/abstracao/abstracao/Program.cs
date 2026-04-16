using abstracao.Entidades;
using abstracao.Contratos;
using static System.Console;
List<Contribuintes> N = new();
Write("BEM VINDO AO BANCO DE CALCULO DE IMPOSTO");
Write("Qual conta voce quer iniciar? (J/F)");
char escolha = char.Parse(ReadLine());
for (int i = 0; i < 3; i++)
{

    if (escolha == 'j')
    {
        WriteLine("Bem vindo à conta Jurídica");

        Write("Digite o nome da empresa: ");
        string nome = ReadLine();

        Write("Digite a renda anual: ");
        double renda = double.Parse(ReadLine());

        Write("Número de funcionários: ");
        int funcionarios = int.Parse(ReadLine());

        PessoaJuridica pj = new PessoaJuridica(nome, renda, funcionarios);
        N.Add(pj);
    }
    else if (escolha == 'F')
    {
        WriteLine("Bem vindo à conta Física");

        Write("Digite o nome: ");
        string NOME = ReadLine();

        Write("Digite a renda anual: ");
        double rendaAnual = double.Parse(ReadLine());

        Write("Gastos com saúde: ");
        double gastosaude = double.Parse(ReadLine());
        PessoaFisica pf = new PessoaFisica(N.ToArray(), gastosaude);
        N.Add(pf);

    }
    else
    {
        WriteLine("opção invalida");
    }
}

    








