/*
Uma string é uma coleção de caracteres alfanuméricos em formato unicode (letras, números e/ou símbolos) muito utilzada em programação. 
Pode ser representada no código como qualquer conjunto de caracteres entre aspas duplas, por exemplo:

string conteudo = "Mergulhando em tecnologia com Alura";

No C# as strings são um tipo complexo. Mas como assim? Queremos dizer que as strings são tipos de referência e não de valor, ou seja, existe uma classe
no framework que encapsula todas as características de uma cadeia de caracteres. Essa classe, por sua vez, se encontra no namespace System.String.

Uma das características da classe String do .NET é que todos os objetos criados a partir dela são imutáveis. Isso significa que depois que criamos um ]
objeto string eles não podem ser alterados, portanto toda operação que busca modificar a string, na verdade cria um novo objeto contendo as alterações.

Vamos ver como exemplo a nossa string “Olá mundo!''. Invocaremos o método .ToUpper(), que transforma a string em maiúscula e a exibiremos no console,
como na construção abaixo:
*/

string mensagem = "Olá Mundo!";
mensagem.ToUpper();
Console.WriteLine(mensagem);

/*
Dessa forma, temos como saída a string sem alteração. Porém, olhando com mais atenção, podemos identificar que o método ToUpper() retorna um novo objeto,
a string já convertida para maiúscula.

Parte do código no Visual Studio Community, com uma janela suspensa com informações do tipo de retorno do método .ToUpper().
Na plataforma .NET o texto é representado como uma sequência de códigos UTF-16, o que nos possibilita armazenar em memória até 1 bilhão 😯 de
caracteres (2GB).

Utilizando strings
Com as strings podemos realizar diversas ações como formatar, interpolar, concatenar...tudo vai depender da nossa necessidade de utilização. Agora 
vamos observar algumas das possibilidades das strings com C#!

Concatenação de strings
A operação de concatenação de strings consiste em “somar” sequências de caracteres para formar uma uma nova string. Vamos a um exemplo:
*/

string nome = "João";
string sobrenome = "Santos";
Console.WriteLine("Nome completo = "+ nome +" "+ sobrenome);// João Santos

//Para realizar a concatenação de strings utilizamos o operador de adição +. Podemos usar também += e teremos uma construção como a seguinte:

string login = "andre@email.com";
string usuariologado = "Boas vindas ";
usuariologado += login;
Console.WriteLine(usuariologado);// Boas vindas andre@email.com

/*
Assim, temos a saída Boas vindas andre@email.com.

Interpolando strings
Com o recurso da interpolação de strings podemos criar strings parametrizadas, ou seja, que levem parâmetros, o que pode conferir maior dinamicidade
na construção de textos pré-formatados. Por exemplo, imagine que temos um texto padrão de uma carta de aceite como estudante de uma determinada escola
e precisamos mudar apenas um trecho deste texto.
*/

string nomeAluno = "Harry";
string nomeProfessor = "Minerva";
string carta_de_convite = $"Prezado sr/sra.{nomeAluno}" +
                        $"Temos o prazer de informar que v.Sa {nomeAluno} tem uma vaga" +
                        $"na escola de Hogwarts. E Já anexamos uma lista de livros e" +
                        $"materiais necessários." +
                        $"O ano letivo começa no dia primeiro de setembro, estamos aguardando" +
                        $"sua coruja até 31 de julho,no mais tardar." +
                        $"Atenciosamente," +
                        $"Prof. {nomeProfessor}" +
                        $"Diretor(a).";

//Até a chegada do recurso de interpolação no C# 6.0, utilizamos a concatenação ou a formatação com o método Format da classe String. Veja um exemplo:

string nome2 = "João";
string sobrenome2 = "Santos";
var nomeCompleto = nome2 +" "+sobrenome2;
var mensagemFormatada = string.Format("Nome Completo = {0}", nomeCompleto);
Console.WriteLine(mensagemFormatada);

/*
A interpolação de strings é muito bacana para trabalhar texto no código de uma maneira mais legível, propiciando uma manutenção mais fácil.

Verbatim strings
Antes de comentar sobre verbatim strings, é importante saber o que são os chamados caracteres de escape ou sequências de escape, usados junto com as strings.

Por definição, uma sequências de escape é uma combinação de caracteres composta por uma barra invertida (\) seguida de uma letra ou sequência de dígitos. Elas podem ser usadas para especificar alguma ação: como movimentar uma tabulação, realizar a quebra de linha ou mesmo representar caracteres que não podem ser imprimidos.

A seguir temos uma tabela com algumas sequências de escape:

Sequência	Descrição
\a	Campainha (alerta)
\b	Backspace
\n	Nova linha
\t	Guia horizontal
\v	Guia vertical
\’	Aspas simples
\”	Aspas duplas
\	Barra invertida
Vamos ver um exemplo de utilização do caractere de espaço em uma string:
*/

string semestre = "Janeiro\nFevereiro\nMarço\nAbril\nMaio\nJunho";
Console.WriteLine(semestre);

