namespace MedicalAppointment;

internal class Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
{
    public string NomePaciente { get; } = nomePaciente;
    public string NomeMedico { get; } = nomeMedico;
    public DateTime DataConsulta { get; set; } = dataConsulta;

    private bool Reagendada;

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        Reagendada = false;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Consulta marcada com {NomeMedico} para o paciente {NomePaciente}.");
        string data = Reagendada ? "Data" : "Nova data";
        Console.WriteLine($"{data}: {DataConsulta.ToString("dd/MM/yyyy")}\n");
    }
}
