using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class UserRepository
{
    private readonly AppDBContext context;

    public UserRepository(AppDBContext context) => this.context = context;

    public List<User> GetAll() => context.Usuarios.Include(u => u.Rol).Include(u => u.Estado).AsNoTracking().OrderBy(u => u.Nombre).ToList();

    public User? GetById(int id) => context.Usuarios.Include(u => u.Rol).Include(u => u.Estado).FirstOrDefault(u => u.ID_Usuario == id);

    public void Insert(User entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Usuarios.Add(entity);
        context.SaveChanges();
    }

    public void Update(User entity)
    {
        Validate(entity);
        context.Usuarios.Update(entity);
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Usuarios.Find(id) ?? throw new KeyNotFoundException("Usuario no encontrado.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(User entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Nombre)) throw new ArgumentException("El nombre es obligatorio.");
        if (string.IsNullOrWhiteSpace(entity.Usuario)) throw new ArgumentException("El usuario es obligatorio.");
        if (string.IsNullOrWhiteSpace(entity.Clave)) throw new ArgumentException("La clave es obligatoria.");
        if (entity.ID_Rol == 0) throw new ArgumentException("Seleccione un rol.");
    }
}