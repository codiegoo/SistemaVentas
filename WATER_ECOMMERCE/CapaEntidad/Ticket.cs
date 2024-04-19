
namespace CapaEntidad
{
    public class Ticket
    {
        public int idTicket { get; set; }
        public int idUsuario { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
        public string fecha { get; set; }
    }
}
