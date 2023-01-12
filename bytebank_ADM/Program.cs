using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region Aula 1 - Sobrecarga e Polimorfismo
/* 
Nessa aula temos um exemplo de sobrecarga e polimorfismo com o método Registrar, que pode receber parâmetros diferentes

Podemos ter comportamentos definidos em uma classe que funcionem diferentemente dependendo dos parâmetros que receberem. Definimos uma 
sobrecarga que registra o total de bonificação para objetos do tipo funcionário e para diretor, o que se encaixa num conceito deste modelo
de programação.
*/
//Funcionario pedro = new Funcionario();
//pedro.Nome = "Pedro Silva";
//pedro.Cpf = "1234567891";
//pedro.Salario = 2000;

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor();
//roberta.Nome = "Roberta Silva";
//roberta.Cpf = "9876543212";
//roberta.Salario = 5000;

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
#endregion

#region Aula 2 - Herança
/*
Para evitar repetição de código e até melhorar o desempenho, é possível utilizar a herança, que é um mecanismo na qual uma classe
herda uma superclasse ou classe base.

No C#, utilizamos : nome da superclasse para herdá-la
 
Veja um exemplo na classe Diretor, que está herdando Funcionario

Classe base: contém as características que servirão de base para uma outra classe, em algumas literaturas também são chamadas de superclasses;

Classe derivada: herda as características e comportamentos da classe base. Esse tipo de classe também é conhecida como subclasse.

Para sobrescrever métodos que existem em uma classe herdada, usamos o override na classe que herdou o método e virtual na classe base/superclasse.

Usamos a palavra base para acessar implementações existentes na superclasse ou classe base, as "originais".
*/
#endregion

#region Aula 3 - Construtor da classe base
/* 
Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);

Note que ao criar a diretora Roberta foi printado na tela  "Criando um funcionário" e depois "Criando um diretor".
Isso ocorre porque ao herdar uma classe, executa-se primeiro o construtor da classe base e depois da classe derivada.

Quando não definimos explicitamente um construtor na classe, o .NET vai utilizar o construtor padrão, que tem o mesmo nome 
da classe e não recebe parâmetros;

Podemos aplicar os modificadores de acesso (visibilidade) aos construtores, como private ou protected, para a execução de uma tarefa
específica ou para não permitir que a classe gere instâncias (objetos);

Quando definimos explicitamente um construtor na classe, ele assume o lugar do construtor padrão;

O construtor também é um método, portanto, podemos aplicar sobrecargas sobre ele. Assim, é possível haver mais de um construtor definido
em uma mesma classe e cada um deles vai se diferenciar de acordo com sua assinatura (conjunto tipo de retorno e listagem de parâmetros que recebe).

Em contraposição aos construtores, temos o método destrutor, que é invocado no momento de “destruir” um objeto de uma classe. O método traz algumas
características interessantes:

    Uma classe possui somente um método destrutor;
    Diferentemente dos construtores, ele não pode ser herdado nem sobrecarregado;
    Ele é invocado automaticamente;
    Não aplicamos modificadores de acesso ou parâmetros ao destrutor;
    Tem o mesmo nome da classe e é precedido do caractere ~.

Exemplo de código de um método destrutor na classe "Auxiliar"

Um detalhe importante é que a pessoa que desenvolve, a princípio, não controla a execução do método destrutor, o que fica sob a responsabilidade
do coletor de lixo (garbage collector) do .NET, que identifica o momento mais oportuno para liberar a memória limpando os objetos inutilizados.

É possível forçar a execução do coletor de lixo usando o comando GC.Collect(), porém fazer chamadas excessivas ao coletor é uma prática pouco
recomendada, pois reflete de maneira negativa na performance do programa.

SOBRE O GARBAGE COLLECTOR

Mesmo trabalhando com linguagens orientadas a objetos, como o C# , é importante ter atenção ao consumo de recursos computacionais, 
como a memória, para a nossa máquina continuar com espaço. Essa atenção é necessária porque quando precisamos criar vários objetos no sistema,
por exemplo, eles podem ficar armazenados na memória.

Porém, pode acontecer de executarmos o programa e algum espaço na memória ser liberado. Isso significa que não somos nós quem controlamos
explicitamente o armazenamento. Mas, então, quem controla? A resposta é o coletor de lixo, ou garbage collector.

O garbage collector é um recurso presente na plataforma .NET que, de forma automática, se encarrega de remover da memória os objetos que
não estão sendo mais utilizados pela aplicação. Isso facilita o trabalho da pessoa que desenvolve porque ela não precisa se preocupar com
esse gerenciamento.

A máquina virtual do .NET, a CLR (Common Language Runtime), fica encarregada de detectar dentro do programa em execução quando um objeto não
é mais utilizado, descartando-o.
*/
#endregion

