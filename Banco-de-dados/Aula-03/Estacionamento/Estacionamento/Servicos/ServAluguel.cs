
namespace Estacionamento.Servicos
{
    internal class ServAluguel
    {
        private double PrecoPorDia;
        private double PrecoPorHora;
        private double TaxServBrasil;


        public double precopordia
        {
            get { return PrecoPorDia; }
            set { PrecoPorDia = value; }
        }
        public double precoporhora
        {
            get { return PrecoPorHora; }
            set { PrecoPorHora = value; }
        }
        public double taxservbrasil
        {
            get { return TaxServBrasil; }
            set { TaxServBrasil = value; }
        }
        public ServAluguel(double precopordia, double precoporhora)
        {
            this.precopordia = precopordia;
            this.precoporhora = precoporhora;
        }
        public void CalcularFatura()
            
        {
            
        }
        public void Servaluguel()
        {
            
        }


    }
}
