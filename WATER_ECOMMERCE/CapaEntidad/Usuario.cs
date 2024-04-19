using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set;}
        public string pass { get; set;}
        public string direccion { get; set;}
        public string datosContacto { get; set; }
        public string rol {  get; set;} 
    }
}
