using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Facturar
    {
        private CD_Factura objcd_factura = new CD_Factura();

        public List<Factura> Listar()
        {
            return objcd_factura.Listar();
        }

        public void Eliminar(int idFactura)
        {
            objcd_factura.Eliminar(idFactura);
        }

        public void Agregar(string cliente, int idTicket)
        {
            // Obtenemos el ticket desde la capa de datos utilizando su ID
            Ticket ticket = ObtenerTicketPorId(idTicket);

            if (ticket != null)
            {
                Factura nuevaFactura = new Factura()
                {
                    cliente = cliente,
                    oTicket = ticket,
                    Fecha = int.Parse(DateTime.Now.ToString("yyyyMMdd"))
                };

                objcd_factura.Agregar(nuevaFactura);
            }
            else
            {
                // Manejar el caso donde el ticket no existe
            }
        }

        private Ticket ObtenerTicketPorId(int idTicket)
        {
            // Implementa la lógica para obtener el ticket por su ID desde la capa de datos
            CN_Ticket cn_ticket = new CN_Ticket();
            List<Ticket> listaTickets = cn_ticket.Listar();

            return listaTickets.Find(ticket => ticket.idTicket == idTicket);
        }
    }
}
