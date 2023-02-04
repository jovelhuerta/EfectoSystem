using Domain.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Presentation.ChildForms.Clientes
{
    public partial class FormClientes : Form
    {
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private ClientModel cltModel = new ClientModel();
        private List<ClientModel> ltsCliente;
        public FormClientes()
        {
            InitializeComponent();
            GetAllClients();
        }

        private void GetAllClients()
        {
            ltsCliente = cltModel.GetAllClients(urlApi).ToList();


            dataGridView1.DataSource = ltsCliente;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Activo"].Visible = false;
            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["FingerPrint"].Visible = false;
            dataGridView1.Columns["FechaIngreso"].Visible = false;
            dataGridView1.Columns["TotalPagado"].Visible = false;
            dataGridView1.Columns["EditVigencia"].Visible = false;
            dataGridView1.Columns["EditVigenciaEntrenador"].Visible = false;
            dataGridView1.Columns["NumeroCliente"].Visible = false;
            setColorToGrid();
            setColorToGrid();
        }

        private void setColorToGrid()
        {
            string data = string.Empty;
            int indexOfYourColumn = 5;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                data = (string)row.Cells[indexOfYourColumn].Value;
                DateTime now = DateTime.Now;
                DateTime ven = DateTime.Parse(data);
                TimeSpan difFechas = ven - now;
                if (difFechas.Days <= 0)
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var userForm = new FormClienteMaintenance();
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetAllClients();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var userDM = await cltModel.GetClientByNum(urlApi, (string)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetUser(id).
                if (userDM != null)
                {
                    var userForm = new FormClienteMaintenance(userDM, false);
                    DialogResult result = userForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        GetAllClients();
                    }
                }
                else
                    MessageBox.Show("No se ha encontrado usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            var dom = await cltModel.CleanClients(urlApi);
            MessageBox.Show("Limpieza de Clientes no renovados ha finalizado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllClients();
            
        }
    }
}
