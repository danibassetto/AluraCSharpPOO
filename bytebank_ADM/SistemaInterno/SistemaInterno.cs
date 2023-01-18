using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        //public bool Logar(Diretor diretor, string senha)
        //{
        //    bool usuarioAutenticado = diretor.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Boas vindas ao nosso sistema");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta");
        //        return false;
        //    }
        //}

        //public bool Logar(GerenteDeContas gerenteDeContas, string senha)
        //{
        //    bool usuarioAutenticado = gerenteDeContas.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Boas vindas ao nosso sistema");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta");
        //        return false;
        //    }
        //}

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }        
        
        //public bool Logar(ParceiroComercial funcionario, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Boas vindas ao nosso sistema");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta");
        //        return false;
        //    }
        //}
    }
}