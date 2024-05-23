using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clienteServidor.ServiceReference1;

namespace clienteServidor
{
    public partial class Form1 : Form
    {
        private ClienteServiceClient clienteServiceClient;

        public Form1()
        {
            InitializeComponent();
            clienteServiceClient = new ClienteServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            var clientes = clienteServiceClient.ObtenerClientes();
            dataGridViewClientes.DataSource = clientes;
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarClientes();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dataGridViewClientes.CurrentRow.Cells[2].Value;
            tbNombre.Text = cellValue.ToString();

        }

        private void InsertarCliente_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente
            {
                Nombre = tbNombre.Text,
                FechaNacimiento = DateTime.Now
            };

            clienteServiceClient.InsertarCliente(nuevoCliente);
            CargarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente clienteActualizar = (Cliente)dataGridViewClientes.SelectedRows[0].DataBoundItem;

            clienteActualizar.Nombre = tbNombre.Text;

            clienteServiceClient.ModificarCliente(clienteActualizar);
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
