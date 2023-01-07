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