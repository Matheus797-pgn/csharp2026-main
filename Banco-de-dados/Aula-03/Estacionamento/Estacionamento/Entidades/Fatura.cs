

namespace Estacionamento.Entidades
{
    internal class Fatura
    {
        private double PagamentoBasico;
        private double Taxa;
        private double TotalPagamento;


        public double pagamentobasico
        {
            get { return PagamentoBasico; }
            set { PagamentoBasico = value; }
        }

        public double taxa
        {
            get { return Taxa; }
            set { Taxa = value; }
        }

        public double totalpagamento
        {
            get { return TotalPagamento; }
            set { TotalPagamento = value; }
        }
        public Fatura(double pagamentobasico, double taxa, double totalpagamento)
        {
            this.pagamentobasico = pagamentobasico;
            this.taxa = taxa;
            this.totalpagamento = totalpagamento;
        }
        public override string ToString()
        {
            return "Pagamento básico: "
                + PagamentoBasico
                + "\nTaxa: "
                + Taxa
                + "\nTotal: "
                + TotalPagamento;
        }

    }
}

        


