using ProjetoWeb1.Classes.Entidades;
using ProjetoWeb1.Dados;



namespace ProjetoWeb1.Classes.serv
{
    public class AlunoService
    {
        //Campo
        private readonly AlunoContext dbContext;

        //Construtor
        public AlunoService(AlunoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Tarefa
        public async Task<ResultadoCadastro> CadastrarAluno(Aluno aluno)
        {
            try
            {
                //Validação básica de cadastro
                if (string.IsNullOrWhiteSpace(aluno.Nome))
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe o nome válido de aluno"
                    };
                }
                if (aluno.RA <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "por favor, informe um RA valido"
                    };
                }
                if (aluno.cursoID <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "por favor, selecione um curso"
                    };
                }
                // definir os status padrão para novos cadastro
                aluno.StatusWIFI = "inativo";
                aluno.StatusAction = "aguardando aprovação";
                if (string.IsNullOrWhiteSpace(aluno.Email))
                {
                    aluno.Email = $"ra{aluno.RA}@aluno.local";
                }
                if (string.IsNullOrEmpty(aluno.Senha))
                {
                    aluno.Senha = aluno.RA.ToString();
                }








                //Adicionar o Aluno ao banco de dados
                dbContext.Alunos.Add(aluno);
                await dbContext.SaveChangesAsync();

                return new ResultadoCadastro
                {
                    Sucesso = true,
                    Mensagem = "Aluno cadastrado com sucesso"
                };
            }

            catch (Exception ex)
            {
                return new ResultadoCadastro
                {
                    Sucesso = false,
                    Mensagem = $"erro ao cadastrar o aluno: {ex.Message}"
                };
            }
            {

            }
        }


    }
}