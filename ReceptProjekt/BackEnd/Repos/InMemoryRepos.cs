using BackEnd.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repos
{
    public class CikkInMemoryRepo : CikkRepo<InmemoryContext>
    {
        public CikkInMemoryRepo(IDbContextFactory<InmemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
    public class SzemelyInMemoryRepo : SzemelyRepo<InmemoryContext>
    {
        public SzemelyInMemoryRepo(IDbContextFactory<InmemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
    public class KepzettsegInMemoryRepo : KepzettsegRepo<InmemoryContext>
    {
        public KepzettsegInMemoryRepo(IDbContextFactory<InmemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
    public class IngredientInMemoryRepo : IngredientRepo<InmemoryContext>
    {
        public IngredientInMemoryRepo(IDbContextFactory<InmemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
    public class MeasurementsInMemoryRepo : MeasurementsRepo<InmemoryContext>
    {
        public MeasurementsInMemoryRepo(IDbContextFactory<InmemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }



}
