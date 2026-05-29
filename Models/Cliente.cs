using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = "";

        [Required]
        public string Telefono { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        public DateTime FechaRegistro { get; set; }
            = DateTime.Now;
    }
}