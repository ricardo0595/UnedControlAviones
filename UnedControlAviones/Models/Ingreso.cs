namespace UnedControlAviones.Models
{
    public class Ingreso
    {
        public int Id { get; set; }
        public String NumeroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public String NombreTecnico { get; set; }
        public int IdAvion { get; set; }
    }
}
