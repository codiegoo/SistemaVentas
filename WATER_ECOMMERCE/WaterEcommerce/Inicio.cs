using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;

namespace WaterEcommerce
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuario objusuario)
        {

            usuarioActual = objusuario;
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Usuario_Click(object sender, EventArgs e)
        {
            
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.nombre;

            if (usuarioActual.rol == "admin")
            {
                // Mostrar elementos del menú para administradores
                Usuarios.Visible = true;
                Inventario.Visible = true;
                Ventas.Visible = true;
                Usuarios.Visible = true;
                

                // Ocultar elementos del menú para usuarios normales
            }
            else if (usuarioActual.rol == "usuario")
            {
                // Mostrar elementos del menú para usuarios normales
                Ventas.Visible = true;

                // Ocultar elementos del menú para administradores
                Usuarios.Visible = false;
                Inventario.Visible = false;
                Ventas.Visible = false;
            }
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmInventario());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Compras());
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) { 
            if(MenuActivo != null) {
                MenuActivo.BackColor = Color.DarkSlateBlue;
            }

            menu.BackColor = Color.MediumPurple;
            MenuActivo = menu;

            if (FormularioActivo != null) {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.MediumPurple;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVentas());
        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {
            
        }

      

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconMenuItem1_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmRoles());
        }

        private void iconMenuItem2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCupones());
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReporte());
        }

        private void iconMenuItem4_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCategorias());
        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }
    }   
}
