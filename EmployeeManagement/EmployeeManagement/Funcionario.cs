namespace EmployeeManagement;

internal class Funcionario(string nome, string cargo)
{
    public string Nome { get; set; } = nome;
    public string Cargo { get; set; } = cargo;

    public void Promover(string novoCargo)
    {
        if (this.Cargo != novoCargo)
        {
            this.Cargo = novoCargo;
            Console.WriteLine("Promoção realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
    }

}
