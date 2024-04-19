using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {
        public int idFactura { get; set; }
        public string cliente { get; set; }
        public Ticket oTicket { get; set; }
        public int Fecha { get; set; }
    }
}
