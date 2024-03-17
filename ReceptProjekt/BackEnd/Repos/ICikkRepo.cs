using Shared.Models;

namespace BackEnd.Repos
{
    public interface ICikkRepo : IRepositoryBase<Cikk>
    {
        public IQueryable<Cikk> SelectAllIncluded();
    }
}

