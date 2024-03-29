using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReceptProjekt.Extensions;
using ReceptProjekt.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReceptProjekt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private bool _loginPage = false;
        private readonly IHost host;

        public App()
        {
            host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.ConfigureHttpCliens();
                    services.ConfigureAssamblers();
                    services.ConfigureApiServices();
                    services.ConfigureViewViewModels();
                })
                .Build();

        }

        protected async override void OnStartup(StartupEventArgs e)
        {
            await host.StartAsync();

            /*try
            {
                if (_loginPage)
                {
                           var loginView = host.Services.GetRequiredService<LoginView>();
                           loginView.Show();
                           loginView.IsVisibleChanged += (s, ev) =>
                           {
                               if (loginView.IsVisible == false && loginView.IsLoaded)
                               {
                                   var mainView = host.Services.GetRequiredService<MainView>();
                                   mainView.Show();

                                   try
                                   {
                                       loginView.Close();
                                   }
                                   catch { }

                               }
                           };
                }
                else
                { */
                    var mainView = host.Services.GetRequiredService<MainWindow>();
                    mainView.Show();
               /* }
            }
            catch (Exception)
            {
            }*/

        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await host.StopAsync();
            host.Dispose();
            base.OnExit(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
        }
    }
}