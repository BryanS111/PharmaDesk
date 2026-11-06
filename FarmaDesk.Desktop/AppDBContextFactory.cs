using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DesktopDbContext = FarmaDesk.DataAccess.AppDBContext;

namespace FarmaDesk.Desktop
{
    public class AppDBContextFactory : IDesignTimeDbContextFactory<DesktopDbContext>
    {
        public DesktopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DesktopDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=PharmaDesk;Trusted_Connection=True;TrustServerCertificate=True;");
            return new DesktopDbContext(optionsBuilder.Options);
        }
    }
}
