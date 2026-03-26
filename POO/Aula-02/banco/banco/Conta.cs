
namespace banco
{
    internal class Conta
    {
        private int numero;
        private string titular;
        private double saldo;


        public Conta (int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;

        }
        public Conta(int numero,string titular , double saldo): this(numero, titular)
        {
            this.saldo = saldo;
        }
        
        //metodos
        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public void Saque(double quantia)
        {
            saldo -= quantia;
        }
        public void Dados()
        {
            Console.WriteLine("dados da conta cadastrada");
            Console.WriteLine($"\tTitular: {titular}\n" + $"\tNumero da conta: {numero}\n" + $"\tsaldo da conta: ${saldo}");
        }
    }
}