/*
No dia a dia, sempre que possível, procuramos estabelecer alguns padrões para facilitar 
o entendimento e organização de informações, algo que fazemos naturalmente, afinal 
estamos sempre buscando uma forma de otimizar a nossa rotina.

Dentro da área de Programação, também há essa preocupação em melhorar e otimizar 
informações, vide os padrões de programação, estruturas de dados e algoritmos. Mas, 
na rotina de uma pessoa programadora, em algum momento ela irá se deparar com a 
necessidade de trabalhar com cadeias de caracteres e buscar identificar padrões 
para extrair informações ou validar algum tipo de dado.

Neste contexto, hoje temos as chamadas expressões regulares, ou o termo abreviado 
do inglês, regex. Mas o que são? Onde vivem? De que se alimentam? Consigo usar com .NET?
Neste artigo vamos conversar um pouco sobre elas. Vamos à leitura!

O que é uma expressão regular?
Vamos a algumas definições:

De acordo com Alfredo Lotar, autor do livro “Como programar com ASP.NET e C#", uma 
expressão regular define combinações de caracteres que podemos usar para representar 
partes de uma string.

Já para Cláudio Ralha, autor do livro Produtividade com C# da Casa do Código:

Expressões regulares são ferramentas para executar com pouco código tarefas complexas, 
como localizar e remover várias ocorrências de sequências de caracteres dentro do texto,
validar dados informados pelos usuários que estão em um formato específico.

Então, podemos concluir que uma regex vai definir uma forma de identificar padrões em 
cadeias de caracteres (strings) e que podemos usá-la para validações de dados.

Um pouco de história
A história das expressões regulares está intimamente ligada à teoria da computação, 
pois ela faz parte da teoria dos automatos e linguagens formais. As regex foram 
desenvolvidas nos estudos do matemático americano Stephen Cole Kleene, que a 
princípio chamava de álgebra de conjuntos regulares.

Os trabalhos de Kleene foram a base para a criação de algoritmos de busca usados na 
computação. Hoje, aplicamos as regex em editores de texto, em funções de busca e 
substituição, e nas linguagens de programação como forma de validação de formatos de 
textos. Por exemplo: quando precisamos validar o formato do campo e-mail de um 
formulário, podemos usar: /^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i;.

Então, em resumo, as regex podem ser aplicadas em situações de:

Mecanismos de validação de dados de formulários;
Encontrar um texto específico em uma string;
Representação de padrões. Por exemplo: os números em um CPF.

Ok, mas como funcionam as regex?

Quando usamos regex, a busca pelo caractere, string ou padrão de texto é feita da 
esquerda para a direita, da mesma forma como lemos um texto (pelo menos de acordo 
com a leitura ocidental). Essa busca pode ser feita em uma única linha ou em várias
delas, além de poder diferenciar letras maiúsculas e minúsculas e inclusive ignorar 
espaços em branco.

Na definição de uma regex podemos utilizar dois tipos de caracteres: os literais, usados normalmente em strings, e os metacaracteres, que fazem com que a regex possa processar e manipular informações. Compilamos alguns metacaracteres na tabela a seguir:

Meta	            Descrição
*	    Indica nenhuma ou várias ocorrências de um caractere
+	    Repete pelo menos uma vez um caractere. Exemplo: /a+/
^	    Indica que a pesquisa será feita no início do bloco ou regra
$	    Sinaliza que a pesquisa será feita no fim do bloco ou regra
?	    Usado para declarar um caractere como opcional
|	    Atua como o operador lógico ou
‘	    Usado para indicar um caractere
()	    Usado para agrupar uma sequência. Exemplo: /(abc)/
 
Além deles, as regex também permitem trabalhar com agrupamentos, que podem nos ajudar a 
criar sub-expressões. Para definir grupos, podemos utilizar (). Na sequência, listamos 
alguns:

Grupos	            Descrição
[aeiou]	        Considera combinações de vogais
{n}	            Indica a quantidade de números retornados
[a-zA-Z_0-9]	Considera letras maiúsculas e minúsculas e números
{n,m}	        Indica um intervalo
 
Vale a pena destacar que criar uma sentença regex fazendo uso dos símbolos e 
metacaracteres disponíveis pode ser extremamente trabalhoso. Dividir uma expressão
em partes pode nos ajudar, no melhor estilo “dividir para conquistar”.

Por exemplo: se quisermos selecionar todas as letras e números de um texto, podemos 
escrever uma expressão que escolha os números [0-9], depois escrever a que seleciona 
as letras [a-zA-Z]. Por fim, juntamos as partes da expressão como [0-9][a-zA-Z].

Até aqui vimos que dentre as vantagens na utilização das regex temos a flexibilidade, 
a performance e a facilidade de uso. Mas após entender a teoria, como podemos fazer o 
uso das regex com o C#? Para isso precisamos utilizar uma classe Regex - e é isso que 
vamos conhecer no próximo tópico!

A classe Regex
No .NET a principal classe para trabalhar com regex é a de mesmo nome, Regex, que se 
encontra no namespace System.Text.RegularExpressions. Ela possui uma série de métodos 
estáticos que nos possibilitam trabalhar com expressões regulares. Por exemplo, se 
quisermos validar se o valor informado por um usuário é composto somente por números, 
podemos fazer o seguinte:
*/

