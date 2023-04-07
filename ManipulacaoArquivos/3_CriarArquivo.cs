using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        //using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456, 65465, 456.0, Pedro");
        }

        /*
         O CreateNew é responsável por criar um arquivo somente se não houver nenhum outro arquivo com o mesmo nome dentro do diretório em questão. 
        No caso, já tínhamos o arquivo contasExportadas.csv na pasta, então o CreateNew lança uma exceção.Em outras palavras, o CreateNew deve ser usado para criar arquivo 
        que ainda não existem. Se ele já existe e a intenção é substituí-lo, optaremos pelo Create

        Using:
        A instrução using define um limite para o objeto fora do qual, o objeto é destruído automaticamente. A instrução using é encerrada ao final do bloco de instruções
        "using" ou quando a execução sai do bloco indiretamente, por exemplo - quando uma exceção for lançada. A instrução using garante que uma instância descartável seja descartada mesmo 
        que ocorra uma exceção dentro do bloco da instrução using. 
        */
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");

                /*
                Em que momento, de fato, nossa informação é passada para o HD? Quando estamos escrevendo em um arquivo, 
                o que acontece internamente entre a nossa aplicação, nosso sistema e o nosso dispositivo externo?
                Ao escrever algo no HD, paramos a nossa aplicação e uma mensagem é enviada ao sistema operacional para 
                que ele escreva o número de bytes nos HD. Esse tempo de envio e recebimento tem uma alta latência, ou seja,
                é um pouco demorado.
                Até agora, estamos acostumados a trabalhar com variáveis, buffer, arrays e listas. Nesses casos, sempre 
                usamos memória RAM, que é bastante rápida — diferentemente do HD. Para escrevermos no HD (ou no SSD, que 
                funciona da mesma forma), o processo é mais lento, principalmente quando perdemos tempo notificando o 
                sistema operacional dessa ação que queremos executar.
                Sempre que utilizamos o WriteLine para escrever no arquivo, perdemos bastante tempo. O StreamWriter 
                possui um buffer. No caso do WriteLine, não estamos escrevendo no arquivo, de fato. Na verdade, enviamos
                determinada informação para o buffer do StreamWriter. Enquanto não encerramos o buffer interno do
                StreaamWriter, a informação não é despejada no FilStream, tornando o processo mais demorado. 
                Para economizar tempo, temos algumas ferramentas à disposição.
                No contexto desse treinamento, se a escrita for demorada, não é um problema. Contudo, haverá situações em 
                que precisaremos que a escrita no arquivo seja mais rápida e imediatamente no HD — por exemplo, um log que 
                dita os processos de uma aplicação. Nesses casos, a demora pode ser prejudicial, já que acompanhamos o log 
                para resolver possíveis quebras no programa. Se a informação demora para chegar até nós, isso é problemático.
                É necessário saber lidar com esses obstáculos e trabalhar de maneira rápida com informações que precisamos 
                colocar em um arquivo.
                Em resumo, há cenários em que é interessante evitar o uso do buffer para não ocorrer essa demora na escrita.
                Nesses casos, podemos usar o método Flush, responsável por despejar o buffer para a stream. Ou seja, ele 
                evita o processo de guardar o buffer para, depois, mandar para o FileStream.
                Em TestaEscrita, após o WriteLine, vamos aplicar o método Flush:                
                */

                escritor.Flush(); //Despeja o buffer para o Stream

                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }
}