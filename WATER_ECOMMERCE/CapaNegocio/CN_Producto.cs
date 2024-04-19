using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return objcd_producto.Listar();
        }

        public void Agregar(Producto nuevoProducto)
        {
            objcd_producto.Agregar(nuevoProducto);
        }

        public void Eliminar(int idProducto)
        {
            objcd_producto.Eliminar(idProducto);
        }

    }
}
