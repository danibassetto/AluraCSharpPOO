namespace ModuloCliente
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string? Email { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, \n" +
                   $"Email: {this.Email}, \n" +
                   $"Idade: {this.Idade}, \n" +
                   $"Cpf: {this.Cpf}";
        }
    }
}