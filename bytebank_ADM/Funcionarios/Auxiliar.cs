﻿using bytebank_ADM.Funcionarios;

public class Auxiliar : Funcionario
{
    public Auxiliar(string cpf) : base(cpf, 2000)
    {
    }

    public override void AumentarSalario()
    {
        Salario *= 0.10;
    }

    public override double GetBonificacao()
    {
        return Salario * 0.2;
    }

    ~Auxiliar()
    {
        Console.WriteLine("Liberando recursos...");
    }
}
