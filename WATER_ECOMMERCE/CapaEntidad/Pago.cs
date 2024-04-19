using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pago
    {
        public int idPago { get; set; }
        public Usuario oUsuario { get; set; }
        public int monto { get; set; }
        public string fecha { get; set; }
    }
}
