using abstracao.Entidades;
using abstracao.Contratos;
using static System.Console;
try
{
    List<Contribuintes> N = new();

    WriteLine("BEM VINDO AO BANCO DE CALCULO DE IMPOSTO");
    Write("Qual conta voce quer iniciar? (J/F): ");
    char escolha = char.ToUpper(char.Parse(ReadLine()));

    int escolhaTipoDeConta = escolha switch
    {
        'J' => 1,
        'F' => 2,
        _ => 0
    };

    switch (escolhaTipoDeConta)
    {
        case 1:
            WriteLine("BEM VINDO A CONTA DA PESSOA JURIDICA");
            break;
        case 2:
            WriteLine("BEM VINDO A CONTA DA PESSOA FISICA");
            break;
        default:
            WriteLine("Opção inválida");
            break;
    }

    if (escolha == 'J')
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
        string nome = ReadLine();

        Write("Digite a renda anual: ");
        double rendaAnual = double.Parse(ReadLine());

        Write("Gastos com saúde: ");
        double gastosaude = double.Parse(ReadLine());

        PessoaFisica pf = new PessoaFisica(nome, rendaAnual, gastosaude);
        N.Add(pf);
    }
    else
    {
        WriteLine("opção invalida");
    }


    WriteLine();
    WriteLine("=== DADOS DOS CONTRIBUINTES ===");

    foreach (Contribuintes c in N)
    {
        WriteLine($"Nome: {c.nome}");
        WriteLine($"Renda anual: {c.rendaAnual}");
        WriteLine($"Imposto: {c.Calcular()}");
        WriteLine("----------------------------");
    }
}
catch(Exception)
{
    WriteLine("Escolha somente as opção pedidas (J/F)");
}






