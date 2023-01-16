using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public abstract bool Autenticar(string senha);
        //{
        //    return this.Senha == senha;
        //}

        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}