using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterEcommerce
{
    public partial class frmInventario : Form
    {

        private CN_Producto cnProducto = new CN_Producto();
        private CN_Inventario cnInventario = new CN_Inventario();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                List<Producto> listaProductos = cnProducto.Listar();
                Console.WriteLine("Cantidad de productos cargados: " + listaProductos.Count);
                dgvProductos.DataSource = listaProductos;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar productos: " + ex.Message);
            }
        }


        private void agregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Iniciando agregarProducto_Click");
                Producto nuevoProducto = new Producto()
                {
                    nombreProducto = txtnombreProducto.Text,
                    descripcionProducto = txtdescripcionProducto.Text,
                    precioProducto = Convert.ToDecimal(txtprecio.Text),
                    tipoBoteAgua = txttipoBote.Text,
                    fechaEnvasado = DateTime.Now.ToString("yyyy-MM-dd")
                };

                cnProducto.Agregar(nuevoProducto);
                Console.WriteLine("Producto agregado con éxito");


                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción producida: {ex}");
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



 



    
        private void ConfigurarDataGridView()
        {
            dgvProductos.AutoGenerateColumns = true;
        }


        private void LimpiarCampos()
        {
            txtnombreProducto.Text = "";
            txtdescripcionProducto.Text = "";
            txtprecio.Text = "";
            txttipoBote.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
