using System.ComponentModel.DataAnnotations;
namespace ProjetoWeb1.Classes.Contratos
{
    public class LoginModel
    {
        [Required(ErrorMessage = "0 e-email é obrigatorio.")]
        [EmailAddress(ErrorMessage = "Digite um email valido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "a Senha é obrigatorio.")]
        [MinLength(6,ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
        public string Senha { get; set; } = string.Empty ;
    }
}
