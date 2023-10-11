using Infrastructure.Repository;
using Core.Interfaces;
using Infrastructure.Data;
using Core.Interfaces.Generic;

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



        
        public IRol ? Roles => _Rol ??= new RolRepository(_Context!);
        public IUsuario ? Usuarios => _Usuario ??= new UsuarioRepository(_Context!);
        public IUsuarioRoles UsuariosRoles => _UsuariosRoles ??= new UsuariosRolesRepository(_Context!);
        public ICita? Citas => throw new NotImplementedException();
        public IDetalleMovimiento? DetallesMovimientos => throw new NotImplementedException();
        public IEspecie? Especies => throw new NotImplementedException();
        public ILaboratorio? Laboratorios => throw new NotImplementedException();
        public IMascota? Mascotas => throw new NotImplementedException();
        public IMedicamento? Medicamentos => throw new NotImplementedException();
        public IMedicamentoProveedor? MedicamentosProveedores => throw new NotImplementedException();
        public IMovimientoMedicamento? MovimientosMedicamentos => throw new NotImplementedException();
        public IPropietario? Propietarios => throw new NotImplementedException();
        public IProveedor? Proveedores => throw new NotImplementedException();
        public IRaza? Razas => throw new NotImplementedException();
        public ITipoMovimiento? TiposMovimientos => throw new NotImplementedException();
        public ITratamientoMedico? TratamientosMedicos => throw new NotImplementedException();
        public IVeterinario? Veterinarios => throw new NotImplementedException();



    
    public void Dispose(){
            _Context!.Dispose();
            GC.SuppressFinalize(this); 
        }

        public Task<int> SaveAsync(){
            return _Context!.SaveChangesAsync();
        }
    }