/*
Note que a string semestre contém um texto com os seis primeiros meses do ano separados pelo caractere de escape \n, que ao ser processado, 
insere uma quebra de linha. Portanto, teremos como saída o seguinte:

Recorte do console da aplicação exibindo os meses Janeiro, Fevereiro, Março, Abril, Maio e Junho.
Muito bem, mas afinal, o que são as verbatim strings? Elas são uma forma de trabalhar uma string ignorando os caracteres de escape. Por exemplo, 
na representação de caminhos de diretórios:

string diretorio = "C:\\temp\\codigo";
Console.WriteLine(diretorio);// C:\temp\codigo
No trecho apresentado acima, utilizamos o caractere de escape \\, duas barras invertidas usadas para representar os níveis de diretórios no 
sistema operacional Windows. Mas e se quisermos informar a string da forma que se apresenta no ambiente Windows, ou seja, 
atribuir o valor C:\temp\codigo à variável diretorio?

Podemos escrever a mesma atribuição usando a verbatim string utilizando o caractere @ antes das aspas duplas, como mostrado abaixo:

string diretorio = @"C:\temp\codigo";
Console.WriteLine(diretorio);// C:\temp\codigo
Assim o texto vai ser considerado conforme a atribuição da variável, com espaços ou quebras de linhas.

string alura = @"Mergulhando
em
tecnologia
com 
Alura.";
Console.WriteLine(alura);

Recorte do console da aplicação exibindo a mensagem “Mergulhando em tecnologia com a Alura”, com a quebra de linha após cada palavra.
Métodos e propriedade para strings
Agora vamos explorar um pouco dos recursos da classe string, entendendo suas principais propriedades e métodos e ver o que podemos aplicar no dia a
dia de desenvolvimento das nossas aplicações com C#.
*/

//Length: essa é uma propriedade que nos retorna a quantidade de caracteres de uma determinada string. Por exemplo:

var texto = "Entendendo strings em C#.";
Console.WriteLine(texto.Length);//25

//Método Join: permite concatenar duas strings separados por um delimitador, que ser informado previamente. Veja um exemplo:

var texto1 = "Manipulando";
var complemento = "strings com C#";
var resultado = String.Join(" ", new String[] { texto1, complemento });
Console.WriteLine(resultado);

//Neste código foi feita a junção da variável texto com a complemento, usando como caractere o espaço informado no primeiro parâmetro do .Join().

//Método Split: divide uma string com base em um delimitador e as strings divididas são armazenadas em um array de string. Vamos a um exemplo:

var mensagem1 = "vamos, dividir, esta mensagem, com base, na vírgula";
string[] _split = mensagem1.Split(",");
for (int i = 0; i < _split.Length; i++)
{
    Console.WriteLine($"{_split[i]}");
}

//Métodos IndexOf e LastIndexOf: conseguimos localizar o índice de determinada ocorrência de uma string em uma cadeia de caracteres,
//sendo o .IndexOf() para encontrar a primeira ocorrência e .LastIndexOf() a última.

//É importante ressaltar que podemos entender uma string como sendo um array de caracteres (char), como característica de arrays em C# temos a sua
//manipulação através de índices, que iniciam em zero. Por exemplo, a string “Alura” tem em seu índice zero o caractere ‘A’ e assim sucessivamente.

string mensagem2 = "Entendendo como manipular strings com C#.";
Console.WriteLine("Primeira ocorrência do caractere {e} = " + mensagem2.IndexOf("e"));
Console.WriteLine("Última ocorrência do caractere {e} = " + mensagem2.LastIndexOf("e"));

//Ambos os métodos citados, podem receber um segundo parâmetro, para realizar uma pesquisa sensível a letras maiúsculas, minúsculas ou com base no
//idioma e cultura.

Console.WriteLine("Primeira ocorrência do caractere {e} = " + mensagem.IndexOf("e",StringComparison.CurrentCulture));

//Métodos Replace: permite substituir parte de uma string por outra e isso pode ser útil em diversas situações. É muito utilizado quando precisamos
//atualizar partes específicas de um documento. Vamos a uma pequena demonstração:

string frase = @"Exelentíssimo _nomeasubstituir_ 
Estamos a sua espera para a conferência anual de .NET do Vale do Sílicio.";
Console.WriteLine(frase.Replace("_nomeasubstituir_","Bill Gates"));

//Ou seja, o que deve ser passado como parâmetro para o método é a string a ser substituída e o novo valor, em uma sintaxe igual a .Replace(antigo,novo).

/*
Métodos Substring

O objetivo deste método é nos permitir extrair uma string de outra. Podemos pensar que o sistema gera uma string de maneira aleatória e ela 
será usada como identificador do sistema. Porém, como regra de negócio, só queremos os 8 primeiros caracteres. Então, podemos usar o substring
para atender a esse objetivo.

Para obter uma string de forma aleatória em C# podemos usar a estrutura (struct) Guid, da seguinte forma:

string chave_aleatoria = Guid.NewGuid().ToString();
O Guid é uma sequência numérica de 16 bytes (128 bits) usada por computadores e redes para criar um identificador exclusivo. Quando 
invocamos o .NewGuid() é retornado esse identificador, que convertemos para string através do método .ToString(). Por fim, teremos uma 
cadeia de caracteres no formato 1bedd8e9-0d76-414d-80bb-9638ff242979.

Ok, mas como capturar somente os 8 primeiros caracteres? Podemos fazer isso com o substring():
*/

