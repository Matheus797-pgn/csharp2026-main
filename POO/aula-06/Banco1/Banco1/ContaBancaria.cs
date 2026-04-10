

namespace Banco1
{
    internal class ContaBancaria
    {
        // campos
        private int numero;
        private string titular;
        private double saldo;
       
        public int Numero
        {
            get { return numero; }
            set { numero = value; }

        }
         public string Titular
        {
            get { return titular; }
            set { titular = value; }

        }
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0)
                {
                    saldo = value;
                }
                else
                {
                    saldo = 0;
                }

            }
        }
       
             //construtor
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            saldo = 0;
        }
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
        public void deposito(double quantia)
        {
            saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }
        public void Saida()
        {
            Console.WriteLine($" o numero da conta é {numero}");
            Console.WriteLine($"O nome do usuario é {Titular}");
            Console.WriteLine($"O saldo da sua conta é {saldo:C}");
        }
    }
}
