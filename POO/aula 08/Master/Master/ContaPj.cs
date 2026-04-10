

namespace Master
{
    internal class ContaPj : Conta
    {
        private double limite;
        public double LimiteConta
        {
            get { return limite; }
            set { limite = value; }
        }
        //construtor
        public ContaPj(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }
        //metodos
        public void Emprestimo(double quantia)
        {
            LimiteConta -= quantia;
            SaldoConta += quantia;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n \t Limite conta {limite:c}";
        }

    }
}
