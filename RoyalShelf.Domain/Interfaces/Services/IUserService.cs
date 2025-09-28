using RoyalShelf.Domain.Entities;

namespace RoyalShelf.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetTodosAsync();
        Task<User?> ObterPorIdAsync(int id);
        Task<User> AdicionarAsync(User user);
        Task<User> AtualizarAsync(User user);
        Task<bool> RemoverAsync(int id);
    }
}
