using FarmaDesk.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KioscoSV.DataAccess;

public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDBContext>
{
    public AppDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();


        optionsBuilder.UseSqlServer("Server=LC\\SQLEXPRESS;Database=Shopx;Trusted_Connection=True;TrustServerCertificate=True;");

        return new AppDBContext(optionsBuilder.Options);
    }
}