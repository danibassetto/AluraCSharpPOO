using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }

        //public string Senha { get; set; }

        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}