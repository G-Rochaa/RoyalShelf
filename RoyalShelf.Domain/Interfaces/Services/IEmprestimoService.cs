using RoyalShelf.Domain.Entities;

namespace RoyalShelf.Domain.Interfaces.Services
{
    public interface IEmprestimoService
    {
        Task<IEnumerable<Emprestimo>> GetTodosAsync();
        Task<Emprestimo?> ObterPorIdAsync(int id);
        Task<Emprestimo> AdicionarAsync(Emprestimo emprestimo);
        Task<Emprestimo> AtualizarAsync(Emprestimo emprestimo);
        Task<bool> RemoverAsync(int id);
    }
}
