

namespace abstracao.Contratos
{
    internal class Impostos
    {
		private double ImpostoPF;
		private double ImpostoPJ;


		public double impostopf
		{
			get { return ImpostoPF; }
			set { ImpostoPF = value; }
		}
		public double impostopj
		{
			get { return ImpostoPJ; }
			set { ImpostoPJ = value; }
		}
	
		public Impostos(int  impostopf, int impostopj)
		{
			this.impostopf = impostopf;
			this.impostopf = impostopj;
		}
	    
		
		}
		
	}


