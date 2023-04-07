namespace bytebank_ADM.Utilitario
{
    internal class AutenticacaoUtil
    // A partir do momento em que definimos essa classe com visibilidade internal, ela será visível somente dentro da própria biblioteca!
    // Em outras palavras, ela é uma classe interna, que só pode ser utilizada pelas classes dos nossos modelos.
    {
        public bool ValidarSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira.Equals(senhaTentativa);
        }
    }
}