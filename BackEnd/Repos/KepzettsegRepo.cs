using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Repos
{
    public class KepzettsegRepo<TDbContext> : RepositoryBase<TDbContext, Kepzettseg>, IKepzettsegRepo
       where TDbContext : DbContext
    {
        public KepzettsegRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Kepzettseg> SelectAllIncluded()
        {
            return FindAll().Include(kepzettseg => kepzettseg.Szemelyek);
        }
    }
}
