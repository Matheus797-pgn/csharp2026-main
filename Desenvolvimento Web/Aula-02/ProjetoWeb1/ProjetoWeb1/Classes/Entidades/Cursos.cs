namespace ProjetoWeb1.Classes.Entidades
{
    public class Cursos
    {
        private Dictionary<int, string> cursos = new Dictionary<int, string>()
        {
            {1, "Desenvolvedor Back-End" },
            {2, "Tecnico em eletroeletronica" },
            {3, "Mecanico de manutenção" }
        };
         public Dictionary<int, string> curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}
