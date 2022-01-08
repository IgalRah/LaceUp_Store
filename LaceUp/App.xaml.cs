using LaceUp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace LaceUp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IConfiguration GetConfiguration()
             => new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("Connections/appsettings.json", optional: true, reloadOnChange: false)
             .Build();

        public static IServiceCollection ConfigureServices()
        {
            var configuration = GetConfiguration();
            var connectionstring = configuration.GetConnectionString("connectionString");

            return new ServiceCollection()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionstring))
                .AddSingleton<MainWindow>();
        }
    }
}
