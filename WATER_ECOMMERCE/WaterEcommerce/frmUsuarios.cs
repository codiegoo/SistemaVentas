using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;

namespace WaterEcommerce
{
    public partial class frmUsuarios : Form
    {
        private CN_Usuario cn_usuario = new CN_Usuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> listaUsuarios = cn_usuario.Listar();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario()
            {
                nombre = txtnombre.Text,
                pass = txtclave.Text,
                direccion = txtdireccion.Text,
                datosContacto = txtdatosContacto.Text,
                rol = txtrol.Text
            };
            cn_usuario.Agregar(nuevoUsuario);


            LimpiarCampos();


            CargarUsuarios();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtdeleteUser.Text, out int idUsuario))
            {
                cn_usuario.Eliminar(idUsuario);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtdeleteUser.Text = "";
            txtnombre.Text = "";
            txtclave.Text = "";
            txtdireccion.Text = "";
            txtdatosContacto.Text = "";
            txtrol.Text = "";
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdeleteUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdatosContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
