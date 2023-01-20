/*
Quando estamos nos aprofundando no aprendizado de alguma linguagem de programação, 
por vezes nos deparamos com algumas características bem singulares, específicas de uma 
determinada linguagem e a outras que são comuns a várias, como, por exemplo, os tipos de
estrutura de dados disponíveis. Em linguagens orientadas a objetos a estrutura mais 
utilizada sem sombra de dúvidas são as classes.

Mas será que sempre a melhor estrutura a ser criada será uma classe? Qual o custo 
computacional na utilização de uma classe em comparação a um tipo de valor?

No C#, como na linguagem C, existe um tipo de estrutura, que inclusive é 
muito utilizada pelo próprio framework .NET, mas que não possui todo o 
“glamour” das classes. Estamos falando das structs, que podem ser de grande 
ajuda para criarmos códigos para trabalhar pequenos conjuntos de dados.

Mas como criamos uma estrutura? Em quais situações devo utilizar? E, a clássica 
pergunta: usar classes ou structs? No texto a seguir, responderemos a alguns 
destes questionamentos.

O que são classes?
As diversas literaturas técnicas disponíveis definem a classe como sendo um 
molde para a criação de objetos. Uma definição bem interessante é a do Everton Araújo, 
autor do livro Orientação a Objetos em C#, da Casa do Código. Para Araújo, uma classe 
"é um conjunto ou um conjunto de objetos que compartilham de propriedades e 
métodos em comum."

Mas este conceito de classes e objetos nos leva ao paradigma de programação da 
orientação a objetos, que é um estilo de pensar e programar um software levando em 
consideração aspectos da nossa realidade, como, por exemplo, um carro, uma pessoa 
ou mesmo conceitos mais abstratos como uma conta bancária.

Então, com base nessas definições imagine que você está lendo um determinado livro, 
para ser mais exato o livro do Everton Araújo. Esse livro é um objeto, correto? 
Quantas páginas este livro tem? Todo livro possui algumas características como título, 
editora, autor, número de páginas, entre outras. Podemos ir além e expandir essas 
características a outros objetos que se classificam como livros, certo? Se sim, podemos 
criar uma classe que irá conter tais características. Note a classe livro, criada neste
projeto.
*/

using AulaStructsEClasses;

Livro livro = new Livro()
{
    Titulo = "Orientação a Objetos em C#",
    Autor = "Everton Araújo",
    NumeroPaginas = 236,
    AnoPublicacao = 2020,
    PossuiISBN = true,
    ISBN = "978-65-86110-00-5"

};

/*
Bacana! Mas existe outra forma de representar uma estrutura de dados que não seja uma 
classe? Sim! O C# possui as chamadas Structs, que em determinadas situações podem ser 
usadas no lugar das classes.

Mas, afinal, o que são Structs?
As structs, muito comuns na linguagem C, têm como objetivo estruturar alguns dados 
comuns a um mesmo contexto, bem parecida com a ideia de classes. No C#, uma struct é 
semelhante a uma classe, porém esta é definida como sendo um tipo de valor enquanto 
a classe é um tipo de referência. Note o struct Pessoa criado neste preojeto.
 
Uma struct é muito útil para aquelas situações nas quais precisamos de poucas variáveis, pois os objetos criados com base em structs são mais leves e por ser do tipo de valor não trabalham com referências.

Uma struct pode possuir construtores, campos, propriedades, métodos, indexadores. Uma 
struct pode ainda implementar uma interface, porém não existe herança entre structs. 
Para utilizar um objeto criado com base em uma estrutura, podemos fazer:
*/

Pessoa pessoa = new();
pessoa.Cpf = "111.111.111-66";
pessoa.Nome = "André Silva";
pessoa.Email = "andre@email.com";
pessoa.Idade = 36;

/*
Ou seja, da mesma forma como criamos uma classe.

Resumindo as características das structs:

É um tipo de valor.
Quando definido o construtor o mesmo deve possuir parâmetros.
Não é possível iniciar um campo a não ser por seu construtor.
Uma struct não pode ser a base de uma outra struct ou classe. 
 
Usar classes ou struct?
Mas quando usar classe ou struct?Uma struct possui sintaxe e definição similar a uma 
classe com algumas limitações mas mesmo assim de fácil entendimento e implementação. 
Para responder se devemos usar classes ou struct vamos voltar a falar de tipo de valor
(value-type) e por referência (reference-type).

No geral, o compilador trabalha com duas grandes áreas na memória para a manipulação 
dos dados: stack e heap. 
A área que define a stacké bem menor em comparação a área do heap, e ambas trabalham 
como uma abstração de uma pilha ( o último que entra é o primeiro a sair), porém cada 
uma com um tipo de acesso distinto.

Quando criamos tipos de dados mais leves como os “tipos primitivos” e structs estes 
são armazenados diretamente na stack, por serem tipos que consomem pouco espaço em 
memória. A stack tem uma performance bem melhor na busca de dados em seu interior, 
por possuir um espaço menor. 

Contudo, o compilador não faz acesso direto a heap. Por que? A resposta é: por ser uma
área muito grande! E, no caso de procurar um objeto do tipo Livro, poderia levar um 
tempo considerável para otimizar o acesso a heap, por isso o processador faz uso da 
stack ( que é mais rápida e menor) para fazer essa jogada. O compilador cria uma 
referência na stack apontando para a memória heap onde está o objeto.

Esse espaço na memória stack que aponta para uma posição na heap é o que definimos 
como ponteiro, e na imagem usamos a notação de asterisco para identificar. Em resumo, 
declaramos um ponteiro na stack que guarda uma referência para uma posição na heap, 
daí a definição de tipo de referência (reference-type).

Tipos de referência são construídos usando a palavra reservada new que indica que um 
espaço na memória heap deverá ser reservada para um determinado objeto.

Lembre-se que structs são tipos de valor, ou seja são armazenadas na stack, e esta 
apesar de ser mais rápida, possui um espaço muito menor em comparação a heap. Portanto, 
as structs são indicadas para quando necessitarmos de um conjunto de dados menores.

Por exemplo, no código apresentado para a struct Pessoa, caso fosse necessário um 
grande número de propriedades e campos, e a instanciação de vários objetos do tipo 
Pessoa, é mais interessante que o mesmo seja criado como uma classe, para evitar o 
estouro da memória stack.

Vale lembrar que a biblioteca de classes do .NET também faz uso de structs para definir
uma série de tipos e funcionalidades, por exemplo os tipos como int, float ou bool são 
structs que herdam de uma classe base object.

Outro exemplo é a struct DateTime para trabalharmos a data e hora do sistema em nossas 
aplicações. Bem bacana não é?
*/