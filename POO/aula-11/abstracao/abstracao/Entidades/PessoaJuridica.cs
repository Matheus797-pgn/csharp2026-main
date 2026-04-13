using abstracao.Contratos;
namespace abstracao.Entidades
{
    internal class PessoaJuridica : Contribuintes
    {
		
		private double impostoPJ;
		private int Funcionarios;

		public double impostopj
		{
			get { return impostoPJ; }
			set { impostoPJ = value; }
		}
		public int funcionarios
		{
			get { return Funcionarios; }
			set { Funcionarios = value; }
		}
					

		public double CalculoDeFuncionario(double impostoPJ)
		{
			if (Funcionarios <= 10)
			{
				impostopj = impostoPJ * 0.16;
			}
			else
			{
				impostopj = impostoPJ * 0.14;
			}

			return impostopj;
		}

		public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
		{
			this.funcionarios = funcionarios;
		}

		
		public override double Calcular()
		{
			
			return CalculoDeFuncionario(rendaAnual);
		}

	}
}
