using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeByteslidos = -1;

            var buffer = new byte[1024]; // 1024 posições - 1KB

            // Devoluções do Read:
            // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
            // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
            //zero, se o final do fluxo for atingido

            while (numeroDeByteslidos != 0)
            {
                numeroDeByteslidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                Console.WriteLine($"Bytes lidos: {numeroDeByteslidos}");

                EscreverBuffer(buffer, numeroDeByteslidos);
            }

            // public override int Read(byte[] array, int offse, int count)
            //   armazena os trechos lidos (bytes) -- posição -- quantas posições quer preencher

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }

        // Em suma, o método using criará um try/catch para verificar se o fluxo é nulo. Caso não seja, chamaremos o método
        // Dispose, que internamente chamará o método Close. Assim, conseguimos evitar que futuras exceções ocorram e
        // prejudiquem o andamento do código.
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos); // traduz os numeros para o texto

        //public virtual string GetString(byte[] bytes, int index, int count);
        Console.Write(texto);

        //foreach (var meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}