

namespace Circuferencia2
{
    internal class Circuferencia
    {
        // campo
        public const double PI = 3.14;
        public double raio;

        public Circuferencia (double raio)
        {
            this.raio = raio;

        }
         //metodos
         public double circuferencia()
        {
            return 2 * PI * raio;
        }
        public double Volume()
        {
            return (4 / 3) * PI * Math.Pow(raio, 3);
        }
        public string Pi()
        {
            return ($"{PI}");
        }
    }
}
