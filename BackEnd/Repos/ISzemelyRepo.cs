using Shared.Models;
using Shared.Parameters;

namespace BackEnd.Repos
{
    public interface ISzemelyRepo : IRepositoryBase<Szemely>
    {
        public IQueryable<Szemely> SelectAllIncluded();

        public IQueryable<Szemely> SelectAllByCikk();

        public IQueryable<Szemely> SelectAllByRecept();
    }
}
