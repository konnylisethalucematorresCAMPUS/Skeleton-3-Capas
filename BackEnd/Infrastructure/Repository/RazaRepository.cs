using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class RazaRepository : GenericRepository<Raza>, IRaza
{
    private readonly DbAppContext _Context;
    public RazaRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Raza>> GetAllAsync()
    {
        return await _Context.Set<Raza>()
                            .Include(p => p.Especies)
                            .Include(p => p.Mascotas)
                            .ToListAsync();
    }
}
