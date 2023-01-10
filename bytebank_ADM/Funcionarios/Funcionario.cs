namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        
        public virtual double GetBonificacao() // o virtual significa que o método pode ser sobrescrito em outra classe
        {
            return this.Salario * 0.1; // bonificação corresponde a 10% do salário
        }
    }
}