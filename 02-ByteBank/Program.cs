// See https://aka.ms/new-console-template for more information
Console.WriteLine("02-ByteBank");


ContaCorrente conta = new ContaCorrente();

conta.titular = "Gabriela";
conta.saldo = 150 + conta.saldo;

Console.WriteLine(conta.titular);
Console.WriteLine(conta.saldo);