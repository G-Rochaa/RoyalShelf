using RoyalShelf.Domain.Entities;
using RoyalShelf.Domain.Interfaces.Repositories;
using RoyalShelf.Infrastructure.Data.Context;

namespace RoyalShelf.Infrastructure.Repositories
{
    public class EmprestimoRepository : GenericRepository<Emprestimo>, IEmprestimoRepository
    {
        public EmprestimoRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
