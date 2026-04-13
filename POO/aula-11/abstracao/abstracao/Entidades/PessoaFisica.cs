using abstracao.Contratos;

namespace abstracao.Entidades
{
    internal class PessoaFisica : Contribuintes
    {
		private double ImpostoPF;
		private double gastosaude;

		public double impostopf
		{
			get { return ImpostoPF; }
			set { ImpostoPF = value; }
		}
		public double GastoSaude
		{
			get { return gastosaude; }
			set { gastosaude = value - 0.50; }
		}
		
		public static double CalculoImpostofisico(double impostopf, double gastosaude)
		{
			
			_ = gastosaude;

			if (impostopf <= 20000)
			{
				double valorimpostoPF = impostopf * 0.15;
				double valorUltimato = valorimpostoPF - impostopf;
				return valorUltimato;
			}
            else
            {
				double valorimpostoPF = impostopf * 0.25;
				double valorUltimato = valorimpostoPF - impostopf;
				return valorUltimato;
            }
        }

								
		public PessoaFisica(string nome, double rendaAnual, double impostopf, double gastoSaude)
			: base(nome, rendaAnual)
		{
			this.impostopf = impostopf;
			this.GastoSaude = gastoSaude;
		}
				
		public override double Calcular()
		{
			return CalculoImpostofisico(impostopf, GastoSaude);
		}
	}
}
