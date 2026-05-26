using ProjetoWeb1.Classes.Enumeracoes;

namespace ProjetoWeb1.Classes.Entidades
{
    public class Admin : Usuario
    {
        public TipoRegra Regra { get; set; } = TipoRegra.Admin;
    }
}
