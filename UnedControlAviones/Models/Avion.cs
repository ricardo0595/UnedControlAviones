namespace UnedControlAviones.Models
{
    public class Avion
    {
        public int Id { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String NumeroSerie { get; set; }
        public String Nombre { get; set; }
        public int AnchoAA { get; set; }
        public int Alto { get; set; }
        public int Largo { get; set; }
        public int Autonomia { get; set; }
        public bool Estado { get; set; }
    }
}
