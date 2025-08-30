namespace StorageControl;
internal class Produto(string nome, int quantidadeEstoque)
{
    public string Nome { get; set; } = nome;
    private int QuantidadeEstoque { get; set; } = quantidadeEstoque;

    public void Retirar(int quantidade)
    {
        if(quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
        } else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Produto: {Nome}\nEstoque: {QuantidadeEstoque}");
    }
}
