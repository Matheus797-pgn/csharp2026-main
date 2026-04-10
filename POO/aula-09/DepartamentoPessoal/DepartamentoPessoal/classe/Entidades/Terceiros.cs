
namespace DepartamentoPessoal.classe.Entidades
{
    internal class Terceiros : Funcionario
    {
		private double Despesa;


        public double DespesaAdcional
		{
			get { return Despesa; }
			set { Despesa = value; }
		}
        // construtor
        public Terceiros(string nomeColaborador, int jornadaColaborador, double valorHora, double Despesa)
            : base(nomeColaborador, jornadaColaborador, valorHora)
        {
            DespesaAdcional = Despesa;
        }
        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdcional * 0.2);
        }
	}
}
