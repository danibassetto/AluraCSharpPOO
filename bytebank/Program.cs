/* 
No geral, a classe serve para separar e criar algo que existe no mundo real, com suas particularidades. (Ex: Celular,
Carro, Conta corrente...)
*/

using bytebank;

//tipo        nome           novo objeto
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

contaDoAndre.Deposito(100);

Console.WriteLine("Novo saldo = " + contaDoAndre.saldo);

contaDoAndre.Saque(100);

Console.WriteLine("Novo saldo = " + contaDoAndre.saldo);

if (contaDoAndre.Saque(300))
{
    Console.WriteLine("Novo saldo = " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente! Saldo disponível =" + contaDoAndre.saldo);
}

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

contaDoAndre.Transferencia(50, contaDaMaria);
Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//valor padrão, definido ao instanciar um novo objeto sem atribuir valor a seus elementos
ContaCorrente contaDoPedro = new ContaCorrente();
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine(contaDoPedro.numero_agencia);
Console.WriteLine(contaDoPedro.conta);

/*
Valores primitivos (default)
int - 0
double - 0
string - null
bool - false

nota de aula:
ao comparar dois objetos que possuem o mesmo valor mas referenciam diferentes lugares
na memória, o resultado será false
*/