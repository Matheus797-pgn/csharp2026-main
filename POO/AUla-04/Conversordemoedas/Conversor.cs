

namespace Conversordemoedas
{
    internal static class Conversor
    {
        public static double  IOF = 0.06;

        public static double Converter(double cotacao, double QTD)
        {
            return (cotacao * QTD * 0.06) + (cotacao * QTD);
        }
    }
}
