using HttpService.Service;
using Microsoft.Extensions.DependencyInjection;
using Shared.Assembler;
using System;

namespace ReceptProjekt.Extensions
{
    public static class HttpCliensExtension
    {
        public static void ConfigureHttpCliens(this IServiceCollection services)
        {
            services.AddHttpClient("ReceptApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }
        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<ISzemelyService, SzemelyService>();
            services.AddScoped<ICikkService, CikkService>();
            services.AddScoped<IKepzettsegService, KepzettsegService>();
            //services.AddScoped<IReceptService, ReceptService>();

        }

        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<SzemelyAssambler>();
            services.AddScoped<CikkAssambler>();
            services.AddScoped<KepzettsegAssambler>();
            //services.AddScoped<ReceptAssambler>();

        }


    }
}
