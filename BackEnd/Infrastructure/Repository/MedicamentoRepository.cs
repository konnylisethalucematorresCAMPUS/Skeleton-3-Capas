using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class MedicamentoRepository : GenericRepository<Medicamento>, IMedicamento
{
    private readonly DbAppContext _Context;
    public MedicamentoRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<Medicamento>> GetAllAsync()
    {
        return await _Context.Set<Medicamento>()
                            .Include(p => p.Laboratorios)
                            .Include(p => p.TratamientoMedicos)
                            .Include(p => p.MedicamentosProveedores)
                            .Include(p => p.MovimientoMedicamentos)
                            .Include(p => p.DetalleMovimientos)
                            .ToListAsync();
    }
}
