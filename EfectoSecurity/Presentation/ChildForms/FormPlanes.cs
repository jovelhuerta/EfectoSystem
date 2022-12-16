using System;
using Domain.Configure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms
{
    public partial class FormPlanes : Form
    {
        private PlanesModel planModel = new PlanesModel();
        private List<PlanesModel> planList;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormPlanes()
        {
            InitializeComponent();
            ListPlanes();
        }

        private void ListPlanes()
        {
            planList = planModel.GetPlanes(urlApi).ToList();

            foreach(PlanesModel planesModel in planList)
            {
                if (planesModel.TipoVigencia == 0)
                    planesModel.DescripcionVigencia = "DIA/DIAS";
                else
                    planesModel.DescripcionVigencia = "MES/MESES";
            }
            dataGridView1.DataSource = planList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Activo"].Visible = false;
            dataGridView1.Columns["TipoVigencia"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var userForm = new FormPlanMaintenance();//Instanciar formulario de mantenimiento sin parametros.
            DialogResult result = userForm.ShowDialog();//Mostrar formulario como ventana de dialogo y guardar resultado.
            if (result == DialogResult.OK)//Si el resultado de dialogo es OK, actualizar vista de datos.
            {
                ListPlanes();
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
                var userDM = await planModel.GetPlanById(urlApi, (string)dataGridView1.CurrentRow.Cells[0].Value);
                if (userDM != null)
                {
                    var userForm = new FormPlanMaintenance(userDM);
                    DialogResult result = userForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ListPlanes();
                    }
                }
                else
                    MessageBox.Show("No se ha encontrado plan", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
