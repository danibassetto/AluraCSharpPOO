using bytebank.Contas;
using bytebank.Exceções;
using bytebank.Titular;
using bytebank;
using System.Numerics;

/*  
    Programa desenvolvido durante aulas do Alura, portanto conta com explicações e está dividido em regions, de acordo com os temas propostos.
    Note que as aulas antigas estão comentadas, devido as alterações feitas em aulas posteriores.
*/

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
//ContaCorrente conta4 = new ContaCorrente();
//conta4.Numero_agencia = 18;
//conta4.SetSaldo(200);
//conta4.Conta = "1011-X";
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);
#endregion

#region Aula 10 - Construtores
//ContaCorrente conta5 = new ContaCorrente(18, "1010-X");
//conta5.SetSaldo(500);
////conta5.Numero_agencia = 18; --> tornamos o set privado
//conta5.Titular = new Cliente();

//Console.WriteLine(conta5.GetSaldo());
//Console.WriteLine(conta5.Numero_agencia);

///*
//O método construtor ajuda a preencher o objeto na memória e obriga a inserção dos campos contidos em seu parâmetro

//Note na classe Cliente e ContaCorrente os construtores feitos. 
//*/
#endregion

#region Aula 11 - Membro estático 
//ContaCorrente conta6 = new ContaCorrente(283, "1234-X");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta7 = new ContaCorrente(284, "9874-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta8 = new ContaCorrente(285, "1111-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
/* 
Membros estáticos são chamados pela classe e não por objetos, note o campo incrementado TotalDeContasCriadas++

Para acessá-lo no objeto devemos tirar o this. e é interessante que seja set privado para que não tenha alteração,
visto que é incremento. A pessoa desenvolvedora deveria criar a propriedade como estática, para ser uma característica da classe e 
não algo compartilhado com todos os objetos da classe, se não retornará apenas o valor 1, sem incrementá-lo.

ContaCorrente.TotalDeContasCriadas é uma propriedade estática que carrega no momento que executa a aplicação.

Então, o membro estático é uma propriedade relacionada à classe e não ao objeto. Os objetos conseguem acessar essa propriedade 
porque faz parte do contexto da classe, por isso o construtor conseguiu fazer o incremento dela.

Membros estáticos, no momento da execução do programa, são carregados diretamente para a memória, por isso devem ser usados com 
bastante cautela para não ocuparmos a memória do computador com informações desnecessárias para a resolução do problema.
*/

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";
//sarah.Profissao = "Professora";
//sarah.Cpf = "11111111-12";

//Cliente ester = new Cliente();
//ester.Nome = "Ester Almeida";
//ester.Profissao = "Advogada";
//ester.Cpf = "868524125-32";

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

//ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
//contaAndre.Titular = new Cliente();
//contaAndre.Titular.Nome = " André Pereira";
//contaAndre.Titular.Profissao = "Auxiliar Administrativo";
//contaAndre.SetSaldo(100);

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);
#endregion

#region Aula 12 - Conhecendo Exceções e Pilhas de Chamadas (CallStacks)
//ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
//Console.WriteLine(ContaCorrente.TaxaOperacao);
//Console.ReadLine();

