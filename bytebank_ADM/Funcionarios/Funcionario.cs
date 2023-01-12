namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } // visibilidade protected permite que o método seja acessível na própria classe e em suas derivadas

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcionário");
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public abstract double GetBonificacao(); // o virtual significa que o método pode ser sobrescrito em outra classe
        //{
        //    return this.Salario * 0.1; // bonificação corresponde a 10% do salário
        //}

        public abstract void AumentarSalario();
        //{
        //    this.Salario *= 1.1;
        //}
    }
}