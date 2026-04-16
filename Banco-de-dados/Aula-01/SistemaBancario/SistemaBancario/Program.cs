using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.bancoContexto;
using static System.Console;
using var Context = new BancoContexto();

//verificar se o database(DB) existe e cria se necessario
//cria as tabelas baseadas ma entidades configuradas
Context.Database.EnsureCreated();

//menu do programa
WriteLine("Sistema bancario");
WriteLine("\n---menu principal");
WriteLine("1 cadastrar conta nova");
WriteLine("2 consultar conta existente");
WriteLine("3 sair\n");
Write("Escolha uma opção");
