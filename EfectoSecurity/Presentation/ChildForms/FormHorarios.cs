using Domain.Configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms
{
    public partial class FormHorarios : Form
    {
        private PuestosModels puestosModel = new PuestosModels();
        private List<PuestosModels> puestosList;
        private HorariosModel horariosModel = new HorariosModel();
        private List<HorariosModel> horariosList;


        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormHorarios()
        {
            InitializeComponent();
            GetInitInformation();
        }

        private void GetInitInformation()
        {
            horariosList = horariosModel.GetHorarios(urlApi).ToList();
            puestosList = puestosModel.GetPuestos(urlApi).ToList();

            foreach (HorariosModel hr in horariosList)
            {
                hr.DescripcionPuesto = puestosList.Where(a => a.Id == hr.IdPuesto).FirstOrDefault().DescripcionPuesto;

                //var dateTime = DateTime.ParseExact(hr.HoraEntrada, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                //DateTime dt = DateTime.ParseExact(hr.HoraEntrada, "yyyy-MM-dd'T'HH:mm:ssZ", CultureInfo.InvariantCulture);
                string temp = hr.HoraEntrada.Substring(11, 8);
                hr.HoraEntrada = DateTime.Parse(temp).TimeOfDay.ToString();
            }
            dataGridView1.DataSource = horariosList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Activo"].Visible = false;
            dataGridView1.Columns["IdPuesto"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var userForm = new FormHorarioMaintenance();
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetInitInformation();
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
                var userDM = await horariosModel.GetHorarioById(urlApi, (string)dataGridView1.CurrentRow.Cells[0].Value);
                if (userDM != null)
                {
                    var userForm = new FormHorarioMaintenance(userDM);
                    DialogResult result = userForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        GetInitInformation();
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

