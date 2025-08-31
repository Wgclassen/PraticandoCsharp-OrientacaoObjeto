namespace softwareStore;

internal class InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
{
    public int TamanhoMB { get; } = tamanhoMB;
    public string SistemaOperacional { get; } = sistemaOperacional;
}
