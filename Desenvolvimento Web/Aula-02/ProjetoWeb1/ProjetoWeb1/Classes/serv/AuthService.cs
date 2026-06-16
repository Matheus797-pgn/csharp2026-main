using Microsoft.EntityFrameworkCore;
using ProjetoWeb1.Classes.Entidades;
using ProjetoWeb1.Dados;

namespace ProjetoWeb1.Classes.serv
{
    public class AuthService
    {
        private readonly AlunoContext dbContext;
        public AuthService(AlunoContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<Aluno?> ValidarLoginAsync(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                return null;
            }

            var aluno = await dbContext.Alunos.FirstOrDefaultAsync(a => a.Email == email && a.Senha == senha);

            return aluno;

        }
    }

}