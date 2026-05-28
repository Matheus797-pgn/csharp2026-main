using ProjetoWeb1.Classes.Enumeracoes;

namespace ProjetoWeb1.Classes.Entidades
{
    public class Aluno : Usuario
    {
        public int RA { get; set; }
        public string StatusWIFI { get; set; } = "inativo";

        public string StatusAction { get; set; } = "aguardando aprovação";

        public int cursoID { get; set; }

        public TipoRegra Regra { get; set; } = TipoRegra.Usuario;
    }
}
