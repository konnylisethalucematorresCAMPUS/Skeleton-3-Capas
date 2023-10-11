using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
    public class DbAppContext : DbContext{

        public DbAppContext(DbContextOptions<DbAppContext> options) : base (options){

        }

        public DbSet<Usuario> ? Usuarios { get; set; } = null!;
        public DbSet<Rol> ? Roles { get; set; } = null!;
        public DbSet<UsuarioRoles> ? UsuariosRoles { get; set; } = null!;
        public DbSet<RefreshToken> ? RefreshTokens { get; set; } = null!;
        public DbSet<Cita> ? Citas { get; set; } = null!;
        public DbSet<DetalleMovimiento> ? DetallesMovimientos { get; set; } = null!;
        public DbSet<Especie> ? Especies { get; set; } = null!;
        public DbSet<Laboratorio> ? Laboratorios { get; set; } = null!;
        public DbSet<Mascota> ? Mascotas { get; set; } = null!;
        public DbSet<Medicamento> ? Medicamentos { get; set; } = null!;
        public DbSet<MedicamentosProveedores> ? MedicamentosProveedores { get; set; } = null!;
        public DbSet<MovimientoMedicamento> ? MovimientosMedicamentos { get; set; } = null!;
        public DbSet<Propietario> ? Propietarios { get; set; } = null!;
        public DbSet<Proveedor> ? Proveedores { get; set; } = null!;
        public DbSet<Raza> ?  Razas { get; set; } = null!;
        public DbSet<TipoMovimiento> ? TiposMovimientos { get; set; } = null!;
        public DbSet<TratamientoMedico> ? TratamientosMedicos { get; set; } = null!;
        public DbSet<Veterinario> ? Veterinarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
