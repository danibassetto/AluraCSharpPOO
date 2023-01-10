using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        // Podemos remover essa sobrecarga após a herança, visto que um diretor também se tornou funcionario
        //public void Registrar(Diretor diretor)
        //{
        //    this.TotalDeBonificacao += diretor.GetBonificacao();
        //}
    }
}