
namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            this.CPF = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        protected internal abstract double getBonificacao();

        // Agora, estamos permitindo que classes que herdem de Funcionario implementem
        // o método getBonificacao(), apesar de ele ser definido como interno da biblioteca.
        // Vale ressaltar que protected internal é a única combinação de visibilidades possível.
        // Não existe public internal nem private internal, por exemplo.
    }
}
