
using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Ticket
    {
        private CD_Ticket objcd_ticket = new CD_Ticket();

        public List<Ticket> Listar()
        {
            return objcd_ticket.Listar();
        }

        public void GenerarTicket(int idUsuario, string nombreProducto, int cantidad)
        {
            objcd_ticket.GenerarTicket(idUsuario, nombreProducto, cantidad);
        }
    }
}
