using ReceptProjekt.ViewModels;
using ReceptProjekt.Views;


using Microsoft.Extensions.DependencyInjection;


namespace ReceptProjekt.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // BelépésView
            services.AddSingleton<BelepesViewModel>();
            services.AddSingleton<Belepes>(s => new Belepes()
            {
                DataContext = s.GetRequiredService<BelepesViewModel>()
            });

            // CikkView
            services.AddSingleton<CikkViewModel>();
            services.AddSingleton<CikkView>(s => new CikkView()
            {
                DataContext = s.GetRequiredService<CikkViewModel>()
            });
            //ReceptView
            services.AddSingleton<ReceptViewModel>();
            services.AddSingleton<ReceptView>(s => new ReceptView()
            {
                DataContext = s.GetRequiredService<ReceptViewModel>()
            });
            //SzemelyView
            services.AddSingleton<SzemelyViewModel>();
            services.AddSingleton<SzemelyView>(s => new SzemelyView()
            {
                DataContext = s.GetRequiredService<SzemelyViewModel>()
            });
        }
    }
}