using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using ProjetoAPI01.Classes.Repositorio;
using ProejtoAPI01.Classes.DTO;
using ProjetoAPI01.Classes.DTO;







var builder = WebApplication.CreateSlimBuilder(args);

var stringConexaoBancoAluno = builder.Configuration.GetConnectionString("Aluno")
    ?? throw new InvalidOperationException
    ("A string de conexão 'aluno' não foi encontrada no appsettings.json");
// adicionar serviços a api
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);

});
builder.Services.AddScoped(_ => RepositorioUsuarios(stringConexaoBancoAluno));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
var grupoUsuarios = app.MapGroup("/api/usuarios");
// Endpoint REST responsavel por autenticar o usuarios
grupoUsuarios.MapPost("/login", async Task<IResult> ([FromBody] LoginRequestDTO dadosLogin,
    RepositorioUsuario repositorioUsuarios, CancellationToken cancellationToken) =>
{
    if (string.IsNullOrWhiteSpace(dadosLogin.email) || string.IsNullOrWhiteSpace(dadosLogin.Senha))
    {
        return Results.BadRequest(new LoginResponseDTO
        {
            Sucesso = false,
            Mensagem = "Email e senha são obrigatorios"
        });
    }
    var usuario = await repositorioUsuarios.BuscarPorEmaileSenha(dadosLogin.email, dadosLogin.Senha, cancellationToken);

    if (usuario is null)
    {
        return Results.Unauthorized();
    }
    return Results.Ok(new LoginResponseDTO
    {
        Sucesso = true
        Mensagem = "login realizado com sucesso",
        Nome = usuario.Nome,
        Regra = usuario.Regra
    });
}).WithName("loginUsuario");
app.Run();
[JsonSerializable(typeof(LoginRequestDTO))]
[JsonSerializable(typeof(LoginResponseDTO))]
internal partial class AppJsonSeralizerContext : JsonSerializerContext
{

}

