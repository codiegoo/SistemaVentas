using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public decimal precioProducto { get; set; }
        public string tipoBoteAgua { get; set; }
        public string fechaEnvasado { get; set; }

    }
}
