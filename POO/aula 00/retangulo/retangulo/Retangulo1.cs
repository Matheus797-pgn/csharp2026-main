

namespace retangulo
{
    internal class Retangulo1
    {
        public double altura;
        public double largura;

        public double Area()
        {
             double Area = largura * altura;
            return Area;
        }
        
        public double perimetro()
        {
            double perimetro = 2 * largura + altura;
            return perimetro;
        }
        public double Diagonal()
        {
            double Diagonal = (Math.Sqrt(largura * largura) + (altura * altura));
            return Diagonal;
        }
    }
    
}
