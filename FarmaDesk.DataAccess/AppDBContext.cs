using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.DataAccess;

public class AppDBContext : DbContext
{
    public AppDBContext() { }

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

    public DbSet<EstadoEntity> Estados => Set<EstadoEntity>();
    public DbSet<CategoriaEntity> Categorias => Set<CategoriaEntity>();
    public DbSet<ProductoEntity> Productos => Set<ProductoEntity>();
    public DbSet<PresentacionesEntity> Presentaciones => Set<PresentacionesEntity>();
    public DbSet<InventarioEntity> Inventario => Set<InventarioEntity>();
    public DbSet<Movimientos_InventarioEntity> MovimientosInventario => Set<Movimientos_InventarioEntity>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<User> Usuarios => Set<User>();
    public DbSet<Customer> Clientes => Set<Customer>();
    public DbSet<Supplier> Proveedores => Set<Supplier>();
    public DbSet<CashRegister> Cajas => Set<CashRegister>();
    public DbSet<VentasEntity> Ventas => Set<VentasEntity>();
    public DbSet<Detalle_VentasEntity> DetallesVentas => Set<Detalle_VentasEntity>();
    public DbSet<ComprasEntity> Compras => Set<ComprasEntity>();
    public DbSet<Detalle_ComprasEntity> DetallesCompras => Set<Detalle_ComprasEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<EstadoEntity>().ToTable("Estado");
        modelBuilder.Entity<CategoriaEntity>().ToTable("Categoria");
        modelBuilder.Entity<ProductoEntity>().ToTable("Producto");
        modelBuilder.Entity<PresentacionesEntity>().ToTable("Presentaciones");
        modelBuilder.Entity<InventarioEntity>().ToTable("Inventario");
        modelBuilder.Entity<Movimientos_InventarioEntity>().ToTable("Movimientos_Inventario");
        modelBuilder.Entity<Role>().ToTable("Rol");
        modelBuilder.Entity<User>().ToTable("Usuario");
        modelBuilder.Entity<Customer>().ToTable("Cliente");
        modelBuilder.Entity<Supplier>().ToTable("Proveedor");
        modelBuilder.Entity<CashRegister>().ToTable("Caja");
        modelBuilder.Entity<VentasEntity>().ToTable("Ventas");
        modelBuilder.Entity<Detalle_VentasEntity>().ToTable("Detalle_Ventas");
        modelBuilder.Entity<ComprasEntity>().ToTable("Compras");
        modelBuilder.Entity<Detalle_ComprasEntity>().ToTable("Detalle_Compras");

        modelBuilder.Entity<EstadoEntity>().HasData(
            new EstadoEntity { ID_Estado = 1, Estado = "Activo", Descripcion = "Registro disponible" },
            new EstadoEntity { ID_Estado = 2, Estado = "Inactivo", Descripcion = "Registro deshabilitado" });

        modelBuilder.Entity<PresentacionesEntity>().Property(p => p.Precio_Venta).HasPrecision(18, 2);
        modelBuilder.Entity<CashRegister>().Property(c => c.Monto_Inicial).HasPrecision(18, 2);
        modelBuilder.Entity<CashRegister>().Property(c => c.Monto_Final).HasPrecision(18, 2);
        modelBuilder.Entity<VentasEntity>().Property(v => v.Total).HasPrecision(18, 2);
        modelBuilder.Entity<VentasEntity>().Property(v => v.Descuento).HasPrecision(18, 2);
        modelBuilder.Entity<ComprasEntity>().Property(c => c.Total).HasPrecision(18, 2);
        modelBuilder.Entity<Detalle_VentasEntity>().Property(d => d.Precio_Unitario).HasPrecision(18, 2);
        modelBuilder.Entity<Detalle_VentasEntity>().Property(d => d.Subtotal).HasPrecision(18, 2);
        modelBuilder.Entity<Detalle_ComprasEntity>().Property(d => d.Precio_Compra).HasPrecision(18, 2);
        modelBuilder.Entity<Detalle_ComprasEntity>().Property(d => d.Subtotal).HasPrecision(18, 2);
        modelBuilder.Entity<Detalle_ComprasEntity>().Property(d => d.Unidades_Totales)
            .HasComputedColumnSql("[Cantidad_Por_Presentacion] * [Cantidad]");

