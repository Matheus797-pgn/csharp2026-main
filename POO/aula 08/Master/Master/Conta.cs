
namespace Master
{
    internal class Conta : IOperacao
    {
        private Pessoa cliente;
        private int numero;
        private double saldo;


        //propriedades
        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Pessoa DadosCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }

                void IOperacao.Deposito(double qtd)
        {
            throw new NotImplementedException();
        }

        void IOperacao.saque(double qtd)
        {
            throw new NotImplementedException();
        }
        public void saque(double qtd)
        {
            SaldoConta -= qtd;

        }
        public override string ToString()
        {
            return $"Dados da conta - {Tipo.ContaNormal} " +
                $"\n \t Nome do titular:{cliente.nome}" +
                $"\n \t CPF do titular {cliente.CPF}" + $"\n \t Numero da conta {numero}" + $"\n \t Saldo da conta: {saldo}";
        }
    }
}
