using Microsoft.EntityFrameworkCore;
using Shared.Models;
using Shared.Parameters;

namespace BackEnd.Repos
{
    public class SzemelyRepo<TDbContext> : RepositoryBase<TDbContext, Szemely>, ISzemelyRepo
    where TDbContext : DbContext
    {
        public SzemelyRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Szemely> SelectAllIncluded()
        {
            return FindAll().Include(szemely => szemely.Kepzettseg);
        }
        public IQueryable<Szemely> SelectAllByCikk()
        {
            return FindAll().Include(szemely => szemely.Cikks);
        }
        public IQueryable<Szemely> SelectAllByRecept()
        {
            return FindAll().Include(szemely => szemely.Receptek);
        }


    }
}
