using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class CashRegisterRepository
{
    private readonly AppDBContext context;
    public CashRegisterRepository(AppDBContext context) => this.context = context;
    public List<User> GetUsers() => context.Usuarios.AsNoTracking().OrderBy(u => u.Nombre).ToList();
    public List<CashRegister> GetAll() => context.Cajas.Include(c => c.User).Include(c => c.Estado).AsNoTracking().OrderByDescending(c => c.Fecha_Apertura).ToList();

    public int Open(int userId, decimal initialAmount)
    {
        if (initialAmount < 0) throw new ArgumentOutOfRangeException(nameof(initialAmount), "El monto inicial no puede ser negativo.");
        if (context.Cajas.Any(c => c.ID_Usuario == userId && c.Fecha_Cierre == null)) throw new InvalidOperationException("El usuario seleccionado ya tiene una caja abierta.");
        var cashRegister = new CashRegister { ID_Usuario = userId, Fecha_Apertura = DateTime.Now, Monto_Inicial = initialAmount, ID_Estado = EstadoIds.Abierta };
        context.Cajas.Add(cashRegister);
        context.SaveChanges();
        return cashRegister.ID_Caja;
    }

    public void Close(int cashRegisterId, decimal finalAmount)
    {
        if (finalAmount < 0) throw new ArgumentOutOfRangeException(nameof(finalAmount), "El monto final no puede ser negativo.");
        var cashRegister = context.Cajas.Find(cashRegisterId) ?? throw new KeyNotFoundException("Caja no encontrada.");
        if (cashRegister.Fecha_Cierre.HasValue) throw new InvalidOperationException("La caja seleccionada ya fue cerrada.");
        cashRegister.Fecha_Cierre = DateTime.Now;
        cashRegister.Monto_Final = finalAmount;
        cashRegister.ID_Estado = EstadoIds.Cerrada;
        context.SaveChanges();
    }
}
