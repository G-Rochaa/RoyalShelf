using RoyalShelf.Domain.Entities;
using RoyalShelf.Domain.Interfaces.Services;

namespace RoyalShelf.Domain.Services
{
    public class LivroService : ILivroService
    {
        public Task<Livro> AdicionarAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<Livro> AtualizarAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> GetTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Livro?> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
