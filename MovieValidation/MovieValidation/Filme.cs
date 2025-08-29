namespace MovieValidation;

internal class Filme(string nome, int classificacaoEtaria)
{
    public string Nome { get; set; } = nome;
    public int ClassificacaoEtaria { get; set; } = classificacaoEtaria;

    public bool PodeAssistir(int idadeUsuario)
    {
        return idadeUsuario >= this.ClassificacaoEtaria;
    }

    public void ExibirResultado(int idadeUsuario)
    {
        if (this.PodeAssistir(idadeUsuario))
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos não pode assistir ao filme {Nome}.");
        } else
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos pode assistir ao filme {Nome}.");
        }
    }
}
