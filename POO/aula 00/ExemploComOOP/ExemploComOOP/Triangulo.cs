
namespace ExemploComPOO
{
    internal class Triangulo
    {
        //campos ou atributos
       public double ladoA;
       public double ladoB;
       public double ladoC;

        // metodo
        public double Area()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return area;
        }
    }
}
