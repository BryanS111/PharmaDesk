using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using Microsoft.EntityFrameworkCore;

namespace FarmaDesk.BusinessLogic;

public class EstadoRepository
{
    private readonly AppDBContext context;

    public EstadoRepository(AppDBContext context) => this.context = context;

    public List<EstadoEntity> GetAll() => context.Estados.AsNoTracking().OrderBy(e => e.ID_Estado).ToList();
}
