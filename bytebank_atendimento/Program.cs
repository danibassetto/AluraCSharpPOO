using bytebank_GeradorChavePix;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChaves = GeradorPix.GetChavesPix(10);
foreach (var item in listaDeChaves)
{
    Console.WriteLine(item);
}


//public class Estagiario : Funcionario
//{
//    public Estagiario(double salario, string cpf) : base(salario, cpf)
//    {
//    }

//    public override void AumentarSalario()
//    {
//        throw new NotImplementedException();
//    }

//    protected override double getBonificacao()
//    {
//        throw new NotImplementedException();
//    }
//}