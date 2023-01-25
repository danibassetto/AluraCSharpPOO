using System;
using System.Globalization;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Aula 01 - Primeiro Array

//int idade0 = 30;
//int idade1 = 40;
//int idade2 = 17;
//int idade3 = 21;
//int idade4 = 18;

//int media = (idade0 + idade1 + idade2 + idade3 + idade4) / 5;

TestaArrayInt();

TestaBuscarPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do array = {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = {idade} anos");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média das idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}


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