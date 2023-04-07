using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        #region Criação Arquivo
        //CriarArquivo();

        //CriarArquivoComWriter();

        //TestaEscrita();

        //Console.ReadLine();
        #endregion

        #region StreamWriter
        //var caminhoNovoArquivo = "TestaEscrita.txt";

        //using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        //using (var escritor = new StreamWriter(fluxoDeArquivo))
        //{
        //    escritor.WriteLine(true);
        //    escritor.WriteLine(false);
        //    escritor.WriteLine(454545454545);
        //}

        //Console.WriteLine("Aplicação Finalizada...");

        //Console.ReadLine();

        /*
         Na memória do nosso computador, o true e o false ocupam espaços pequenos — apenas 1 byte, pois trabalhamos com 0 
        ou 1. Já o número inteiro ocupa 4 bytes. Logo, atualmente estamos usando muito mais espaço que o necessário, 
        já que representamos as informações com texto puro, por exemplo, optando pelo texto "True" em vez de apenas 1.

        Usar a forma binária otimiza nossos arquivos, especialmente os mais extensos. Faremos alguns testes, 
        explorando métodos e classes disponíveis no .NET para representar informações de forma binária. Assim, 
        economizaremos espaço e otimizaremos a quantidade de memória utilizada no hardware.
         */
        #endregion

        #region BinaryWriter
        //EscritaBinaria();

        //LeituraBinaria();

        //Console.WriteLine("Aplicação Finalizada");
        //Console.ReadLine();
        #endregion

        #region Usando Stream da Console
        UsarStreamDeEntrada();

        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
        #endregion

        #region Auxiliares da classe File
        //var linhas = File.ReadAllLines("contas.txt");
        //Console.WriteLine(linhas.Length); // mostra a quantidade de linhas


        //foreach (var linha in linhas)
        //{
        //    Console.WriteLine(linha);
        //} // mostrando linha a linha


        //var bytesArquivo = File.ReadAllBytes("contas.txt");
        //Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes"); // exibe a quantidade de bytes

        //File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText"); // cria um arquivo e escreve nele o segundo parâmetro

        //Console.WriteLine("Aplicação Finalizada ...");

        //Console.ReadLine();

        /*         
        Todos os métodos que estudamos nessa aula facilitam nosso trabalho ao lidar com arquivos, porém é essencial ter 
        certos cuidados. Se quiséssemos ler todo o texto de um documento, por exemplo, uma opção seria o método ReadAllText. Ele retorna uma string com todo o conteúdo de um arquivo, porém essa prática vai contra nosso objetivo de não ler arquivos de uma única vez, especialmente se forem grandes. Para arquivos pequenos, esse método é uma boa opção.

        É importante avaliar cada contexto para optar pela melhor estratégia. Haverá casos em que será mais interessante ter um 
        controle mais preciso do buffer e das posições ocupadas nele, por exemplo. Por isso, é importante entendermos o 
        funcionamento dessas classes e desses métodos.          
        */
        #endregion
    }
}