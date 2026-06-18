

using AplicativoDesketop01.Classes.DTO;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
namespace AplicativoDesketop01
{
    public partial class TelaLogin : Form
    {
        private static readonly HttpClient clienteHttp = new();
        private const string urlApiLogin = "http://localhost:5242/api/usuarios/login";
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dadosLogin = new LoginRequestDTO
            {
                email = textBox1.Text.Trim(),
                senha = textBox2.Text.Trim(),
            };
            try
            {
                var resposta = await clienteHttp.PostAsJsonAsync(urlApiLogin, dadosLogin);

                if (resposta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Usuarios ou senha incorretos");
                    return;
                }
                else if (!resposta.IsSuccessStatusCode)
                {
                    var mensagemErro = await resposta.Content.ReadAsStringAsync();
                    MessageBox.Show($"não foi possivel autenticar. Detalhes {mensagemErro}");
                    return;
                }
                var resultado = await resposta.Content.ReadFromJsonAsync<LoginResponseDTO>();

                if (resultado.Regra != 1)
                {
                    MessageBox.Show("Acesso negado este usuario não tem privilegio adm");
                    return;
                }
                MessageBox.Show("Login realizado com sucesso");
                this.Hide();
                using (var telaAdmin = new TelaAdmin())
                {
                    telaAdmin.ShowDialog();
                }
                this.Close();
            }
            catch (HttpRequestException ht)
            {
                MessageBox.Show($"não foi possivel conectar na API {ht.Message}");
            }

            

                
        }
    }
}
