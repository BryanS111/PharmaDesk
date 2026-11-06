using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options);
             base(options) {}
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }
}
