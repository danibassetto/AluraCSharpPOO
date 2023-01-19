using ModuloCliente;

Cliente cliente = new Cliente();
cliente.Nome = "André";
cliente.Cpf = "111.444.666-88";
cliente.Email = "andre@email.com";
cliente.Idade = 23;

Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Cpf);
Console.WriteLine(cliente.Idade);

Console.WriteLine(cliente.ToString());

/* 
Observando os metadados, notamos que a classe Object também tem alguns métodos disponíveis. Por exemplo, na linha 22, temos public virtual bool 
Equals(object? obj) — considerando nossos conhecimentos das regras de sobrecarga e sobrescrita, sabemos que esse método deve ser sobrescrito. 
Temos também GetHashCode(), GetType(), MemberwiseClone(), ReferenceEquals() e ToString().

Se nossa classe é um object, quer dizer que temos todos esses métodos disponíveis nela!
Todas as classes do . NET herdam explícita ou implicitamente da classe Object.

*/