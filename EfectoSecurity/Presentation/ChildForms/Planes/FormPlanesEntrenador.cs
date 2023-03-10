using Domain.Configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms.Planes
{
    public partial class FormPlanesEntrenador : Form
    {
        private PlanesEntrenadorModel planModel = new PlanesEntrenadorModel();
        private List<PlanesEntrenadorModel> planList;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormPlanesEntrenador()
        {
            InitializeComponent();
            ListPlanes();
        }

        private void ListPlanes()
        {
            planList = planModel.GetPlanes(urlApi).ToList();

            foreach (PlanesEntrenadorModel planesModel in planList)
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
            var userForm = new FormPlanEntrenadorMaintenance();//Instanciar formulario de mantenimiento sin parametros.
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
                    var userForm = new FormPlanEntrenadorMaintenance(userDM);
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

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var userDM = await planModel.DeletePlan(urlApi, (string)dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show("Plan eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListPlanes();


            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
