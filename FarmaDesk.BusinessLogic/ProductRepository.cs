using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class ProductRepository
{
    private readonly AppDBContext context;

    public ProductRepository(AppDBContext context) => this.context = context;

    public List<ProductoEntity> GetAll() => context.Productos.Include(p => p.Categoria).Include(p => p.Estado).AsNoTracking().OrderBy(p => p.Producto).ToList();
    public ProductoEntity? GetById(int id) => context.Productos.Include(p => p.Categoria).Include(p => p.Estado).AsNoTracking().FirstOrDefault(p => p.ID_Producto == id);

    public void Insert(ProductoEntity entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Productos.Add(entity);
        context.SaveChanges();
    }

    public void Update(ProductoEntity entity)
    {
        Validate(entity);
        var existing = context.Productos.Find(entity.ID_Producto)
            ?? throw new KeyNotFoundException("Producto no encontrado.");

        existing.ID_Categoria = entity.ID_Categoria;
        existing.Producto = entity.Producto;
        existing.Descripcion = entity.Descripcion;
        existing.Stock_Minimo = entity.Stock_Minimo;
        existing.ID_Estado = entity.ID_Estado;
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Productos.Find(id) ?? throw new KeyNotFoundException("Producto no encontrado.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(ProductoEntity entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Producto)) throw new ArgumentException("El producto es obligatorio.");
    }
}
