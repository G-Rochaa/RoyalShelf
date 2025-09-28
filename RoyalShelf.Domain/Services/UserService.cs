using RoyalShelf.Domain.Entities;
using RoyalShelf.Domain.Interfaces.Services;

namespace RoyalShelf.Domain.Services
{
    public class UserService : IUserService
    {
        public Task<User> AdicionarAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> AtualizarAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
