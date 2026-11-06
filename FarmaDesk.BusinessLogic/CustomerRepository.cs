using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class CustomerRepository
{
    private readonly AppDBContext context;

    public CustomerRepository(AppDBContext context) => this.context = context;

    public List<Customer> GetAll() => context.Clientes.Include(c => c.Estado).AsNoTracking().OrderBy(c => c.Nombre).ThenBy(c => c.Apellido).ToList();
    public Customer? GetById(int id) => context.Clientes.Include(c => c.Estado).FirstOrDefault(c => c.ID_Cliente == id);

    public void Insert(Customer entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Clientes.Add(entity);
        context.SaveChanges();
    }

    public void Update(Customer entity)
    {
        Validate(entity);
        context.Clientes.Update(entity);
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Clientes.Find(id) ?? throw new KeyNotFoundException("Cliente no encontrado.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(Customer entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Nombre)) throw new ArgumentException("El nombre del cliente es obligatorio.");
    }
}
