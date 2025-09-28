using RoyalShelf.Domain.Entities;

namespace RoyalShelf.Domain.Interfaces.Services
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> GetTodosAsync();
        Task<Livro?> ObterPorIdAsync(int id);
        Task<Livro> AdicionarAsync(Livro livro);
        Task<Livro> AtualizarAsync(Livro livro);
        Task<bool> RemoverAsync(int id);
    }
}
