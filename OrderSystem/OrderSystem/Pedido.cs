namespace OrderSystem;

internal class Pedido(string numeroPedido, string nomeCliente, string Status)
{
    public string NumeroPedido { get; } = numeroPedido;
    public string NomeCliente { get; } = nomeCliente;
    public string Status { get; set; } = Status;

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido nº {NumeroPedido}\nCliente: {NomeCliente}\nStatus: {Status}\n");
    }
}
