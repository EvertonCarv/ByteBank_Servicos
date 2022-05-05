// See https://aka.ms/new-console-template for more information
using _08_ByteBank;

Console.WriteLine("08-ByteBank");

ContaCorrente conta = new ContaCorrente(867, 86712540); //Aqui foi definido a tratativa para que o programa não compile com valor <= 0 sendo assim necessário colocar numero acima de 0

Console.WriteLine(conta.Agencia);
Console.WriteLine(conta.Numero);

ContaCorrente contaDaGariela = new ContaCorrente(867, 86745820);

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);