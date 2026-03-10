using static System.Console;
const int SENHAFIXA = 2002;
int senha, contagem = 0;
//entrada de dados
Write("digite a senha: ");
senha = int.Parse(ReadLine());
//processamento de dados
while (senha != SENHAFIXA)
{
    if (contagem >= 3)
    {
        WriteLine("Acesso bloqueado");
        break;
    }
    contagem++;
    Write("Senha incorreta, Digite novamente");
    senha = int.Parse(ReadLine());
#pragma warning disable CA1416 // Validar a compatibilidade da plataforma
    Beep (3000, 500);
#pragma warning restore CA1416 // Validar a compatibilidade da plataforma
}
if (contagem < 3)
{
    WriteLine("Acesso permitido!");
}
else
{
    WriteLine($"numero de tentativas excedidos, aguarde 30 segundos");
}