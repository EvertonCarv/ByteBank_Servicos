// See https://aka.ms/new-console-template for more information
Console.WriteLine("03-ByteBank");


ContaCorrente contaDaGabriela = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;

ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
contaDaGabrielaCosta.titular = "Gabriela";
contaDaGabrielaCosta.agencia = 863;
contaDaGabrielaCosta.numero = 863452;

int idade = 27; 
int idadeMaisUmaVez = 27;

contaDaGabriela = contaDaGabrielaCosta; // usando esta referência dara true

Console.WriteLine(idade == idadeMaisUmaVez); // igualdade tipo valor

Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // igualdade tipo de referência esse comparativo dara false porque cada objeto esta salvo em uma memoria diferente

contaDaGabriela.saldo = 300;
Console.WriteLine(contaDaGabriela.saldo);
Console.WriteLine(contaDaGabrielaCosta.saldo);