using exemplo1;
using static System.Console;


try
{
    WriteLine("Entre com os dados do produto:");
    Write("Nome: ");
    string nome = ReadLine();
    Write("preco: ");
    double preco = double.Parse(ReadLine());
    Write("Quantidade");
    int qtd = int.Parse(ReadLine());


    Produto p = new Produto(nome, preco, qtd);

    WriteLine($"dados do produto {p.Dados_do_Produto()}");

    Write("digite a quantidade de produtos a ser adicionado mo estoque: ");
    qtd = int.Parse(ReadLine());
    p.adicionar_Produtos(qtd);
    WriteLine($"dados atualizados: {p.Dados_do_Produto()}");
    Write("digite a quantidade a ser removida do estoque");
    qtd = int.Parse(ReadLine());
    p.Remover_produtos(qtd);
    Write($"dados atualizados: {p.Dados_do_Produto()}");

    ReadKey();
}
catch (Exception)
{
    Write("Digite somente o que esta sendo pedido por favor");
}