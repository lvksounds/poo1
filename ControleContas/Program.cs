
using ControleContas.Model;

Conta conta1 = new Conta("0001", 0.0m);

conta1.Deposito(10.00m);

Console.WriteLine("Saldo atual da conta R${0:00}", conta1.Saldo);

conta1.Saque(5.0m);