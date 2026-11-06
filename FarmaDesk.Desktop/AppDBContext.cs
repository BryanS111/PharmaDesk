using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaDesk.Entity;

namespace FarmaDesk.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<EstadoEntity> Estado { get; set; }
        public DbSet<CategoriaEntity> Categoria { get; set; }
        public DbSet<ProductoEntity> Productos { get; set; }
    }
}
