using Shared.Models;

namespace BackEnd.Repos
{
    public interface IKepzettsegRepo : IRepositoryBase<Kepzettseg>
    {
        public IQueryable<Kepzettseg> SelectAllIncluded();
    }
}
