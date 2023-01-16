using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Diretor diretor, string senha)
        {
            bool usuarioAutenticado = diretor.Autenticar(senha);

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

        public bool Logar(GerenteDeContas gerenteDeContas, string senha)
        {
            bool usuarioAutenticado = gerenteDeContas.Autenticar(senha);

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
    }
}