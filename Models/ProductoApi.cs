namespace Proyecto_Final.Models
{
    public class ProductoApi
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        public string Laboratorio { get; set; } = "";

        public string Presentacion { get; set; } = "";

        public decimal Precio { get; set; }

        public string Especialidad { get; set; } = "";
    }
}