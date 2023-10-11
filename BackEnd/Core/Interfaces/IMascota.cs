using Core.Entities;
namespace Core.Interfaces;
    public interface IMascota : IGenericRepository<Mascota>
    {
        //! Consulta Nro. 1
        //Task<List<Mascota>> ListarTodasLasMascotasAgrupadasPorEspecie();

        //! Consulta Nro. 3

        //Task<List<Mascota>>ListarLasMascotasQueFueronAtendidasPorUnDeterminadoVeterinario();

        //! Consulta Nro. 5
        //Task<List<Mascota>> ListarLasMascotasYSusPropietariosCuyaRazaSeaGoldenRetriver();



        //! Consulta Nro. 6
        //Task<List<Mascota>>ListarLaCantidadDeMascotasQuePertenecenAUnaRazaAUnaRazaNotaSeDebeMostrarUnaListaDeLasRazasYLaCantidadDeMascotasQuePertenecenALaRaza();


    }