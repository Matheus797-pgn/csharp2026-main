

using System.Runtime.InteropServices.Marshalling;

namespace DepartamentoPessoal.classe.Entidades
{
    internal class Funcionario
    {
		private string nome;
	    private int jornada;
		private double valor;

        public Funcionario(string nomeColaborador, int jornadaColaborador, double valorHora)
        {
            NomeColaborador = nomeColaborador;
            this.jornadaColaborador = jornadaColaborador;
            ValorHora = valorHora;
        }

        protected string NomeColaborador
		{
			get { return nome; }
			set { nome = value; }
		}
		protected int jornadaColaborador
		{
			get { return jornada; }
			set { jornada = value; }
		}
		protected double ValorHora
		{
			get { return valor; }
			set { valor = value; }
		}
		//metodos
		public virtual double Pagamento()
		{
			return ValorHora * jornadaColaborador;
		}
		//metodos 
		public virtual double pagamento()
		{
			return ValorHora * jornadaColaborador;
		}
        public override string ToString()
        {
			return $"{NomeColaborador} - {pagamento():c}";
        }


	}
}
