using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Repos
{
    public interface IIngredientRepo : IRepositoryBase<Ingredient>
    {
        public IQueryable<Ingredient> SelectAllIncluded();

    }
}
