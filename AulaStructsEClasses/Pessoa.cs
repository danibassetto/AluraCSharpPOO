namespace AulaStructsEClasses
{
    public struct Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}" +
                   $"Email: {this.Email}";
        }
    }
}
