namespace bytebank.Exceções
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
        }
    }
}