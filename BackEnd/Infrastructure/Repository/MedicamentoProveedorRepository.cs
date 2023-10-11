using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class MedicamentoProveedorRepository : GenericRepository<MedicamentosProveedores>, IMedicamentoProveedor
{
    private readonly DbAppContext _Context;
    public MedicamentoProveedorRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<MedicamentosProveedores>> GetAllAsync()
    {
        return await _Context.Set<MedicamentosProveedores>()
                            .Include(p => p.Medicamentos)
                            .Include(p => p.Proveedores)
                            .ToListAsync();

    }
}
