using bytebank.Modelos.Conta;
using bytebank_atendimento.bytebank_util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Aula 01 - Primeiro Array

//int idade0 = 30;
//int idade1 = 40;
//int idade2 = 17;
//int idade3 = 21;
//int idade4 = 18;

//int media = (idade0 + idade1 + idade2 + idade3 + idade4) / 5;

//TestaArrayInt();

//TestaBuscarPalavra();

//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"Tamanho do array = {idades.Length}");

//    int acumulador = 0;
//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"Indice [{i}] = {idade} anos");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"Média das idades = {media}");
//}

//void TestaBuscarPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite {i + 1}ª Palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}");
//            break;
//        }
//    }
//}

/*

Como vimos, os arrays, ou vetores, são um agrupamento de elementos que armazenamos em uma sequência, sendo o primeiro 
elemento do array o índice zero. Normalmente, quando criamos uma estrutura deste tipo, temos que definir sua dimensão, que pode ser
única ou multidimensional. Vamos a um exemplo de um array de uma dimensão:

int[] numeros = new int[10]; 

Podemos ter ainda um array com mais de uma dimensão, como por exemplo:

int[,] numeros = new int[3,3];

Depois de entender como criar arrays, é importante entender que eles são tipos por referência, daí a palavra reservada new 
na sua declaração. Mas afinal, quais as formas que temos para iniciar esse tipo de estrutura? Primeiramente temos que lembrar que 
para manipular os arrays, vamos utilizar seus índices, e que todo array em C# inicia no 0.

Na forma mais básica de se declarar e inicializar um array temos:string[] palavras = new string[10] e para inserir valores recorremos à: 
palavras[0]="André.". Neste exemplo primeiro é declarado o array e depois inserimos os elementos em cada índice. Mas também podemos declará-lo 
e iniciá-lo por exemplo:

string [] palavras= new string[5] {"André","Jose","Andressa","Neia","Sarah"}`.

Podemos também omitir o número de elementos como no exemplo:

double[] valores={2.6,9.7,7.5,1.8};

foreach — em inglês, "for each" significa "para cada". Assim como o for, podemos digitar foreach e pressionar a tecla "Tab" duas vezes para gerar
um modelo automaticamente. A estrutura foreach é mais simples em relação ao for e nos permite percorrer um array ou uma coleção (que estudaremos 
mais adiante neste curso). Em outras palavras, o foreach é outra estrutura de repetição para iterar um array.

*/
#endregion

#region Aula 02 - Classe Array
//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

////[5,9][1,8][7,1][10][6,9]
//double[] valores = { 10, 58, 36, 47 };

//TestaMediana(amostra);
//Console.WriteLine($"Média = {MediaDaAmostra(valores)}");

//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo");

//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);
//    //[1,8][5,9][6,9][7,1][10]

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                          (numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2);
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//double MediaDaAmostra(double[] amostra)
//{
//    double media = 0;
//    double acumulador = 0;

//    if ((amostra == null) || (amostra.Length == 0))
//    {
//        Console.WriteLine("Amostra de dados nula ou vazia.");
//        return 0;
//    }
//    else
//    {
//        for (int i = 0; i < amostra.Length; i++)
//        {
//            acumulador = acumulador + amostra[i];
//        }
//        media = acumulador / amostra.Length;
//    }

//    return media;
//}


/*

vimos outra forma de utilizar a super classe Array que define todos os arrays da linguagem C#, trazendo uma série de propriedades e métodos.
Conseguimos, por exemplo, identificar o tamanho de um vetor, cloná-lo e ordená-lo. Assim, temos muito mais flexibilidade ao trabalhar com arrays.

Ao criar um array usando a classe Array, utilizamos o método .CreateInstance() em que passamos o tipo e o tamanho do array, porém vale 
ressaltar que a estrutura Array amostra = Array.CreateInstance(typeof(double), 5) é equivalente a Array amostra = new double[5]. Podemos trocá-las 
no nosso código e ele continuará funcionando normalmente.

*/

//for(int i = 0; i < 4; i++)
//{
//    Console.WriteLine(valores[i]);
//}

