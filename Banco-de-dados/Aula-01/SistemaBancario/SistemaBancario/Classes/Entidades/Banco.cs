

using System.Security.Cryptography.X509Certificates;

namespace SistemaBancario.Classes.Entidades
{
    /// <summary>
    /// Classe que representa uma conta bancaria com operações basicas
    /// Implementar as regras de negocio
    /// </summary>
    internal class Banco
    {
        ///Campo
        ///<summary>
        ///Taxa fixa cobrada em cada operação de saque
        ///<summary>
        private const decimal taxaSaque = 5.00m;


        //propriedades
        ///<summary>
        ///Identificador Unico da conta bancaria no banco de dados (gerado automaticamente)
        ///</summary>
        public int Id { get; set; }
        ///<summary>
        ///Numero da conta bancaria
        ///'init' garante que o valor só pode ser atribuido na criação( imutavel após construção)
        ///</summary>
        public int NumeroConta {  get; init; }
        
        ///<summary>
        ///Nome do titular da conta
        ///</summary>
        public string Titular {  get; set; }

        ///<summary>
        ///Saldo atual da conta
        ///'private set' impede alteração direta - ´so pode mudar atraves de deposito ou saque
        ///</summary>
        public decimal Saldo { get; private set; }
        //Construtores
        public Banco()
        {

        }
        ///<summary>
        ///Construtor Principal para criar uma nova conta bancaria
        ///</summary>
        ///<param name="numeroConta"
        ///<param name="saldo"
        ///<param name="titular"
        

        public Banco(int numeroConta, string titular, decimal saldo = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de deposito deve ser positivo");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"deposito de {valor:C} realizando com sucesso");
        }
            ///<summary>
            ///Realiz um saque na conta, Dimuindo o saldo
            ///Cobra automaticamente uma taxa de R$5.00 por saque
            ///IMPORTANTE: Permite saldo negativo se não houver fundos.
            ///</summary>
            ///<param name="valor">valor a ser sacado(deve ser positivo, não inclui a taxa)</param>

             public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("valor de saque deve ser positivo");
                return;
            }
            Saldo -= valor + taxaSaque;
            Console.WriteLine($"Saque de {valor:C}realizado com sucesso taxa de {taxaSaque:C} cobrada");
        }
              ///<summary>
              ///exibe dados da conta n console
              ///mostra numero da conta, titular e saldo atual
              ///</summary>
              public void ExibirDados()
        {
            Console.WriteLine("\n dados da conta");
            Console.WriteLine($"Conta : {NumeroConta}");
            Console.WriteLine($"Titular {Titular}");
            Console.WriteLine($"saldo {Saldo}");
            Console.WriteLine("------------\n");
        }



            }
        }
    

