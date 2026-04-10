

namespace Master
{
    internal class Contapoupanca : Conta
    {
		private double rendimento;


        public double RendimentoConta
		{
			get { return rendimento; }
			set { rendimento = value; }
		}
		//construtor
        public Contapoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente, double rendimento) : base(numeroConta, saldoConta, dadosCliente)
        {
			RendimentoConta = rendimento;
        }
		//metodos
		public void Consulta()
		{
			Console.WriteLine($"Dados do cliente: \n" + $"\tNome {DadosCliente.nome}\n"+$"\t CPF: {DadosCliente.CPF}\n" + $"\tNumero: {NumeroConta}\n" + $"\tSaldo: {SaldoConta}"
				+$"\n \tRendimento: {rendimento}%");

		}


	}
}
