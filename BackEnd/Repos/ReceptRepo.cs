using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Repos
{
    public class ReceptRepo<TDbContext> : RepositoryBase<TDbContext, Recept>, IReceptRepo
    where TDbContext : DbContext
    {
        public ReceptRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Recept> SelectAllIncluded()
        {
            return FindAll().Include(recept => recept.Szemely);
        }
        
    }
}
