

namespace heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        //campos
        private double limite;

        //propriedades
        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public PessoaJuridica(string titularConta, int numeroConta, double limiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta) 
            {
                LimiteEmprestimo = limiteConta;
            } 
        // metodos
        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}
