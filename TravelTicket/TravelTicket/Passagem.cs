namespace TravelTicket;

internal class Passagem(string passageiro, string destino)
{
    public string Passageiro { get; set; } = passageiro;
    public string Destino { get; set; } = destino;
}
