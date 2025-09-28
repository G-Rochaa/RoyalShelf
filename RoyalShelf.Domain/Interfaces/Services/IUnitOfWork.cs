using RoyalShelf.Domain.Interfaces.Repositories;

namespace RoyalShelf.Domain.Interfaces.Services
{
    public interface IUnitOfWork : IDisposable
    {
        ILivroRepository Livros { get; }
        IEmprestimoRepository Emprestimos { get; }
        IUserRepository Users { get; }
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
