using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using ProjetoAPI01.Classes.Repositorio;
using ProjetoAPI01.Classes.DTO;
using System.Text.Json;

[JsonSerializable(typeof(LoginRequestDTO))]
[JsonSerializable(typeof(LoginResponseDTO))]
internal partial class AppJsonSeralizerContext : JsonSerializerContext
{
   
}

