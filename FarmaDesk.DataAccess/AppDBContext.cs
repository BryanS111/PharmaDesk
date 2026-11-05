using Microsoft.EntityFrameworkCore;
using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
namespace FarmaDesk.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options):
             base(options) {}
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }

    public class Productos
    {
    }

    public class Categoria
    {
    }

    public class Estado
    {
    }
}
