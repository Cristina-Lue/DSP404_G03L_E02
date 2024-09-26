namespace The_Temper_Trap.Models
{
    public class MenuItem
    {
        public int Id { get; set; } // Identificador único
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; } // Nueva propiedad Cantidad
    }
}
