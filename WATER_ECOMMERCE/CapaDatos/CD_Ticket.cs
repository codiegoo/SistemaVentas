using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Ticket
    {

        public List<Ticket> Listar()
        {
            List<Ticket> listaTickets = new List<Ticket>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT idTicket, idUsuario, producto, cantidad, subtotal, fecha FROM Ticket";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaTickets.Add(new Ticket()
                            {
                                idTicket = Convert.ToInt32(dr["idTicket"]),
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                producto = dr["producto"].ToString(),
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                subtotal = Convert.ToDecimal(dr["subtotal"]),
                                fecha = dr["fecha"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    listaTickets = new List<Ticket>();
                }
            }

            return listaTickets;
        }

        public void GenerarTicket(int idUsuario, string nombreProducto, int cantidad)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Obtener el ID del producto desde la capa de datos de inventario
                    int idProducto = ObtenerIdProductoPorNombre(nombreProducto);

                    // Verificar si hay suficiente cantidad en el inventario
                    if (VerificarCantidadInventario(idProducto, cantidad))
                    {
                        // Obtener el precio del producto desde la capa de datos de inventario
                        decimal precioProducto = ObtenerPrecioProducto(idProducto);

                        // Calcular el subtotal
                        decimal subtotal = cantidad * precioProducto;

                        // Insertar el ticket en la base de datos
                        string query = "INSERT INTO Ticket (idUsuario, producto, cantidad, subtotal, fecha) " +
                                       "VALUES (@idUsuario, @nombreProducto, @cantidad, @subtotal, @fecha)";


                        SqlCommand cmd = new SqlCommand(query, oconexion);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);  // Corregir aquí
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@subtotal", subtotal);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                        oconexion.Open();
                        cmd.ExecuteNonQuery();

                        // Actualizar la cantidad en el inventario
                        ActualizarCantidadInventario(idProducto, cantidad);
                    }
                    else
                    {
                        throw new Exception("No hay suficiente cantidad en el inventario.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al generar el ticket: " + ex.Message);
                }
            }
        }

        private int ObtenerIdProductoPorNombre(string nombreProducto)
        {
            int idProducto = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT idProducto FROM Producto WHERE nombreProducto = @producto";  // Corregir aquí
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@producto", nombreProducto);

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idProducto = Convert.ToInt32(dr["idProducto"]);
                    }
                }
            }

            return idProducto;
        }

        private decimal ObtenerPrecioProducto(int idProducto)
        {
            decimal precio = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT precioProducto FROM Producto WHERE idProducto = @producto";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@producto", idProducto);

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        precio = Convert.ToDecimal(dr["precioProducto"]);
                    }
                }
            }

            return precio;
        }

        private bool VerificarCantidadInventario(int idProducto, int cantidad)
        {
            int cantidadEnInventario = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT cantidadProducto FROM Inventario WHERE idProducto = @producto";  // Corregir aquí
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@producto", idProducto);

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cantidadEnInventario = Convert.ToInt32(dr["cantidadProducto"]);
                    }
                }
            }

            return cantidadEnInventario >= cantidad;
        }


        private void ActualizarCantidadInventario(int idProducto, int cantidad)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE Inventario SET cantidadProducto = cantidadProducto - @cantidad " +
                                   "WHERE idProducto = @producto";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@producto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // Manejo de errores según tus necesidades
                }
            }
        }
    }
}
