using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar() {

            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)){

                try{

                    string query = "select idUsuario, nombre, pass, direccion, datosContacto, rol from Usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()){ 
                        while (dr.Read()){
                            lista.Add(new Usuario(){
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                nombre = dr["nombre"].ToString(),
                                pass = dr["pass"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                datosContacto = dr["datosContacto"].ToString(),
                                rol = dr["rol"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ){ 

                    lista = new List<Usuario>();
                }
            }

            return lista;

        }


        public void Eliminar(int idUsuario)
    {

        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        {
            try
            {
                string query = "DELETE FROM Usuario WHERE idUsuario = @idUsuario";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                oconexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
    }

    public void Agregar(Usuario nuevoUsuario)
    {

        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        {
            try
            {
                string query = "INSERT INTO Usuario (nombre, pass, direccion, datosContacto, rol) VALUES (@nombre, @pass, @direccion, @datosContacto, @rol)";

                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@nombre", nuevoUsuario.nombre);
                cmd.Parameters.AddWithValue("@pass", nuevoUsuario.pass);
                cmd.Parameters.AddWithValue("@direccion", nuevoUsuario.direccion);
                cmd.Parameters.AddWithValue("@datosContacto", nuevoUsuario.datosContacto);
                cmd.Parameters.AddWithValue("@rol", nuevoUsuario.rol);

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
