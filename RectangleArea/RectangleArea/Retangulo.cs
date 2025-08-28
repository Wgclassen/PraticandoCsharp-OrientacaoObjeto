namespace RectangleArea;

internal class Retangulo (int altura, int largura)
{
    public int Altura { get; set; } = altura;
    public int Largura { get; set; } = largura;

    public int CalcularArea()
    {
        return Altura * Largura;
    }
}