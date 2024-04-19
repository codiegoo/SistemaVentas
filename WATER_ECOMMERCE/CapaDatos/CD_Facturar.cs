using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Factura
    {
        public List<Factura> Listar()
        {
            List<Factura> lista = new List<Factura>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT idFactura, cliente, Fecha, idTicket FROM Factura";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        oconexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Factura()
                                {
                                    idFactura = Convert.ToInt32(dr["idFactura"]),
                                    cliente = dr["cliente"].ToString(),
                                    Fecha = Convert.ToInt32(dr["Fecha"]),
                                    oTicket = new Ticket() { idTicket = Convert.ToInt32(dr["idTicket"]) }
                                });
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Factura>();
                }

                return lista;
            }
        }

        public void Eliminar(int idFactura)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM Factura WHERE idFactura = @idFactura";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // Manejo de excepciones
                }
            }
        }

        public void Agregar(Factura nuevaFactura)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO Factura (cliente, idTicket, Fecha) " +
                                   "VALUES (@cliente, @idTicket, @Fecha)";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@cliente", nuevaFactura.cliente);
                        cmd.Parameters.AddWithValue("@idTicket", nuevaFactura.oTicket.idTicket); // Usar el ID del ticket
                        cmd.Parameters.AddWithValue("@Fecha", nuevaFactura.Fecha);

                        oconexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    // Manejo de excepciones
                }
            }
        }
    }
}
