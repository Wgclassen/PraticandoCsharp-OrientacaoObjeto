using EmployeeManagement;

Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");

Console.WriteLine($"Funcionário: {funcionario.Nome}\nCargo Atual: {funcionario.Cargo}");

funcionario.Promover("Assistente Administrativo");
funcionario.Promover("Analista de Projetos");

Console.WriteLine("--- Após promoção ---");
Console.WriteLine($"Funcionário: {funcionario.Nome}\nCargo Atual: {funcionario.Cargo}");