using Infrastructure.Repository;
using Core.Interfaces;
using Infrastructure.Data;
using Core.Interfaces.Generic;
using Core.Entities;

namespace Infrastructure.UnitOfWork;
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbAppContext ? _Context;
        public UnitOfWork(DbAppContext context){
            _Context = context;
        }



        private RolRepository ? _Rol;
        private UsuarioRepository ? _Usuario;
        private UsuariosRolesRepository ? _UsuariosRoles;
        private CitaRepository ? _Citas;
        private DetalleMovimientoRepository ? _DetalleMovimiento;
        private EspecieRepository ? _Especie;
        private LaboratorioRepository ? _Laboratorio;
        private MascotaRepository ? _Mascota;
        private MedicamentoRepository? _Medicamento;
        private MedicamentoProveedorRepository ? _MedicamentoProveedor;
        private MovimientoMedicamentoRepository? _MovimientoMedicamento;
        private PropietarioRepository? _Propietario;
        private ProveedorRepository? _Proveedor;
        private RazaRepository? _Raza;
        private TipoMovimientoRepository? _TipoMovimiento;
        private TratamientoMedicoRepository? _TratamientoMedico;
        private VeterinarioRepository? _Veterinario;





        
        public IRol ? Roles => _Rol ??= new RolRepository(_Context!);
        public IUsuario ? Usuarios => _Usuario ??= new UsuarioRepository(_Context!);
        public IUsuarioRoles UsuariosRoles => _UsuariosRoles ??= new UsuariosRolesRepository(_Context!);
        public ICita? Citas => _Citas ??= new CitaRepository(_Context!);
        public IDetalleMovimiento? DetallesMovimientos => _DetalleMovimiento ??= new DetalleMovimientoRepository(_Context!);
        public IEspecie? Especies => _Especie ??= new EspecieRepository(_Context!); 
        public ILaboratorio? Laboratorios => _Laboratorio ??= new LaboratorioRepository(_Context!); 
        public IMascota? Mascotas => _Mascota ??= new MascotaRepository(_Context!); 
        public IMedicamento? Medicamentos => _Medicamento ??= new MedicamentoRepository(_Context!); 
        public IMedicamentoProveedor? MedicamentosProveedores => _MedicamentoProveedor ??= new MedicamentoProveedorRepository(_Context!); 
        public IMovimientoMedicamento? MovimientosMedicamentos => _MovimientoMedicamento ??= new MovimientoMedicamentoRepository(_Context!); 
        public IPropietario? Propietarios => _Propietario ??= new PropietarioRepository(_Context!); 
        public IProveedor? Proveedores => _Proveedor ??= new ProveedorRepository(_Context!); 
        public IRaza? Razas => _Raza ??= new RazaRepository(_Context!); 
        public ITipoMovimiento? TiposMovimientos => _TipoMovimiento ??= new TipoMovimientoRepository(_Context!); 
        public ITratamientoMedico? TratamientosMedicos => _TratamientoMedico ??= new TratamientoMedicoRepository(_Context!); 
        public IVeterinario? Veterinarios => _Veterinario ??= new VeterinarioRepository(_Context!); 



    
    public void Dispose(){
            _Context!.Dispose();
            GC.SuppressFinalize(this); 
        }

        public Task<int> SaveAsync(){
            return _Context!.SaveChangesAsync();
        }
    }
