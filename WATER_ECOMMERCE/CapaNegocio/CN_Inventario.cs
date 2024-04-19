using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Inventario
    {
        private CD_Inventario objcd_inventario = new CD_Inventario();

        public List<Inventario> Listar()
        {
            return objcd_inventario.Listar();
        }

        public void Eliminar(int idProducto)
        {
            objcd_inventario.Eliminar(idProducto);
        }

        public void Agregar(Inventario nuevoInventario)
        {
            objcd_inventario.Agregar(nuevoInventario);
        }

        public int ObtenerProductoPorId(int idProducto)
        {
            return objcd_inventario.ObtenerProductoPorId(idProducto);
        }

    }
}
