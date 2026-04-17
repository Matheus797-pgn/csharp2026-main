

namespace Estacionamento.Entidades
{
	internal class AluguelCarro
	{
		private double Fim;
		private double Inicio;
		private string Veiculo;

		public double fim
		{
			get { return Fim; }
			set { Fim = value; }
		}
		public double inicio
		{
			get { return Inicio; }
			set { Inicio = value; }
		}
		public string veiculo
		{
			get { return Veiculo; }
			set { Veiculo = value; }
		}
		public AluguelCarro(double fim, double inicio, string veiculo)
		{
			this.fim = fim;
			this.inicio = inicio;
			this.veiculo = veiculo;
		}
		public void Aluguelcarro()
		{


		}
	}
}
