using BankAccount;

ContaBancaria conta = new ContaBancaria("78901-2", 1000.00m);
conta.Depositar(500.00m);

Console.WriteLine($"Conta: {conta.NumeroConta}\nSaldo atual: {conta.Saldo}");