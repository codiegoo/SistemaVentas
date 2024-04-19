using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WaterEcommerce
{
    public partial class frmVentas : Form
    {
        private CN_Ticket cnTicket = new CN_Ticket();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void CargarVentas()
        {
            try
            {
                List<Ticket> listaTickets = cnTicket.Listar();
                dgvVentas.DataSource = listaTickets;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvVentas.AutoGenerateColumns = true;
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para generar una "venta" si es necesario
            // Por ejemplo, puedes llamar a un método en la capa de negocio de Ticket

            // Después de generar la "venta", actualiza la información en el DataGridView
            CargarVentas();

            MessageBox.Show("Venta generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ObtenerIdUsuario()
        {
            // Implementar lógica para obtener el ID del usuario logeado
            // ...

            return 1; // Reemplazar con el valor correcto
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }
    }
}
