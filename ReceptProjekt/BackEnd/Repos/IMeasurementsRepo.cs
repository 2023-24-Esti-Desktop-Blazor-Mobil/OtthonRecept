using Shared.Models;

namespace BackEnd.Repos
{
    public interface IMeasurementsRepo : IRepositoryBase<Measurements>
    {
        public IQueryable<Measurements> SelectAllIncluded();
    }
}


