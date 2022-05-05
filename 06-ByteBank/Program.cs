// See https://aka.ms/new-console-template for more information
using _06_ByteBank;

Console.WriteLine("06-ByteBank-usando criando uma nova classe");


Cliente Gabriela = new Cliente(); // gabriela é uma referência a objeto

Console.WriteLine(Gabriela);
Gabriela.Nome = "Gabriela";
Gabriela.Profissao = "Desenvolvedora C#";
Gabriela.CPF = "344222222-18";

ContaCorrente conta = new ContaCorrente();
conta.Titular = new Cliente();
conta.Titular.Nome = "Gabriela";
conta.Titular.CPF = "434.562.878-20";
conta.Titular.Profissao = "Desenvolvedora C#";


conta.Saldo = 500;
conta.Agencia = 563;
conta.Numero = 5634527;

//Console.WriteLine(Gabriela.Nome);
Console.WriteLine(conta.Titular.Nome);
Console.WriteLine(conta.Titular.CPF);
Console.WriteLine(conta.Titular.Profissao);
