

namespace atividade_2
{
    internal class Salario
    {
        public string nome;
        public double SalarioBruto;
        public double SalarioLiquido;
        public double AumentoporPorcentagem;
        public double dados;
        public double imposto;

        public double Dadosdoimposto()
        {
            return SalarioLiquido = SalarioBruto - imposto;

        }
        public void Resultadodosalario()
        {
           Console.WriteLine($"Dados do funcionario");
           Console.WriteLine($" nome do funcionario {nome}");
           Console.WriteLine($"Salario liquido {SalarioLiquido}");
        }

        public double Resultado()
        {
            AumentoporPorcentagem = AumentoporPorcentagem * 0.01;
            return dados = SalarioLiquido * AumentoporPorcentagem;
            

        }
        public void Saida()
        {
            Console.WriteLine($"Dados atualizados");
            Console.WriteLine($"nome do funcionario {nome}");
            Console.WriteLine($"salario atualizado {SalarioLiquido + dados}");
        }
    }
}