/*
Na primeira linha do código, que é a do conta1 criamos uma conta corrente com a agência 283 e o número de conta 1234-x. Essa também é a primeira linha
do método main(). O computador sempre procura o método main para iniciar a leitura da nossa aplicação, e esse método que controla o programa.

No nosso caso, quando o computador ler essa primeira linha, ele entenderá que queremos armazenar a conta que estamos criando dentro da variável conta1.
Também descobre que utilizamos a classe ContaCorrente() para criar essa conta.

Nesse ponto ele busca a classe ContaCorrente() para saber como a conta é criada, quais são os argumentos, o que significa cada argumento e se 
é necessário fazer algum tipo de operação. Então ele sai do método main() e verifica na ContaCorrente() o que deve ser feito, ou seja, por um breve
momento não é o método main() que controla o programa, e sim a ContaCorrente().

Portanto, precisamos saber para onde o código está indo e quem o está controlando naquele momento. É muito importante quando vamos utilizar algumas
ferramentas sabermos qual o melhor lugar para armazená-las, dependendo das circunstâncias.

Precisamos sempre entender como estão acontecendo as chamadas, ou seja, quem está controlando a aplicação naquele momento. No caso, nosso computador
sai da main para a ContaCorrente, entende o que tem que fazer, ou seja, ler os argumentos de conta corrente e agência e armazenar na variável conta1.

Em seguida, o computador volta para o método main para executar o Console.WriteLine(). Dessa forma, o método main volta a controlar o programa naquele
momento.

Essa é a forma resumida que eu queria explicar sobre a pilha de chamadas para vocês entenderem um pouco como ela funciona. Vou deixar a seguir
um Para saber mais: pilha de chamadas, com uma explicação mais detalhada, porém eu passei a ideia que precisamos para esse momento.

Assim podemos continuar entendendo onde podemos localizar e colocar cada ferramenta que vamos aprender no nosso código. Quando pensamos 
em pilha, pensamos em "empilhado", e na pilha de chamadas o que está no topo é o que está controlando nosso programa.

Lembrete: Se o método main estiver no topo, ele está controlando o nosso programa naquele momento.
 
O C# organiza a execução de uma pilha, que sempre começa com o método main() e pode crescer e diminuir de tamanho, dependendo da quantidade
de métodos que forem executados.

Assim como várias outras linguagens, o C# utiliza essa pilha de execução, que é importante para entendermos o "rastro" da exceção. Aqui, o 
nosso principal objetivo é entender que quando acontece a exceção ela se lembra por quais métodos passou.

Porém, alguns eventos excepcionais e imprevistos podem aparecer em nossa aplicação. Portanto, precisamos saber lidar com isso, entendendo a 
exceção, suas mensagens e o seu rastro.

Vimos que a exceção muda o fluxo. Logo, se o método não for capaz de tratá-la, o fluxo de execução sai abruptamente dele e vai para o próximo, 
isso vai acontecer até encontrar algum método que saiba tratá-la.

No Visual Studio conseguimos exibir a pilha de chamadas e usar a janela Pilha de Chamadas no depurador. Para isso, durante a depuração, no menu 
Depurar, selecione Pilha de Chamadas.

Dessa forma, conseguimos verificar o fluxo da nossa aplicação e entender qual bloco de código é executado em cada momento. Com isso, se torna mais 
claro onde fazemos modificações em nosso código quando, por exemplo, precisamos tratar uma exceção.
*/
#endregion

#region Aula 13 -  Try e Catch
/*
Observação: apesar de outras linguagens usarem o Try/Catch para resolução de exceções, a escrita desse método pode sofrer varia de acordo com a 
linguagem que está sendo utilizada. Portanto a forma de escrita do Try/Catch em C Sharp não será necessariamente a mesma para outras linguagens que 
fazem o uso desse método.
 
Note o try catch no construtor ContaCorrente.

Poderíamos usar essa solução com If/Else para resolver essa exception, mas a ideia é evitar o uso desse mecanismo. Pretendemos deixar a leitura do
nosso código mais fácil, deixando nosso código mais limpo e de fácil entendimento.

Dentro do try escrevemos o que queremos fazer, no caso, o cálculo da TaxaOperacao. Isso porque o try vem do inglês "tentar", portanto nós 
tentamos calcular essa taxa de operação.

Caso não consigamos devido a alguma exceção, vamos mostrar uma mensagem para o usuário, e para isso usamos o bloco catch() (capturar), que recebe
como argumento uma possível exceção que podemos encontrar. No caso, temos uma exceção DivideByZeroException.
*/
#endregion

#region Aula 14 - Tratando várias excessões: uso do throw, ParamName, e NameOf
//try
//{
//    ContaCorrente conta5 = new ContaCorrente(278, "1234-X");
//    conta5.Saque(50);
//    Console.WriteLine(conta5.GetSaldo());
//    conta5.Saque(150);
//    Console.WriteLine(conta5.GetSaldo());
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
//    Console.WriteLine("O número de agência deve ser maior que zero!");
//    Console.WriteLine(ex.Message);
//}
//catch(SaldoInsuficienteException ex)
//{
//    Console.WriteLine("Operação negada, saldo insuficiente!");
//    Console.WriteLine(ex.Message);
//}

/*
No C Sharp (assim como em outras linguagens), temos outra palavra reservada utilizada no tratamento de exceções: o throw. A palavra throw vem do inglês 
e pode ser traduzida como "lançar". Então, vamos utilizá-la para lançar uma exceção que ocorreu em algum bloco try.

Como esperado, a exceção foi lançada e conseguimos visualizar as duas mensagens — tanto a que definimos no bloco catch quanto a que escrevemos no throw. 

ParamName
O ArgumentException conta com algumas ferramentas para nos ajudar nesse processo. A primeira delas é o ParamName, que exibe o nome do parâmetro que está
lançando a exceção.

nameof: serve para mostrar o nome do parametro, como string.
*/