        modelBuilder.Entity<CategoriaEntity>().HasOne(c => c.Estado).WithMany()
            .HasForeignKey(c => c.ID_Estado).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Customer>().HasOne(c => c.Estado).WithMany()
            .HasForeignKey(c => c.ID_Estado).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Role>().HasOne(r => r.Estado).WithMany()
            .HasForeignKey(r => r.ID_Estado).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ProductoEntity>().HasOne(p => p.Categoria).WithMany()
            .HasForeignKey(p => p.ID_Categoria).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ProductoEntity>().HasOne(p => p.Estado).WithMany()
            .HasForeignKey(p => p.ID_Estado).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<PresentacionesEntity>().HasOne(p => p.Producto).WithMany()
            .HasForeignKey(p => p.ID_Producto).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<PresentacionesEntity>().HasOne(p => p.Estado).WithMany()
            .HasForeignKey(p => p.ID_Estado).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<InventarioEntity>().HasOne<ProductoEntity>().WithMany()
            .HasForeignKey(i => i.ID_Producto).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>().HasOne(u => u.Rol).WithMany()
            .HasForeignKey(u => u.ID_Rol).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<User>().HasOne(u => u.Estado).WithMany()
            .HasForeignKey(u => u.ID_Estado).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Supplier>().HasOne(s => s.Estado).WithMany()
            .HasForeignKey(s => s.ID_Estado).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CashRegister>().HasOne(c => c.User).WithMany()
            .HasForeignKey(c => c.ID_Usuario).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CashRegister>().HasOne(c => c.Estado).WithMany()
            .HasForeignKey(c => c.ID_Estado).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<VentasEntity>().HasOne<Customer>().WithMany()
            .HasForeignKey(v => v.ID_Cliente).OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<VentasEntity>().HasOne<User>().WithMany()
            .HasForeignKey(v => v.ID_Usuario).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<VentasEntity>().HasOne<CashRegister>().WithMany()
            .HasForeignKey(v => v.ID_Caja).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ComprasEntity>().HasOne<Supplier>().WithMany()
            .HasForeignKey(c => c.ID_Proveedor).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ComprasEntity>().HasOne<User>().WithMany()
            .HasForeignKey(c => c.ID_Usuario).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Detalle_VentasEntity>().HasOne<VentasEntity>().WithMany()
            .HasForeignKey(d => d.ID_Venta).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Detalle_VentasEntity>().HasOne<ProductoEntity>().WithMany()
            .HasForeignKey(d => d.ID_Producto).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Detalle_VentasEntity>().HasOne<PresentacionesEntity>().WithMany()
            .HasForeignKey(d => d.ID_Presentacion).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Detalle_ComprasEntity>().HasOne<ComprasEntity>().WithMany()
            .HasForeignKey(d => d.ID_Compra).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Detalle_ComprasEntity>().HasOne<ProductoEntity>().WithMany()
            .HasForeignKey(d => d.ID_Producto).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Detalle_ComprasEntity>().HasOne<PresentacionesEntity>().WithMany()
            .HasForeignKey(d => d.ID_Presentacion).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Movimientos_InventarioEntity>().HasOne<ProductoEntity>().WithMany()
            .HasForeignKey(m => m.ID_Producto).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Movimientos_InventarioEntity>().HasOne<User>().WithMany()
            .HasForeignKey(m => m.ID_Usuario).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Movimientos_InventarioEntity>().HasOne<ComprasEntity>().WithMany()
            .HasForeignKey(m => m.ID_Compra).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Movimientos_InventarioEntity>().HasOne<VentasEntity>().WithMany()
            .HasForeignKey(m => m.ID_Venta).OnDelete(DeleteBehavior.NoAction);
    }
}
