namespace abstracao.Entidades

	{
    internal abstract class Contribuintes
    {
		private string NOME;
		private double RendaAnual;


	    public string nome
		{
			get { return NOME; }
			set { NOME = value; }
		}
		public double rendaAnual
		{
			get { return RendaAnual; }
			set { RendaAnual = value; }
		}public Contribuintes(string NOME, double RendaAnual)
		{
			this.NOME = NOME;
			this.RendaAnual = RendaAnual;
		}
		//metodos	
		public abstract double Calcular();


	}

}
