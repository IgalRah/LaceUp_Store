using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LaceUp.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = App.GetConfiguration();
            var connectionString = configuration.GetConnectionString("connectionString");
            return new AppDbContext(connectionString);
        }
    }
}
