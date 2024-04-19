using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Informe
    {
        public int idInforme { get; set; }
        public Usuario oUsuarios { get; set; }
        public string tipoInforme { get; set; }
        public string contenido { get; set; }
        
    }
}
