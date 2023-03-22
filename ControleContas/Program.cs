
using ControleContas.Model;

// minha solução
//var contas = new List<Conta>
//{
//   new Conta("1234", 1244.34m),
//   new Conta("654321", 2341.42m)
//};
//contas.ForEach(conta => Console.WriteLine(conta.Saldo));

//Console.WriteLine($"Maior saldo: {contas.Max(conta => conta.Saldo)}");

//Console.WriteLine($"Total geral de saldo das contas: {contas.Sum(conta => conta.Saldo)}");

//var clientes = new List<Cliente>
//{
//    new Cliente("Lucas", "17304026740", 100698),
//    new Cliente("Julia", "16095380723", 30101999)
//};

////clientes.ForEach(cliente => contas.ForEach(conta => cliente.IdConta = conta.Numero));

//clientes.ForEach(cliente => Console.WriteLine(cliente.IdConta));


// solução rosen

Conta conta3 = new Conta("654321", 2341.42m);
Conta conta4 = new Conta("1234", 2341.42m);

Console.WriteLine($"Conta: {conta3.Numero}; Saldo: {conta3.Saldo}");

Console.WriteLine($"O saldo total é: {conta3.SaldoTotal}");

Console.WriteLine("A conta com maior saldo é: {0}", conta3.ContaMaiorSaldo);
