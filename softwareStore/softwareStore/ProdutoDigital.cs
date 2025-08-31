namespace softwareStore;

internal class ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
{
    public string Nome { get; } = nome;
    public double Preco { get; } = preco;
    public InformacaoTecnica InfoTecnica { get; } = infoTecnica;

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\r\nPreço: R$ {Preco}\r\nTamanho: {InfoTecnica.TamanhoMB}MB\r\nCompatível com: {InfoTecnica.SistemaOperacional}");
    }
}
