using atividade_2;
using static System.Console;
try
{
    Salario s = new Salario();
    WriteLine("Digite o nome do usuario");
    s.nome = Console.ReadLine();
    WriteLine("Digite o salario do funcionario: ");
    s.SalarioBruto = double.Parse(ReadLine());
    WriteLine("Digite o valor do imposto ao salario");
    s.imposto = double.Parse(ReadLine());
    s.Dadosdoimposto();
    s.Resultadodosalario();
    WriteLine("Digite a porcentagem  do aumento do salario");
    s.AumentoporPorcentagem = double.Parse(ReadLine());
    s.Resultado();
    s.Saida();
    ReadKey();
}
catch (Exception)
{
    Write("DIGITE SOMENTE O NECESSARIO QUE ESTA PEDINDO ENTENDEU? OU QUER QUE EU DESENHE?");
}

