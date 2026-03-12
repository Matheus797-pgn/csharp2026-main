using static System.Console;
// decalaração de 1 dicionario 
Dictionary<string, int> pessoas = new Dictionary<string, int>()
{
    {"joao", 40},
    {"maria", 50},
    {"clodoaldo", 60}
    
};
// adicionando dados ao dicionario
pessoas.Add("Clodoaldo", 54);
Write($"tamanho = {pessoas.Count()}");
Write(pessoas["Clodoaldo"]);
Write($"tamanho = {pessoas.Count()}");
pessoas.Remove("clodoaldo");
Write($"tamanho = {pessoas.Count()}");