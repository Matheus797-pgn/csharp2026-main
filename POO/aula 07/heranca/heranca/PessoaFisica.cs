

namespace heranca
{
    internal class PessoaFisica
    {
        //campo
        private int numero;
        private string titular;
        private double saldo;
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }

        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public PessoaFisica(int numeroConta, string titularConta, double saldoConta)
        {
            SaldoConta = saldoConta;
            TitularConta = titularConta;
            NumeroConta = 0;
        }
        public PessoaFisica(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }
        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public override string ToString()
        {
            return $"dados do cliente" + 
                $"\n\t numero da conta: {NumeroConta}" + 
                $"\n\t Titular da conta {TitularConta}" + 
                $"\n\t saldo da Conta {SaldoConta:c}";
        }
    }
}
