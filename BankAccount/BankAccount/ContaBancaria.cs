namespace BankAccount;

internal class ContaBancaria(string numeroConta, decimal saldo)
{
    public string NumeroConta { get; set; } = numeroConta;
    public decimal Saldo { get; set; } = saldo;

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
}