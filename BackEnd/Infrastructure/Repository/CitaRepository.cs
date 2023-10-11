using Core.Entities;
using Core.Interfaces.Generic;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class CitaRepository : GenericRepository<Cita>, ICita
{
    private readonly DbAppContext _Context;
    public CitaRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Cita>> GetAllAsync()
    {
        return await _Context.Set<Cita>()
                            .Include(p => p.Mascotas)
                            .Include(p => p.Veterinarios)
                            .Include(p => p.TratamientoMedicos)
                            .ToListAsync();
    }

    
}
