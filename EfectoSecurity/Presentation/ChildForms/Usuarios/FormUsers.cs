using Domain;
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
    public partial class FormUsers : Form
    {
        private UserModel userModel = new UserModel();
        private List<UserModel> userList;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormUsers()
        {
            InitializeComponent();
            ListUsers();
        }

        private void ListUsers()
        {//LLenar la cuadricula de datos con la lista de usuarios.
            userList = userModel.GetAllUsers(urlApi).ToList();//Obtener todos los usuarios.

            dataGridView1.DataSource = userList;//Establecer la fuente de datos.
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Entrada"].Visible = false;
            dataGridView1.Columns["Contraseña"].Visible = false;
            dataGridView1.Columns["FingerPrint"].Visible = false;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            //ListUsers();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {//Agregar nuevo usuario.
            var userForm = new FormUserMaintenance();//Instanciar formulario de mantenimiento sin parametros.
            DialogResult result = userForm.ShowDialog();//Mostrar formulario como ventana de dialogo y guardar resultado.
            if (result == DialogResult.OK)//Si el resultado de dialogo es OK, actualizar vista de datos.
            {
                ListUsers();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            //Editar usuario.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var userDM = await userModel.GetUserById(urlApi, (string)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetUser(id).
                if (userDM != null)
                {
                    var userForm = new FormUserMaintenance(userDM, false);
                    DialogResult result = userForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ListUsers();
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
            //Eliminar usuario.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var result = await userModel.RemoveUser(urlApi,(string)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario e invocar el metodo eliminar usuario del modelo.

                if (result > 0)
                {
                    MessageBox.Show("Usuario eliminado con éxito");
                    ListUsers();
                }
                else MessageBox.Show("No se ha realizado operación, intente nuevamente");
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
