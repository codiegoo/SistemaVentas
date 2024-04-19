using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    string query = "SELECT idProducto, nombreProducto, descripcionProducto, precioProducto, tipoBoteAgua, fechaEnvasado FROM Producto";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Producto()
                                {
                                    idProducto = Convert.ToInt32(dr["idProducto"]),
                                    nombreProducto = dr["nombreProducto"].ToString(),
                                    descripcionProducto = dr["descripcionProducto"].ToString(),
                                    precioProducto = Convert.ToDecimal(dr["precioProducto"]),
                                    tipoBoteAgua = dr["tipoBoteAgua"].ToString(),
                                    fechaEnvasado = dr["fechaEnvasado"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Producto>();
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
                    string query = "DELETE FROM Producto WHERE idProducto = @idProducto";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }

        public void Agregar(Producto nuevoProducto)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO PRODUCTO(nombreProducto, descripcionProducto, precioProducto, tipoBoteAgua, fechaEnvasado) VALUES (@nombreProducto, @descripcionProducto, @precioProducto, @tipoBoteAgua, @fechaEnvasado)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nombreProducto", nuevoProducto.nombreProducto);
                    cmd.Parameters.AddWithValue("@descripcionProducto", nuevoProducto.descripcionProducto);
                    cmd.Parameters.AddWithValue("@precioProducto", nuevoProducto.precioProducto);
                    cmd.Parameters.AddWithValue("@tipoBoteAgua", nuevoProducto.tipoBoteAgua);
                    cmd.Parameters.AddWithValue("@fechaEnvasado", nuevoProducto.fechaEnvasado);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
