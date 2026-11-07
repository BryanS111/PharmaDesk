using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class RoleRepository
{
    private readonly AppDBContext context;

    public RoleRepository(AppDBContext context) => this.context = context;

    public List<Role> GetAll() => context.Roles.Include(r => r.Estado).AsNoTracking().OrderBy(r => r.Rol).ToList();
    public Role? GetById(int id) => context.Roles.Include(r => r.Estado).AsNoTracking().FirstOrDefault(r => r.ID_Rol == id);

    public void Insert(Role entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Roles.Add(entity);
        context.SaveChanges();
    }

    public void Update(Role entity)
    {
        Validate(entity);
        var existing = context.Roles.Find(entity.ID_Rol)
            ?? throw new KeyNotFoundException("Rol no encontrado.");

        existing.Rol = entity.Rol;
        existing.Descripcion = entity.Descripcion;
        existing.ID_Estado = entity.ID_Estado;
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Roles.Find(id) ?? throw new KeyNotFoundException("Rol no encontrado.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(Role entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Rol)) throw new ArgumentException("El rol es obligatorio.");
    }
}
