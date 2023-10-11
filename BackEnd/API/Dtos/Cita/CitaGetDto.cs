namespace API.Dtos.Cita;
    public class CitaGetDto 
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }

        public List<TratamientoMedicoDto> ? TratamientoMedicos { get; set; }
    }
