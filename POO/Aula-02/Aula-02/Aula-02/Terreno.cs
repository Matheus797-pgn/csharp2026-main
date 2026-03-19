

using System.Runtime.InteropServices;

namespace Aula_02
{
    public class Terreno
    {
        public double largura, comprimento, valor;

        //construtor
        public Terreno(double largura, double comprimento, double valor)
        {
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }

        //metodos
        public double Area()
        {
            return largura * comprimento;
        }

        public double Preco()
        {
            return Area() * valor;
        }

        public void Saida()
        {
            Console.WriteLine($"Area do terreno = {Area()}");
            Console.WriteLine($"Preco do terreno = {Preco()}");

        }

    }
}
