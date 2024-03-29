using Microsoft.EntityFrameworkCore;

namespace BackEnd.Context
{
    public class InmemoryContext : ContextEgy
    {

        public InmemoryContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }
}