#region Aula 4 - Construtor base com parâmetros
/*
É importante destacar que um construtor de uma classe derivada deve ter os parâmetros do construtor da classe base.
Sendo que na frente da definição do construtor derivado deve ter :(base ...parametros). Veja em Diretor.
*/

//Funcionario pedro = new Funcionario("1234567891", 2000);
//pedro.Nome = "Pedro Silva";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("9876543212");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
#endregion

#region Aula 5 - O Modificador
//pedro.AumentarSalario();
//roberta.AumentarSalario();
//Console.WriteLine("Novo Salário Pedro: " + pedro.Salario);
//Console.WriteLine("Novo Salário Roberta: " + roberta.Salario);
#endregion

#region Aula 6 - Classes abstratas
CalcularBonificacao();

/*
Temos os cargos de diretor, designer, gerente de contas e auxiliar. Não existe mais um cargo chamado "funcionário" propriamente dito. 
A classe Funcionario é uma abstração, um conceito genérico, em que definimos as propriedades e comportamentos de todos os funcionários. 
Ela é um modelo para construção de outras classes.

Ou seja, não faz mais sentido criar diretamente um funcionário, por exemplo:

Funcionario pedro = new Funcionario("123456", 852);

Definir Pedro como funcionário é muito genérico, precisamos que ele tenha um cargo — ou gerente de contas, ou auxiliar, ou diretor, ou designer. 

Apesar dessa construção não fazer mais sentido em nosso projeto, ela ainda é possível e não resultaria em um erro do programa. 
Logo, é preciso sinalizar ao compilador que não é mais permitido criar objetos do tipo Funcionario, porque essa classe representa uma abstração. 
Ao criar um funcionário, ele deverá ser Auxiliar, ou Designer, ou Diretor, ou GerenteDeContas.

Classes abstratas
Para nosso programa reconhecer essa abstração, modificaremos o arquivo Funcionario.cs. Vamos transformar a classe Funcionario em uma classe abstrata,
adicionando a palavra abstract em sua definição:

Dessa forma, o compilador compreenderá que a classe Funcionario é uma abstração. A partir de agora, como é impossível instanciar um objeto a partir de
uma classe abstrata, a seguinte construção resultará em um erro

Sendo assim, conseguiremos instanciar objetos de classes concretas herdeiras de Funcionario (como Diretor e Auxiliar), mas seremos impedidos de criar
um objeto do tipo Funcionario diretamente.
*/
#endregion

#region Aula 7 - Métodos Abstratos
/*
Na classe Funcionario, temos os métodos GetBonificacao() e AumentarSalario(). Como Funcionario passou a ser uma abstração, esses métodos não
têm mais implementação nessa classe. Apesar disso, eles precisam obrigatoriamente estar presentes nas classes herdeiras e ter suas implementações
concretas em Diretor, GerenteDeCompras, Auxiliar e Designer, por exemplo.

Logo, na classe Funcionario, transformaremos GetBonificacao() e AumentarSalario() em métodos abstratos. Em suas definições, vamos substituir
a palavra "virtual" por "abstract":

Ao fazer essa substituição, o compilador alegará erros nos dois métodos, porque métodos abstratos não têm implementação. Em outras palavras, 
eles têm apenas uma assinatura (o nome com o tipo de retorno), não devemos abrir chaves e incluir um bloco de código. Basta colocar a assinatura
do método e finalizar com ponto e vírgula:

Definimos os métodos GetBonificacao() e AumentarSalario() são abstratos. Dessa forma, toda classe que herde de Funcionario terá a obrigação de implementar esses comportamentos.

Quanto ao construtor, ele também será abstrato? É importante ressaltar que, apesar de uma classe ser abstrata, podemos definir tanto métodos abstratos quanto não-abstratos nela. No caso, o método construtor de Funcionario não será abstrato. Não vamos modificá-lo.

Após salvar as alterações, voltaremos ao arquivo Program.cs. Vamos reparar que não surgiu nenhum erro nele, pois todas as classes herdeiras estão
implementando corretamente o GetBonificacao() e o AumentarSalario().
*/
#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer joao = new Designer("1234567898");
    joao.Nome = "João";

    Diretor paula = new Diretor("2546958715");
    paula.Nome = "Paula";

    Auxiliar gil = new Auxiliar("4567891233");
    gil.Nome = "Gil";

    GerenteDeContas camila = new GerenteDeContas("2589637411");
    camila.Nome = "Camila";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(gil);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(joao);

    Console.WriteLine("Total de bonificação = " + gerenciador.TotalDeBonificacao);
}