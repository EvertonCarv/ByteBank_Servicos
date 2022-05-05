// See https://aka.ms/new-console-template for more information
using _07_ByteBank;

Console.WriteLine("07-ByteBank");

ContaCorrente conta = new ContaCorrente();
Cliente cliente = new Cliente();

cliente.Nome = "Guilherme";
cliente.CPF = "434.564.879-20";
cliente.Profissao = "Desenvolvedor C#";


conta.saldo = -10;
conta.titular = cliente;

Console.WriteLine(conta.titular.Nome);
Console.WriteLine(conta.saldo);