using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class CategoriaRepository
{
    private readonly AppDBContext context;

    public CategoriaRepository(AppDBContext context) => this.context = context;

    public List<CategoriaEntity> GetAll() => context.Categorias.Include(c => c.Estado).AsNoTracking().OrderBy(c => c.Categoria).ToList();

    public CategoriaEntity? GetById(int id) => context.Categorias.Include(c => c.Estado).AsNoTracking().FirstOrDefault(c => c.ID_Categoria == id);

    public void Insert(CategoriaEntity entity)
    {
        Validate(entity);
        entity.ID_Estado = EstadoIds.Activo;
        context.Categorias.Add(entity);
        context.SaveChanges();
    }

    public void Update(CategoriaEntity entity)
    {
        Validate(entity);
        var existing = context.Categorias.Find(entity.ID_Categoria)
            ?? throw new KeyNotFoundException("Categoría no encontrada.");

        existing.Categoria = entity.Categoria;
        existing.Descripcion = entity.Descripcion;
        existing.ID_Estado = entity.ID_Estado;
        context.SaveChanges();
    }

    public void Deactivate(int id) => ChangeState(id, EstadoIds.Inactivo);
    public void Activate(int id) => ChangeState(id, EstadoIds.Activo);

    private void ChangeState(int id, int stateId)
    {
        var entity = context.Categorias.Find(id) ?? throw new KeyNotFoundException("Categoría no encontrada.");
        entity.ID_Estado = stateId;
        context.SaveChanges();
    }

    private static void Validate(CategoriaEntity entity)
    {
        if (string.IsNullOrWhiteSpace(entity.Categoria)) throw new ArgumentException("La categoría es obligatoria.");
    }
}
