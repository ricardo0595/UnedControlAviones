namespace UnedControlAviones.Models
{
    public class Retiro
    {
        public int Id { get; set; }
        public String NombreTecnico { get; set; }
        public String Detalle { get; set; }
        public int IdAvion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
