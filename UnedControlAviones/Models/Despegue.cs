namespace UnedControlAviones.Models
{
    public class Despegue
    {
        public int Id { get; set; }
        public String NumeroDespegue { get; set; }
        public int IdAvion { get; set; }
        public DateTime FechaHoraDespegue { get; set; }
        public String NombrePiloto { get; set; }
        public String NombreTecnico { get; set; }
        public String NombreMision { get; set; }
    }
}
