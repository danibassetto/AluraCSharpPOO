using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region Aula 1 - Sobrecarga e Polimorfismo
/* 
Nessa aula temos um exemplo de sobrecarga e polimorfismo com o método Registrar, que pode receber parâmetros diferentes

Podemos ter comportamentos definidos em uma classe que funcionem diferentemente dependendo dos parâmetros que receberem. Definimos uma 
sobrecarga que registra o total de bonificação para objetos do tipo funcionário e para diretor, o que se encaixa num conceito deste modelo
de programação.
*/
Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Silva";
pedro.Cpf = "1234567891";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "9876543212";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
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