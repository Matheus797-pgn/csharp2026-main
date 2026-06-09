namespace AplicativoDesketop01
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = "Ronaldo";
            string senha = "123456";

            bool comparacao1 = textBox1.Text == Usuario;
            bool comparacao2 = textBox2.Text == senha;

            if (comparacao1 & comparacao2)
            {
                MessageBox.Show("usuario e senha correto");
                this.Hide();
                using (var telaAdm = new TelaAdmin())
                {
                    telaAdm.ShowDialog();
                }
                this.Close();
            }
            else 
            {
                MessageBox.Show("usuario ou senha incorretos");

            }
                
        }
    }
}
