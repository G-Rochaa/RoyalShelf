using RoyalShelf.Domain.Entities;
using RoyalShelf.Domain.Interfaces.Repositories;
using RoyalShelf.Infrastructure.Data.Context;

namespace RoyalShelf.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
