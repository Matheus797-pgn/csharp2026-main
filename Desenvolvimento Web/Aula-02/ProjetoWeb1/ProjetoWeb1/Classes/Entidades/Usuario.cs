using ProjetoWeb1.Classes.Enumeracoes;

namespace ProjetoWeb1.Classes.Entidades
{
    public class Usuario
    {
        // id, nome, Email, Senha, Regras

        public  int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public TipoRegra Regra { get; set; }
    }
}
