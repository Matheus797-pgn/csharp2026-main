using static System.Console;

List <string> nomes = new List<string>();
nomes.Add("joao");
nomes.Add("maria");
nomes.Add("clodoaldo");
nomes.Add("maria");
foreach (var item in Range(0, nomes.Court))
{
    WriteLine(nomes(item));
}
System.Console.WriteLine("--------------------------------------------------------------");
WriteLine("indice que contem joao: " + nomes.Contains("joao"));
nomes.Clear();
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}