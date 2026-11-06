using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FarmaDesk.DataAccess;

public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDBContext>
{
    public AppDBContext CreateDbContext(string[] args)
    {
        var settingsPath = Path.Combine(Directory.GetCurrentDirectory(), "FarmaDesk.Desktop", "appsettings.json");

        if (!File.Exists(settingsPath))
        {
            settingsPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        }

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(settingsPath)!)
            .AddJsonFile(Path.GetFileName(settingsPath), optional: false)
            .Build();

        var connectionString = configuration.GetConnectionString("conn")
            ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'conn'.");

        var options = new DbContextOptionsBuilder<AppDBContext>()
            .UseSqlServer(connectionString)
            .Options;

        return new AppDBContext(options);
    }
}
