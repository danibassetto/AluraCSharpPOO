namespace bytebank_GeradorChavePix
{

    /// <summary>
    /// Classe que gera chaves Pix usando o formato Guid.
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Método que retorna uma chave Pix.
        /// </summary>
        /// <returns>Retorna uma chave Pix no formato String</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves Pix.
        /// </summary>
        /// <param name="numeroChaves">Quantidade de chaves a serem geradas</param>
        /// <returns>Retorna uma lista de Strings de chave Pix</returns>
        public static List<string> GetChavesPix(int numeroChaves)
        {
            if (numeroChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }

                return chaves;
            }
        }
    }
}

/*
O que é uma DLL (Dynamic Link Library)?

Uma DLL é uma biblioteca que contém código e dados que podem ser usados por mais 
de um programa ao mesmo tempo. Nosso objetivo com uma biblioteca é facilitar o 
desenvolvimento, deixando nossas aplicações mais componentizadas. Então, uma DLL vai 
conter uma série de códigos e dados para entregar uma funcionalidade específica no formato 
de um componente.

Qual a utilidade de uma DLL?

reaproveitamento de recursos
promove uma arquitetura modular
facilita a implantação
Então, podemos imaginar que temos os seguintes componentes: NewtonSoft, Modelos, 
Atendimento e GeradorPIX. Assim vamos componentizando a solução.

Um ponto importante é: o ByteBank Atendimento é o projeto que está usando essas 
dependências. Então, se estamos executando o projeto ByteBank Atendimento precisamos 
ter o componente de Modelos e NewtonSoft para gerar as funcionalidades desse projeto. 
Se não tivermos esses componentes o código não vai funcionar. A partir do momento que 
trabalhamos com componentização, vamos gerar uma certa dependência desses componentes. 

O summary é o que traz a descrição ao passar o mouse na função. Para que isso apareça
é necessário ir em Propriedades > Criar e habilitar "Arquivo de documentação, depois compilar 
novamente o projeto"
*/