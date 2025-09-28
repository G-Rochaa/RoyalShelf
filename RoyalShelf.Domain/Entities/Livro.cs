namespace RoyalShelf.Domain.Entities
{
    public class Livro
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; } = string.Empty;
        public string Autor { get; private set; } = string.Empty;
        public string Isbn { get; private set; } = string.Empty;
        public int AnoPublicacao { get; private set; }

        public void AtualizarDados(string titulo, string autor, string isbn, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            AnoPublicacao = anoPublicacao;
        }
    }
}
