using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Repos
{
    public class CikkRepo<TDbContext> : RepositoryBase<TDbContext, Cikk>, ICikkRepo
where TDbContext : DbContext
    {
        public CikkRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Cikk> SelectAllIncluded()
        {
            return FindAll().Include(cikk => cikk.Szemely);
        }
    }
}
