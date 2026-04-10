using DepartamentoPessoal.classe.Entidades;
using static System.Console;
List<Funcionario> colaboradores = new();

Write("Quantos funcionarios ira cadastrar: ");
int n = int.Parse(ReadLine());
for(int i = 0; i < n; i++)
{
    WriteLine($"colaborador N {i + 1}");
    WriteLine("o funcionario é terceirizado (s/n)");
    char e = char.Parse(ReadLine().ToLower());
    if (e == 'n')
    {
        Write("nome : ");
        string nome = ReadLine();
        Write("Horas trabalhadas");
        int h = int.Parse(ReadLine());
        Write("valor da hora");
        double v = double.Parse(ReadLine());
        colaboradores.Add(new Funcionario(nome, h, v));
    }
    else
    {
        Write("nome : ");
        string nome = ReadLine();
        Write("Horas trabalhadas");
        int h = int.Parse(ReadLine());
        Write("valor da hora");
        double v = double.Parse(ReadLine());
        Write("Despesas adicional R$");
        double d = double.Parse(ReadLine());
        colaboradores.Add(new Terceiros(nome, h, v, d));
    }
    

}
WriteLine("pagamento");
foreach (var colab in colaboradores)
{
    WriteLine(colab.ToString());
}