string chave_aleatoria = Guid.NewGuid().ToString();
Console.WriteLine("Identificador gerado = "+ chave_aleatoria.Substring(0,8));

/*
Na utilização do .substring() devemos informar o ponto inicial e o final para a extração da string desejada.

Métodos Equals

Quando queremos comparar se duas strings são iguais, o método a ser usado é o .Equals(). Pense que você, por exemplo, precisa saber se uma palavra “asa” , ou a frase “amor a roma” é um palíndromo ( palavras ou frases que conseguimos ler tanto da esquerda para a direita quanto da direita para a esquerda e ela soará da mesma forma). Para isso, precisaremos fazer uma comparação usando o .Equals().

Precisaremos capturar a string informada pelo usuário, o que conseguiremos usando o seguinte trecho de código:
*/

Console.Write("Informa palavra: ");
string palavra = Console.ReadLine();
//Agora será necessário reverter a palavra informada e salvá-la em uma variável para comparação. Neste momento usaremos o método de extensão
//.Reverse() associado a coleções e arrays, transformando isso em uma string da seguinte forma:

var palavrainvertida = new string(palavra.Reverse().ToArray());

//Para verificar se as palavras são iguais, utilizaremos o .Equals() que retorna verdadeiro ou falso. Sendo assim, vamos criar um if:

if (palavra.Equals(palavrainvertida))
{
    Console.WriteLine("Palavra informada é palíndromo.");
}
else
{
    Console.WriteLine("Palavra informada não é palíndromo.");
}

/*
Vamos testar? Executando o código e testando com a frase “amor a roma”:

Console da aplicação exibindo que foi informada a frase “amor a roma” e exibindo a mensagem “Palavra informada é palíndromo”.
Para trabalharmos com string em C#, ainda temos a disposição outros métodos, como:

.Insert() - que insere uma string em outra de acordo com o índice informado, exemplo: texto.Insert(5,”Texto Inserido”).
.Concat() - uma outra forma de fazer a concatenação de strings. ”André”.Concat(“Silva”).
.Trim() - este método remove os espaços em branco no fim e início de uma string, e temos suas variantes .TrimEnd() e .TrimStart(), métodos úteis para aplicarmos em formulários de cadastro por exemplo.
string nome= “    Amarildo Coelho”;
Console.WriteLine(nome.Trim());//Amarildo Coelho.
.ToUpper() e .ToLower() - Métodos que permitem colocar uma string toda em maiúscula ou minúscula respectivamente. Um exemplo:
var palavra = "Alura";
Console.WriteLine(palavra.ToUpper()); //ALURA
Console.WriteLine(palavra.ToLower()); //alura
StringBuilder
Como já foi mencionado, as strings são objetos imutáveis e sempre que as manipulamos alocamos um novo espaço em memória, criando novos objetos. Isso inclusive pode implicar na performance da aplicação.

Porém, temos a classe StringBuilder como uma alternativa, pois com ela podemos manipular strings em memória em operações de inserção, remoção e concatenação de forma mais eficiente e sem criar novos objetos.

Uma outra vantagem de trabalhar com StringBuilder é a manipulação de strings complexas ou que demandariam um número grande de concatenações. Vejamos um exemplo usando string:

string comandoSQL = "UPDATE FILMES SET NOME=@nome," +
                     "CLASSIFICACAO=@classificacao," +
                     "DIRETOR=@diretor," +
                     "ESTUDIO=@estudio," +
                     "DURACAO=@duracao " +
                     "WHERE ID=@id ";
Agora usando o StringBuider:

var comandoSQL = new StringBuilder();
comandoSQL.Append("UPDATE FILMES SET NOME=@nome,CLASSIFICACAO=@classificacao,DIRETOR=@diretor,ESTUDIO=@estudio,DURACAO=@duracao ");
comandoSQL.Append("WHERE ID=@id ");
O exemplo anterior tem como objetivo final montar uma string de um comando SQL, mas usando somente string, precisamos concatenar e interpolar. Dependendo do tamanho da string, isso pode ser trabalhoso. Usando a segunda opção, o trabalho fica mais intuitivo e com uma performance melhor, inclusive, facilitando futuras manutenções.

Conclusão
Neste artigo tivemos uma visão geral de como trabalhar com strings em C#, passando pelos seus principais métodos e entendendo sobre a imutabilidade deste objeto.

Manipular textos via programação é uma atividade recorrente para uma pessoa que desenvolve em C#, daí importância de conhecer as strings e suas possibilidades. E aí, curtiu? Bora programar manipulando strings?
*/