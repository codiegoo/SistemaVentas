using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Inventario
    {
        public List<Inventario> Listar()
        {
            List<Inventario> lista = new List<Inventario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT idProducto, cantidadProducto, fechaIngreso FROM Inventario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idProducto = Convert.ToInt32(dr["idProducto"]);

                            lista.Add(new Inventario()
                            {
                                idProducto = idProducto,
                                cantidadProducto = Convert.ToInt32(dr["cantidadProducto"]),
                                fechaIngreso = dr["fechaIngreso"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Inventario>();
                }
            }

            return lista;
        }

        public void Eliminar(int idProducto)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM Inventario WHERE idProducto = @idProducto";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // Manejo de errores según tus necesidades
                }
            }
        }

        public void Agregar(Inventario nuevoInventario)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO Inventario (idProducto, cantidadProducto, fechaIngreso) VALUES (@idProducto, @cantidadProducto, @fechaIngreso)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@idProducto", nuevoInventario.idProducto);
                    cmd.Parameters.AddWithValue("@cantidadProducto", nuevoInventario.cantidadProducto);
                    cmd.Parameters.AddWithValue("@fechaIngreso", nuevoInventario.fechaIngreso);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // Manejo de errores según tus necesidades
                }
            }
        }

        public int ObtenerProductoPorId(int idProducto)
        {
            int productoID = -1;  // Valor por defecto en caso de que no se encuentre el producto

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT idProducto FROM Producto WHERE idProducto = @idProducto";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            productoID = Convert.ToInt32(dr["idProducto"]);
                        }
                    }
                }
                catch (Exception)
                {
                    // Manejo de errores según tus necesidades
                }
            }

            return productoID;
        }

    }
}