/*
 
Note que colocamos i < 4 em vez de i < valores.Length, como de costume. Visto que o tamanho de valores é 4, essa opção não faz diferença no 
nosso código, por enquanto. Podemos salvar e executar o programa e veremos os 4 valores impressos no console, tudo estará funcionando normalmente.

Agora, vamos supor que estamos fazendo a manutenção de um código e decidimos inserir os números manualmente para fazer alguns testes. Nesse 
processo, colocamos um número maior que o tamanho do array:

int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(valores[i]);
}

Nosso programa não será compilado. Teremos uma mensagem de exceção sem tratamento: System.IndexOutOfRangeException — índice fora dos limites. 
Ou seja, temos um array com 4 posições, porém o laço está programado para iterar 5 vezes. Estamos tentando acessar uma posição que não existe no vetor.

Este erro é bastante comum quando manipulamos um array, por isso é importante atentarmos ao tamanho dos vetores para evitar exceções como essa. 

A classe Array é a superclasse de onde todas as instâncias de array do C# herdam seus atributos e métodos. Dentre as características desta classe temos:

Pode possuir uma ou mais dimensões.
Tem um tamanho fixo.
Suporta acesso por índices.

Como vimos, podemos criar uma instância da classe usando a sintaxe mais simplificada int[] valores = new int[10] ou usar o método CreateInstance 
por exemplo: Array pesquisa = Array.CreateInstance(typeof(double), 6);

Para adicionar elementos ao vetor podemos usar o método SetValue que recebe dois parâmetros: o elemento e o índice, onde o elemento será “setado”.
Temos um exemplo: pesquisa.SetValue(9.1,1);

As principais propriedades e métodos disponibilizados pela classe Array apresentamos na tabela abaixo:

Propriedade/Método	Descrição

GetValue	retorna o conteúdo/valor de um elemento pelo índice.
GetLength	retorna o números de elementos do array.
Rank	    retorna o número de dimensões de um array.
CopyTo	    cria uma cópia de todos os valores de um array.
Sort	    ordena os valores de um array de forma ascendente.
Reverse	    inverte a ordem de elementos de um array.
Clone	    cria uma cópia do array.
Length	    retorna o número de elementos de um array.
IndexOf	    encontra a primeira ocorrência de um elemento no array.
LastIndexOf	encontra a última ocorrência de um elemento no array.
Clear	    limpa todas as posições de um array.
Exists	    verifica se existe ou não um elemento no array. 
 
*/
#endregion

#region Aula 03 - Array de contas
// código anterior omitido

//TestaArrayDeContasCorrentes();

//void TestaArrayDeContasCorrentes()
//{
//    ContaCorrente[] listaDeContas = new ContaCorrente[]
//    {
//        new ContaCorrente(874, "5679787-A"),
//        new ContaCorrente(874, "4456668-B"),
//        new ContaCorrente(874, "7781438-C")
//    };

//    for(int i = 0; i < listaDeContas.Length; i++)
//    {
//        ContaCorrente contaAtual = listaDeContas[i];
//        Console.WriteLine($"Índice {i} - Conta: {contaAtual.Conta}");
//    }
//}
#endregion

#region Aula 04 - Lista de Contas Correntes

//TestaArrayDeContasCorrentes();

//void TestaArrayDeContasCorrentes()
//{

//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    var contaDoAndre = new ContaCorrente(963, "123456-X");
//    listaDeContas.Adicionar(contaDoAndre);
//    //listaDeContas.ExibeLista();
//    //Console.WriteLine("============");
//    //listaDeContas.Remover(contaDoAndre);
//    //listaDeContas.ExibeLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
//    }

//    /*
//    Para criar um indexador, precisamos usar a palavra reservada this com um índice inteiro em uma estrutura bem parecida a uma propriedade e definir a 
//    forma de recuperar um elemento do vetor interno da classe. 
//    */
//}
#endregion

#region Aula 05 - ArrayList e List

/*
ArrayList _listaDeContas = new ArrayList()
{
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(95, "951258-X") {Saldo=200},
    new ContaCorrente(94, "987321-W") {Saldo=60},
};

A classe de biblioteca do .NET ArrayList é uma implementação evoluída de um array, a classe 
ArrayList faz parte do namespace System.Collections, e dentre as características desta classe temos:

A possibilidade de expandir seus limites por meio da propriedade Capacity.
A classe Array já disponibiliza operações de adição, inserção e exclusão de elementos.
Como os arrays também tem disponível os métodos de ordenação de elementos Sort e de inversão
da ordem por meio do Reverse.

Uma característica importante da classe ArrayList é a possibilidade de se adicionar qualquer
tipo de elemento, uma vez que ela trabalha com tipo da superclasse object da qual todos os
tipos do C# derivam.  
 
*/

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(95, "951258-X") {Saldo=200},
    new ContaCorrente(94, "987321-W") {Saldo=60},
};

AtendimentoCliente();

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                case '5':
                    PesquisarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }

}

void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }

}

ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        {
            conta = _listaDeContas[i];
        }
    }
    return conta;
}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Conta.Equals(numeroConta))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}

void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("... Lista de Contas ordenadas ...");
    Console.ReadKey();
}

void RemoverContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if (conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else
    {
        Console.WriteLine(" ... Conta para remoção não encontrada ...");
    }
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        //Console.WriteLine("===  Dados da Conta  ===");
        //Console.WriteLine("Número da Conta : " + item.Conta);
        //Console.WriteLine("Saldo da Conta : " + item.Saldo);
        //Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        //Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        //Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(item.ToString());
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }

}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(95, "178951-A") {Saldo=100},
//    new ContaCorrente(95, "987542-B") {Saldo=200},
//    new ContaCorrente(94, "997541-C") {Saldo=60},
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(95, "567978-D") {Saldo=100},
//    new ContaCorrente(95, "445668-E") {Saldo=200},
//    new ContaCorrente(94, "778164-F") {Saldo=60},
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for(int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0,1); // criando uma nova lista a partir de outra
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//if (_listaDeContas3.Count > 0)
//{
//    for (int i = 0; i < _listaDeContas3.Count; i++)
//    {
//        Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
//    }
//}
//else
//{
//    Console.WriteLine("Lista vazia!");
//}

//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Olá mundo!");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}

//public class MinhaClasseGenerica<T>
//{
//    public T PropriedadeGenerica { get; set; }
//    public void ExibirDados(T t)
//    {
//        Console.WriteLine($"Dado Informado = {t.ToString()}");
//        Console.WriteLine($"Tipo = {t.GetType()}");
//    }

//}

//MinhaClasseGenerica<string> objGenerico = new MinhaClasseGenerica<string>();
//objGenerico.ExibirDados("Olá mundo!");


//MinhaClasseGenerica<int> objGenerico2 = new MinhaClasseGenerica<int>();
//objGenerico2.ExibirDados(3);


//Pessoa andre = new Pessoa() { Idade = 18, Nome = "André" };
//MinhaClasseGenerica<Pessoa> objGenerico3 = new MinhaClasseGenerica<Pessoa>();
//objGenerico3.ExibirDados(andre);


//public class Pessoa
//{
//    public string Nome { get; set; }
//    public int Idade { get; set; }

//    public override string ToString()
//    {
//        return $"Nome = {this.Nome} com Idade = {this.Idade}";
//    }
//}
#endregion

#region Outras Coleções
///*
//Na biblioteca de classes do .NET para trabalharmos com coleções além das já mencionadas Array, ArrayList e List temos 
//uma série de collection igualmente interessante para usarmos no desenvolvimento de nossas aplicações. Abaixo vamos listar 
//mais algumas:

//SortedList, nesta coleção trabalhamos com itens ordenados por um conjunto de chave-valor. Algumas características:

//Utilizada para ordenarmos itens sem muito esforço.
//Podemos procurar pro uma chave específica.
//A classe SortedList também possui uma versão que aceita generics e fica no namespace System.Collections.Generic. 
//Um exemplo: 
//*/

//SortedList<int, string> times = new SortedList<int, string>();
//times.Add(0, "Flamengo");
//times.Add(1, "Santos");
//times.Add(2, "Juventus");

//foreach (var item in times.Values)
//{
//    Console.WriteLine(item);
//}

///*
//Stack, esta coleção implementa o conceito de pilha, onde os elementos mais novos são adicionados no topo da pilha, e 
//devem ser retirados nesta ordem. Esta classe também possui uma versão genérica. Exemplo de utilização: 

//*/

//Stack<string> minhlaPilhaDeLivros = new Stack<string>();
//minhlaPilhaDeLivros.Push("Harry Porter e a Ordem da Fênix");
//minhlaPilhaDeLivros.Push("A Guerra do Velho.");
//minhlaPilhaDeLivros.Push("Protocolo Bluehand");
//minhlaPilhaDeLivros.Push("Crise nas Infinitas Terras.");

//// Para encontrarmos o livro que está no topo da pilha usando o método Peek, para remove-lo usamos o método Pop:
//Console.WriteLine(minhlaPilhaDeLivros.Peek());// Retorna o elemento do topo.
//Console.WriteLine(minhlaPilhaDeLivros.Pop()); //Remove o elemento do topo

///*
//Queue, esta coleção por sua vez implementa o conceito de fila, onde os elementos mais novos são os primeiros a serem 
//removidos. Para adicionar um elemento na fila usamos o método Enqueue: 
//*/

//Queue<string> filaAtendimento = new Queue<string>();
//filaAtendimento.Enqueue("André Silva");
//filaAtendimento.Enqueue("Lou Ferrigno");
//filaAtendimento.Enqueue("Gal Gadot");

//// Similar ao método Pop para a fila temos o método Dequeue para remover um objeto da fila. Exemplo:

//filaAtendimento.Dequeue();//Remove o primeiro elemento da fila.

//// HashSet, focado em alta performance esta coleção não aceita valores duplicados, para adicionar elementos
//// temos também disponível o método Add:

//HashSet<int> _numeros = new HashSet<int>();
//_numeros.Add(0);
//_numeros.Add(1);
//_numeros.Add(1);
//_numeros.Add(1);

//// Para saber quantos elementos a coleção _numeros possui podemos usar a propriedade Count:

//Console.WriteLine(_numeros.Count);// a saída é 2.

//// Para exibirmos o conteúdo podemos percorrer a coleção usando um foreach:

//foreach (var item in _numeros)
//{
//    Console.WriteLine(item);
//}
#endregion