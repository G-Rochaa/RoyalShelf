using RoyalShelf.Domain.Entities;
using RoyalShelf.Domain.Interfaces.Repositories;
using RoyalShelf.Infrastructure.Data.Context;

namespace RoyalShelf.Infrastructure.Repositories
{
    public class LivroRepository : GenericRepository<Livro>, ILivroRepository
    {
        public LivroRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
