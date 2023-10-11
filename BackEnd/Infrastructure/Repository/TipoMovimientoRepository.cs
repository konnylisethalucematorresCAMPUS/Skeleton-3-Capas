using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class TipoMovimientoRepository : GenericRepository<TipoMovimiento>, ITipoMovimiento
{
    private readonly DbAppContext _Context;
    public TipoMovimientoRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<TipoMovimiento>> GetAllAsync()
    {
        return await _Context.Set<TipoMovimiento>()
                            .Include(p => p.DetalleMovimientos)
                            .ToListAsync();
    }
}