#endregion

#region Aula 15 - StackTrace
/*
O que é StackTrace?
O StackTrace nos lembrará bastante sobre aquela parte de pilhas de chamadas, em que vimos como funcionava o fluxo de código dentro da nossa aplicação.

O StackTrace pode ser um ótimo aliado no trabalho com exceções, nos ajudando a entender de onde estão vindo determinadas exceções e como elas estão 
sendo tratadas.

Então, se estivermos trabalhando em uma equipe de desenvolvimento grande, é importante deixar as informações tão claras quanto for possível. É 
isso que temos feito ao longo das aulas: estudamos ferramentas que facilitam o dia a dia de uma pessoa desenvolvedora, ajudando-a a solucionar 
problemas. O StackTrace é uma delas! 
 
 
*/

//try
//{
//    ContaCorrente conta5 = new ContaCorrente(0, "1234-X");
//    //conta5.Saque(50);
//    //Console.WriteLine(conta5.GetSaldo());
//    //conta5.Saque(150);
//    //Console.WriteLine(conta5.GetSaldo());
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
//    Console.WriteLine("O número de agência deve ser maior que zero!");
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);
//}
//catch (SaldoInsuficienteException ex)
//{
//    Console.WriteLine("Operação negada, saldo insuficiente!");
//    Console.WriteLine(ex.Message);
//}

/*
Recebemos uma informação um pouco mais técnica, que pode parecer um pouco confusa para quem não tem familiaridade com programação.

Utilizando aquela ideia de pilhas de chamadas, em que tínhamos o fluxo de código, essa mensagem nos mostra a linha em que encontramos uma 
exceção (linha 7, em Program.cs), e a linha em que tratamos essa exceção (linha 92 da classe de Conta Corrente): 
 
Essa informação que o StackTrace fornece pode ser muito interessante em alguns momentos, principalmente para deixar nosso código o mais claro possível
para pessoas que estão tentando entender a nossa aplicação.

O StackTrace é muito comum e utilizado no trabalho com exceções, até mesmo em outras linguagens de programação além do C#. Por isso, é importante 
saber utilizar essa ferramenta para desenvolver nossas aplicações!
 
*/
#endregion

#region Aula 16 - InnerException
/*
 
Agora que entendemos a ideia do StackTrace e como podemos usá-lo a nosso favor, há outra coisa à qual precisamos nos atentar, que pode ser 
importante no trabalho com exceções. É a ideia de que:

Algumas exceções podem derivar de outras exceções.

Parece um pouco confuso de início, mas vamos entender melhor.

Quando essa derivação se aplica?
Assim como o SaldoInsuficienteException vem de Exception, tendo algo maior por trás, nós também podemos criar uma exceção que deriva outras exceções.

Em que situações isso faria sentido?

Podemos imaginar o seguinte: se temos uma conta e queremos retirar uma certa quantia de dinheiro direto no caixa (não o eletrônico). Dissemos 
para a pessoa atendente que queremos tirar R$500,00 da nossa conta, mas o nosso saldo total é de apenas R$100,00, conforme já vimos.

Nesse caso, o ideal é que a pessoa que está no caixa nos informe que esse valor excede o nosso saldo, mas não necessariamente saiba o quanto 
há na nossa conta bancária.

Existem algumas práticas seguras para conceder acesso a determinadas informações apenas para a pessoa usuária ou apenas para as pessoas 
desenvolvedoras.

Por exemplo, se temos um problema como um erro de comunicação entre a aplicação e o banco de dados, será que faz sentido mostrar para o
cliente? Muito provavelmente essa informação só o deixará confuso, fazendo mais sentido para a pessoa desenvolvedora somente. E essas coisas 
podem acontecer!

Então, para solucionar esses problemas e ter o controle de qual mensagem chega para a pessoa usuária e qual mensagem chega para a pessoa 
desenvolvedora, existe a InnerException.

Vamos aprender a criar essa mensagem no nosso SaldoInsuficienteException, por exemplo. 

Assim, deixamos mais claro que a SaldoInsuficienteException é um tipo de exceção que deriva da OperacaoFinanceiraException, facilitando o trabalho
com alguns tipos de informações mais sigilosos.

Quando trabalhamos com esse tipo de informação, conseguimos aplicar a ideia de InnerException, ou Exceção Interna. Ou seja, conseguimos levar para
a pessoa usuária qual é a exceção que está sendo causada de forma mais controlada, sem exibir todas as informações possíveis.
 
*/
#endregion

