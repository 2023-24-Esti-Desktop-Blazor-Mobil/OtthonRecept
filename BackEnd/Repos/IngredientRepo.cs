using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Repos
{
    public class IngredientRepo<TDbContext> : RepositoryBase<TDbContext, Ingredient>, IIngredientRepo
               where TDbContext : DbContext
    {
        public IngredientRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Ingredient> SelectAllIncluded()
        {
            return FindAll().Include(ingredient => ingredient.Measurements);
        }
    }
}
