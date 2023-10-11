namespace Core.Entities;
    public class DetalleMovimiento : BaseEntity{
        
        public int ProductoId { get; set; }
        public Medicamento ? Medicamentos { get; set; }
        public int Cantidad { get; set; }
        public int MovimientoMedicamentoId { get; set; }
        public MovimientoMedicamento ? MovimientoMedicamentos { get; set; }
        public int TipoMovimientoId { get; set; }
        public TipoMovimiento ? TipoMovimientos { get; set; }
        public string ? PrecioTotal { get; set; }  

    }
