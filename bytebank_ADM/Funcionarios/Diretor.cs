﻿namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        //public string Nome { get; set; }
        //public string Cpf { get; set; }
        //public double Salario { get; set; } --> após herdarmos a classe Funcionario, não precisamos mais desses atributos, pois ela já os contém.

        public Diretor(string cpf):base(cpf, 5000)
        {
            //Console.WriteLine("Criando um construtor"); 
        }

        //Ainda após a herança, mantemos o GetBonificação, pois não é igual ao implementado em Funcionario
        public override double GetBonificacao() // o override significa que o método foi sobrescrito
        {
            //return this.Salario + base.GetBonificacao(); // palavra base permite acessar implementações existentes na superclasse ou classe base
            return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}