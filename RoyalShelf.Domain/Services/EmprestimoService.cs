using RoyalShelf.Domain.Entities;
using RoyalShelf.Domain.Interfaces.Services;

namespace RoyalShelf.Domain.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public Task<Emprestimo> AdicionarAsync(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public Task<Emprestimo> AtualizarAsync(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Emprestimo>> GetTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Emprestimo?> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
