using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class PresentationRepository
{
    private readonly AppDBContext context;

    public PresentationRepository(AppDBContext context) => this.context = context;

    public List<PresentacionesEntity> GetAll() => context.Presentaciones.Include(p => p.Producto).Include(p => p.Estado).AsNoTracking().OrderBy(p => p.Presentacion).ToList();
    public PresentacionesEntity? GetById(int id) => context.Presentaciones.Include(p => p.Producto).Include(p => p.Estado).AsNoTracking().FirstOrDefault(p => p.ID_Presentacion == id);

    public void Insert(PresentacionesEntity entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Presentaciones.Add(entity);
        context.SaveChanges();
    }

    public void Update(PresentacionesEntity entity)
    {
        Validate(entity);
        var existing = context.Presentaciones.Find(entity.ID_Presentacion)
            ?? throw new KeyNotFoundException("Presentación no encontrada.");

        existing.ID_Producto = entity.ID_Producto;
        existing.Presentacion = entity.Presentacion;
        existing.Unidades_Equivalentes = entity.Unidades_Equivalentes;
        existing.Precio_Venta = entity.Precio_Venta;
        existing.ID_Estado = entity.ID_Estado;
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Presentaciones.Find(id) ?? throw new KeyNotFoundException("Presentación no encontrada.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(PresentacionesEntity entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Presentacion)) throw new ArgumentException("La presentación es obligatoria.");
        if (entity.Unidades_Equivalentes <= 0) throw new ArgumentOutOfRangeException(nameof(entity.Unidades_Equivalentes));
    }
}
