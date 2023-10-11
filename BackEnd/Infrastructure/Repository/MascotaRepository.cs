using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class MascotaRepository : GenericRepository<Mascota>, IMascota
{
    private readonly DbAppContext _Context;
    public MascotaRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Mascota>> GetAllAsync()
    {
        return await _Context.Set<Mascota>()
                            .Include(p => p.Propietarios)
                            .Include(p => p.Especies)
                            .Include(p => p.Razas)
                            .Include(p => p.Citas)
                            .ToListAsync();
    }
}
