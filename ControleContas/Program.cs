
using ControleContas.Model;

// minha solução
//var contas = new List<Conta>
//{
//   new Conta("1234", 1244.34m),
//   new Conta("654321", 2341.42m)
//};
//contas.ForEach(conta => Console.WriteLine(conta.Saldo));

//Console.WriteLine($"Maior saldo: {contas.Max(conta => conta.Saldo)}");

Conta conta3 = new Conta("654321", 2341.42m);
Conta conta4 = new Conta("1234", 2341.42m);

Cliente cliente1 = new Cliente("Lucas", "173040267400", 2012);

Console.WriteLine(cliente1.Cpf);
Console.WriteLine(cliente1.Nome);
Console.WriteLine(cliente1.AnoNascimento);