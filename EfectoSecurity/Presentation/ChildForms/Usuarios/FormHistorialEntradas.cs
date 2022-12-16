using Common;
using Domain.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms.Usuarios
{
    public partial class FormHistorialEntradas : Form
    {
        private UserModel userModel = new UserModel();
        private List<UserModel> userList;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormHistorialEntradas()
        {
            InitializeComponent();
            ListUsers();
        }

        private void ListUsers()
        {
            userList = userModel.GetAllUsers(urlApi).ToList().Where(b=>b.Puesto != Positions.SystemAdministrator).ToList();
            
            dataGridView1.DataSource = userList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Entrada"].Visible = false;
            dataGridView1.Columns["Contraseña"].Visible = false;
            dataGridView1.Columns["FingerPrint"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Editar usuario.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                //var userDM = await userModel.GetUserById(urlApi, (string)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetUser(id).
                    var userForm = new FormHistoryByUser((string)dataGridView1.CurrentRow.Cells[0].Value,""+DateTime.Parse(FechaInicio.Text).Ticks,
                                                                                                        ""+DateTime.Parse(Fechafinal.Text).Ticks);
                    DialogResult result = userForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ListUsers();
                    }
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
