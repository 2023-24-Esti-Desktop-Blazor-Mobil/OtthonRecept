using BackEnd.Context;

using BackEnd.Repos;
using Microsoft.EntityFrameworkCore;
using Shared.Assembler;

namespace BackEnd.Extensions
{
    public static class BackendExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "ReceptCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7020/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }
        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbName = "Recept" + Guid.NewGuid();
            /*services.AddDbContextFactory<Context1>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbName));
            */
            services.AddDbContextFactory<InmemoryContext>(
                options => options.UseInMemoryDatabase(databaseName: dbName)
                );
        }
        public static void ConfigureRepoService(this IServiceCollection services)
        {
            services.AddScoped<ISzemelyRepo, SzemelyInMemoryRepo>();
            services.AddScoped<ICikkRepo, CikkInMemoryRepo>();
            services.AddScoped<IKepzettsegRepo, KepzettsegInMemoryRepo>();
            services.AddScoped<IIngredientRepo, IngredientInMemoryRepo>();
            services.AddScoped<IMeasurementsRepo, MeasurementsInMemoryRepo>();
            services.AddScoped<IReceptRepo, ReceptInMemoryRepo>();

        }
        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<CikkAssambler>();
            services.AddScoped<SzemelyAssambler>();
            services.AddScoped<KepzettsegAssambler>();
            services.AddScoped<IngredientAssambler>();
            services.AddScoped<MeasurementsAssambler>();
            services.AddScoped<ReceptAssambler>();

        }
    }
}
