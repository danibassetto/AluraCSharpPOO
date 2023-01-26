using bytebank.Modelos.Conta;

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

#region Aula  - Array de contas
// código anterior omitido

TestaArrayDeContasCorrentes();

void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C")
    };

    for(int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice {i} - Conta: {contaAtual.Conta}");
    }
}
#endregion