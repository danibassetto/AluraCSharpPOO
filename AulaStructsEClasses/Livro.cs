namespace AulaStructsEClasses
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public bool PossuiISBN { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public string DadosLivro()
        {
            return $"Título: {this.Titulo}" +
                   $"Autor: {this.Autor}";
        }
    }
}
