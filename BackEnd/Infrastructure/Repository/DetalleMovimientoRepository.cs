using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class DetalleMovimientoRepository : GenericRepository<DetalleMovimiento>, IDetalleMovimiento
{
    private readonly DbAppContext _Context;
    public DetalleMovimientoRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<DetalleMovimiento>> GetAllAsync()
    {
        return await _Context.Set<DetalleMovimiento>()
                            .Include(p => p.Medicamentos)
                            .Include(p => p.MovimientoMedicamentos)
                            .Include(p => p.TipoMovimientos)
                            .ToListAsync();
    }
}
