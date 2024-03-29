using Shared.Models;

namespace BackEnd.Repos
{
    public interface IReceptRepo : IRepositoryBase<Recept>
    {
        public IQueryable<Recept> SelectAllIncluded();

        }
}
