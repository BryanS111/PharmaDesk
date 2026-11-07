using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class SupplierRepository
{
    private readonly AppDBContext context;

    public SupplierRepository(AppDBContext context) => this.context = context;

    public List<Supplier> GetAll() => context.Proveedores.Include(s => s.Estado).AsNoTracking().OrderBy(s => s.Proveedor).ToList();
    public Supplier? GetById(int id) => context.Proveedores.Include(s => s.Estado).AsNoTracking().FirstOrDefault(s => s.ID_Proveedor == id);

    public void Insert(Supplier entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Proveedores.Add(entity);
        context.SaveChanges();
    }

    public void Update(Supplier entity)
    {
        Validate(entity);
        var existing = context.Proveedores.Find(entity.ID_Proveedor)
            ?? throw new KeyNotFoundException("Proveedor no encontrado.");

        existing.Proveedor = entity.Proveedor;
        existing.Telefono = entity.Telefono;
        existing.Correo = entity.Correo;
        existing.Direccion = entity.Direccion;
        existing.NIT = entity.NIT;
        existing.NRC = entity.NRC;
        existing.ID_Estado = entity.ID_Estado;
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Proveedores.Find(id) ?? throw new KeyNotFoundException("Proveedor no encontrado.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(Supplier entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Proveedor)) throw new ArgumentException("El proveedor es obligatorio.");
        if (string.IsNullOrWhiteSpace(entity.Telefono)) throw new ArgumentException("El teléfono es obligatorio.");
    }
}
