using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class PropietarioRepository : GenericRepository<Propietario>, IPropietario
{
    private readonly DbAppContext _Context;
    public PropietarioRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
     public override async Task<IEnumerable<Propietario>> GetAllAsync()
    {
        return await _Context.Set<Propietario>()
                            .Include(p => p.Mascotas)
                            .ToListAsync();
     }
}
