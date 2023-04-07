using bytebank.Modelos.Conta;

partial class Program
{
    static void UsandoStramReader()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine(); // atribui a linha, como não informamos, ele atribui a primeira

            //var texto = leitor.ReadToEnd(); // atribui todo o conteúdo, pode ser prejudicial se o arquivo for muito grande, pois ele carrega o arquivo de uma única vez

            //var numero = leitor.Read(); // traz o primeiro caracter em byte, que depois seria decodificado

            while (!leitor.EndOfStream) // EndOfStream é um boolean que indica se chegou ao fim do fluxo
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"\nTitular: {contaCorrente.Titular.Nome}\nNúmero: {contaCorrente.Numero_agencia}\nAgência: {contaCorrente.Numero_agencia}\nSaldo R${contaCorrente.Saldo.ToString("N2")}\n";
                Console.WriteLine(msg);
            } // exemplo de um carregamento realizado em partes, que é útil em casos mais complexos
        }

        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan
        var campos = linha.Split(',');

        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace('.', ','));
        var nomeTitular = campos[3];

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agencia, numero);
        resultado.Depositar(saldo);
        resultado.Titular = titular;

        return resultado;
    }

    /*
     Quando compilarmos e executarmos a aplicação, o programa entenderá que a classe Program está em vários arquivos e 
    pode ser trabalhada de uma forma única. Ela está separada apenas por questões de organização.

    Desse modo, o partial tornará o código mais simples e mais legível, tanto para nós quanto para outras pessoas programadoras
    que consultem nosso projeto, pois conseguimos dividir nossa classe para lidar com diferentes métodos em diferentes arquivos.

    Agora, podemos desenvolver mais códigos sem que haja excesso de informações na tela. Na sequência, aprenderemos a
    usar mais ferramentas que o C# nos oferece.
     */
}