using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha);
    }
}