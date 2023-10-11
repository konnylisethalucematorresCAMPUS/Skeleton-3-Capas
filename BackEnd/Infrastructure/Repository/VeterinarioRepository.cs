using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class VeterinarioRepository : GenericRepository<Veterinario>, IVeterinario
{
    private readonly DbAppContext _Context;
    public VeterinarioRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Veterinario>> GetAllAsync()
    {
        return await _Context.Set<Veterinario>()
                            .Include(p => p.Citas)
                            .ToListAsync();
    }
}
