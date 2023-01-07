namespace bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; } // propriedade autoimplementada
        public string Cpf { get; set; } // propriedade autoimplementada
        public string Profissao { get; set; } // propriedade autoimplementada
        public static int TotalClientesCadastrados { get; set; }
        public Cliente()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        } // construtor sem argumentos

    }
}