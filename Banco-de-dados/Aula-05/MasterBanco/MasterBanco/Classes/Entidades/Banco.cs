using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace MasterBanco.Classes.Entidades
{
    internal class Banco
    {
        //campo
        private const decimal TaxaSaque = 5.00m;
        
        
        // --------- propriedades-------//
        public int ID { get; set; }
        public string Titular { get; set; }
        public int NumeroDaConta { get; set; }
        public decimal Saldo { get; set; }

        //construtores
        public Banco() { }

        public Banco(string titular, int numeroDaConta, decimal saldo)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }
        //caminho do servidor onde esta o banco de dados
        private static string conectarCaminho = @"Server = ECFP507D1319380\SQLEXPRESS;Database = Cloadoaldo; Trusted_Connection = True; TrustServerCertificate = True";
        // operações CRUD
        // C - Create
        public static void CadastrarContas(Banco banco)
        {
            //query
            string consulta = "INSERT INTO " +
                "Contas(Titular,NumeroDaConta,Saldo)" +
                "VALUES" +
                "(@Titular, @NumeroDaConta,@Saldo)";
            using (SqlConnection conexao = new SqlConnection(conectarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@Titular", banco.Titular);
                comando.Parameters.AddWithValue("@NumeroDaConta", banco.NumeroDaConta);
                comando.Parameters.AddWithValue("@Saldo", banco.Saldo);

                conexao.Open();
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    Console.WriteLine($"Conta cadastrado com sucesso");
                }
            }
        }

        // r-READ
        public static void LerContas()
        {
            string consulta = "SELECT id, Titular, NumeroDaConta, Saldo FROM Contas";
            using (SqlConnection conexao = new SqlConnection(conectarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                conexao.Open();
                using (SqlDataReader leitura = comando.ExecuteReader())
                {
                    if (leitura.HasRows)
                    {
                        while (leitura.Read())
                        {
                            Console.WriteLine($"id: {leitura["id"]}" +
                                $"Conta: {leitura["numeroDaConta"]}" +
                                $"Titular: {leitura["titular"]}" +
                                $"Saldo: {leitura["saldo"]}");
                        }
                    }
                }
            }
        }
    }
}

