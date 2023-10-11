using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class LaboratorioRepository : GenericRepository<Laboratorio>, ILaboratorio
{
    private readonly DbAppContext _Context;
    public LaboratorioRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Laboratorio>> GetAllAsync()
    {
        return await _Context.Set<Laboratorio>()
                            .Include(p => p.Medicamentos)
                            .ToListAsync();
    }
}
