using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEnd.Repos
{
   public class MeasurementsRepo<TDbContext> : RepositoryBase<TDbContext, Measurements>, IMeasurementsRepo
               where TDbContext : DbContext
        {
            public MeasurementsRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
            {
            }

            public IQueryable<Measurements> SelectAllIncluded()
            {
                return FindAll().Include(measurements => measurements.Ingredients);
            }
        }

    }

