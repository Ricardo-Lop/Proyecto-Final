namespace Proyecto_Final.Models
{
    public class DetalleTicket
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public Ticket? Ticket { get; set; }

        public int ProductoApiId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
    }
}