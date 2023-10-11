namespace API.Dtos.Cita;
    public class CitaPostDto
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public DateTime ? FechaCita { get; set; }
        public string ? Motivo { get; set; }
        public int VeterinarioId { get; set; }

}