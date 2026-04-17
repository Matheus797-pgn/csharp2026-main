using abstracao.Contratos;

namespace abstracao.Entidades
{
    internal class PessoaFisica : Contribuintes
    {
        private double gastoSaude;

        public double GastoSaude
        {
            get { return gastoSaude; }
            set { gastoSaude = value; }
        }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude)
            : base(nome, rendaAnual)
        {
            this.gastoSaude = gastoSaude;
        }

        public override double Calcular()
        {
            double taxa;

            if (rendaAnual <= 20000)
                taxa = 0.15;
            else
                taxa = 0.25;

            double imposto = rendaAnual * taxa;

            
            imposto -= gastoSaude * 0.5;

            if (imposto < 0)
                imposto = 0;

            return imposto;
        }
    }
}