using System.Text.RegularExpressions;

Console.Write("Informe um valor:  ");
var caracteres = Console.ReadLine();

bool ok = Regex.IsMatch(caracteres, "^[0-9]+$");
if (!ok)
{
    Console.WriteLine("O valor informado não é um numérico válido.");
}
else
{
    Console.WriteLine("O valor informado é válido.");
}

/*
Podemos ainda criar um objeto do tipo Regex que recebe em seu construtor um caractere 
ou uma expressão composta pelos metacaracteres. Também é possível informar um segundo 
parâmetro definindo como fazer essa busca.

Imagine que você precisa validar um CPF de usuário. Ao invés de criar todo um algoritmo,
por que não usar uma regex? Observe como poderia ser implementado: 
 
 
*/

Console.Write("Informe um cpf para validação: ");
var cpf = Console.ReadLine();

Regex regex = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnoreCase);
var combinou = regex.Match(cpf);
if (combinou.Success)
{
    Console.WriteLine("CPF no formato válido.");
}
else
{
    Console.WriteLine("CPF inválido.");
}

/*
Executando o código acima, o usuário informa um CPF contendo somente números ou com a 
máscara com pontos, criado um objeto da classe Regex que recebe como parâmetro uma 
expressão para CPF e uma enumeração com o valor de IgnoreCase, que diferencia maiúscula 
de minúscula.

Ao executar o método .Match() do objeto, validamos o CPF com a regex definida na 
criação do objeto. Para isso, é importante trabalharmos o retorno criando um objeto do
tipo Match. 
 
Abaixo apresentamos algumas opções da enumeração RegexOptions que podemos usar quando 
criamos nossos objetos regex:

Valor	                         Descrição
IgnoreCase	                Para ignorar maiúsculas ou minúsculas
CultureInvariant	        Não considerar idiomas
Multiline	                Realizar a pesquisa em múltiplas linhas
SingleLine	                Realizar a pesquisa em uma única linha
RightToLeft	                Realizar a pesquisa da direita para esquerda
IgnorePatternWhitespace	    Ignorar padrões com espaço em branco


Usando o .IsMatch()
Com o IsMatch podemos validar se um valor informado combina com a expressão regular 
definida. O retorno do método é um booleano e recebe como parâmetro uma string. Usando
o mesmo exemplo do CPF, temos:
*/

Console.Write("Informe um cpf para validação: ");
var cpf1 = Console.ReadLine();

Regex regex1 = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnorePatternWhitespace);
if (regex.IsMatch(cpf1))
{
    Console.WriteLine("CPF válido.");
}
else
{
    Console.WriteLine("CPF inválido.");
}

/*
Usando o .Match()
Este método pode ser usado para buscar uma string ou expressão regex definida na classe.
Por exemplo:
*/

var busca = "Mergulhando em tecnologia com a Alura.";
Regex regex2 = new Regex("Alura", RegexOptions.IgnoreCase);
Match match = regex2.Match(busca);
if (match.Success)
{
    Console.WriteLine("string encontrada no texto.");
}
else
{
    Console.WriteLine("string não encontrada.");
}