#region Aula 17 - Lendo um arquivo

//try
//{
//    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
//    leitor.LerProximaLinha();
//    leitor.LerProximaLinha();
//    leitor.Fechar();
//}
//catch(IOException)
//{
//    Console.WriteLine("Leitura de arquivo interrompida.");
//}

/*
Aprendemos como funciona a leitura de um arquivo. Agora, vamos tentar solucionar possíveis problemas que podemos encontrar nesse processo.

Vamos supor que colocamos um pen drive no computador e abrimos um arquivo que estava dentro do pen drive. Repentinamente, o cabo do 
fone enrola e arranca o nosso pen drive do computador e temos uma leitura de arquivo abruptamente interrompida.

Vamos simular essa situação na classe de leitura de arquivo.

Leitura de arquivo interrompida
Colocamos o pen drive, estamos lendo linha a linha do arquivo, quando tiramos o pen drive no meio da leitura das linhas.

Para fazer essa simulação, em LerProximaLinha() da classe LeitorDeArquivo.cs, vamos lançar uma exceção que vai dar um problema de entrada ou saída.

Dessa forma, depois de Console.WriteLine e antes de return, digitamos a instrução throw onde lançaremos uma nova exceção para simular a retirada 
abrupta do pen drive.

Portanto, usaremos uma exceção do C# que trabalha com a operação de entrada e saída chamada IOException. Com isso, temos new IOException.

No nome IOException, a letra "I" vem de input (entrada) e "O" vem de output (saída).

Vamos utilizar IOException sempre que tiver um problema de entrada e saída, como na situação de retirada abrupta de um pen drive. 

Ao trabalhar com arquivos, é importante fechar esses arquivos para salvar e evitar corrompê-los.
*/

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

try
{    
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();    
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida.");
}
finally
{
    leitor.Fechar();
}

/*
 
Abrimos o arquivo "contas.txt", lemos uma linha e encontramos uma exceção. Com isso, recebemos a mensagem que a leitura do arquivo é
interrompida. Contudo, ao contrário do que acontecia anteriormente, conseguimos fechar nosso arquivo.

Em conclusão, o que foi desenvolvido dentro do bloco finally foi executado. Assim, temos uma continuidade apesar de encontrar uma exceção
desenvolvida no bloco catch.

Dessa forma, fizemos a leitura do nosso arquivo e, ao final, o fechamos com a ajuda do finally.

Geralmente, os blocos try-catch vêm acompanhados do finally quando desenvolvemos aplicações. 
  
*/
#endregion

#region Aula 18 - Para saber mais: bloco using
/*
Na computação temos um termo muito utilizado quando queremos nos referir a uma sintaxe que torna mais simples as construções dentro
da aplicação. O nome syntax sugar (açúcar sintático, em português) vem da ideia de deixar a linguagem “mais doce” de ser estudada.

A syntax sugar existe em diversas linguagens e no C# nós temos o using como um açúcar sintático já que essa é uma palavra reservada que 
garante a disposição correta de alguns objetos.

Vamos entender como aplicar o syntax sugar?

Como a única função de nosso try-catch-finally é ter certeza de que o método Fechar() de nosso recurso foi invocado, podemos trocar o 
que escrevemos com o bloco using. 
 
 using(LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}

Este bloco é um açúcar sintático para nosso código escrito no try-finally. Mas o bloco using não conhece o método Fechar(), apenas o método Dispose() da interface IDisposable. 
Por isso, vamos alterar a classe LeitorDeArquivo e implementar essa interface:

public class LeitorDeArquivo : IDisposable
{
    public string Arquivo { get; }

    public LeitorDeArquivo(string arquivo)
    {
        Arquivo = arquivo;

        // throw new FileNotFoundException();
        Console.WriteLine("Abrindo arquivo: " + arquivo);
    }

    public string LerProximaLinha()
    {
        Console.WriteLine("Lendo linha. . .");

        // throw new IOException();
        return "Linha do arquivo";
    }

    public void Fechar()
    {
        Console.WriteLine("Fechando arquivo.");
    }
}

Assim, precisamos trocar o nome do método Fechar() para Dispose():

public void Dispose()
{
    Console.WriteLine("Fechando arquivo.");
}

Viu como o using pode ser usado a nosso favor?
*/
#endregion