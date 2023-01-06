using bytebank.Contas;
using bytebank.Titular;

#region Aula 01 - Criação de Classes
//Console.WriteLine("============ AULA 01 ============");

///* 
//No geral, a classe serve para separar e criar algo que existe no mundo real, com suas particularidades. (Ex: Celular,
//Carro, Conta corrente...)

//tipo        nome           novo objeto
//*/
//ContaCorrente contaDoAndre = new ContaCorrente();
////contaDoAndre.titular = "André Silva";  (utilizado nas primeiras aulas, antes da criação do objeto cliente)
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("saldo da conta do andré = " + contaDoAndre.saldo);

//contaDoAndre.Deposito(100);

//Console.WriteLine("novo saldo = " + contaDoAndre.saldo);

//contaDoAndre.saque(100);

//Console.WriteLine("novo saldo = " + contaDoAndre.saldo);

///*
//Convenções de nomenclatura:

//campos e parâmetros de métodos: camel ou camelCasing (em nomes compostos por mais de uma palavra, a primeira delas deve 
//levar a primeira letra minúscula e as palavras seguintes terão inicial maiúscula. Exemplo: idade, nome)

//classes, estruturas e records:  pascal ou PascalCasing (iniciaremos a palavra com letra maiúscula, e se for um nome composto,
//as próximas palavras começarão com maiúscula também. Exemplo: class ContaCorrente, Cliente, Produto)
//*/
#endregion

#region Aula 02 - Métodos
//Console.WriteLine("============ AULA 02 ============");

//if (contaDoAndre.Saque(300))
//{
//    Console.WriteLine("Novo saldo = " + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente! Saldo disponível = " + contaDoAndre.saldo);
//}

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350; 

//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo); 

//contaDoAndre.Transferencia(50, contaDaMaria);
//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);
#endregion

#region Aula 03 - Tipos de variáveis e valores default
//Console.WriteLine("============ AULA 03 ============");

////valor padrão, definido ao instanciar um novo objeto sem atribuir valor a seus elementos
//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
////Console.WriteLine(contaDoPedro.saldo); (Em aulas posteriores o saldo ficou como private)
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

///*
//Valores primitivos (default)
//int - 0
//double - 0
//string - null
//bool - false

//nota de aula:
//ao comparar dois objetos que possuem o mesmo valor mas referenciam diferentes lugares
//na memória, o resultado será false
//*/
#endregion

#region Aula 04 - Criação de outra classe, para definir caracteristiscas do Titular
//Console.WriteLine("============ AULA 04 ============");

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "12345678910";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();

//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100; 

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Número da conta = " + conta.conta);
//Console.WriteLine("Número da agência = " + conta.numero_agencia);
//Console.WriteLine("Saldo = " + conta.saldo);
#endregion

#region Aula 05 - Namespaces
/*
O namespace, como o próprio nome diz, são nomes que servem para organização das classes relacionadas, 
de forma hierárquica, a partir dessa aula, novos usings e pastas foram adicionados devido novos namespaces
*/
#endregion

#region Aula 06 - Referência Nula
///*
//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "98765432110";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//Aqui ocorre um erro de referência nula, pois estamos utilizando o objeto titular mas ele não foi definido.
//Abaixo, ao definir que titular é igual a um novo cliente, o erro cessa.
//*/

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "98765432110";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta.saldo = 500;

//Console.WriteLine(conta2.titular.nome);
#endregion

#region Aula 07 - Visibilidade, métodos públicos e encapsulamento
//ContaCorrente conta3 = new ContaCorrente();
///* conta3.saldo = 3;  ERRADO

//Quando queremos impedir a alteração de um valor de um campo, tornamos ele privado, com isso não estará mais 
//acessível. Para manipulá-los, precisamos utilizar métodos públicos, assim teremos segurança e encapsulamento 
//das informações.

//- Criação da função SetSaldo() e GetSaldo()
//*/

//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());

//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());

/*
public: acessível de qualquer ponto do código, ou seja não impõe restrições;

private: acessível somente dentro do contexto onde foi declarado, ou seja, um membro privado dentro 
de uma classe só é acessível dentro da própria classe;

protected: o elemento é acessível dentro da classe e suas derivadas;

internal: é o padrão no C#. Caso nenhum modificador seja declarado, definirá a acessibilidade do 
elemento dentro do executável ou dll onde foi declarado;

protected internal: é proveniente união dos modificadores protected e internal. 
 
*/
#endregion

#region Aula 08 - Propriedades
/*
No C# e .NET é possível utilizar as propriedades get e set para definir o método criado anteriormente.
Note na classe "ContaCorrente" o campo Numero_agencia
*/
#endregion

#region Aula 09 - Propriedades autoimplementadas
/*
Então, se temos uma propriedade em que não é interessante criar nenhum tipo de validação, podemos 
criar diretamente uma propriedade autoimplementada.

Note o campo Conta na classe "ContaCorrente"
*/
ContaCorrente conta4 = new ContaCorrente();
conta4.Numero_angencia = 18;
conta4.SetSaldo(200);
conta4.Conta = "1011-X";
Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_angencia);
Console.WriteLine(conta4.Conta);
#endregion