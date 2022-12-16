using Common;
using Domain;
using Domain.Configure;
using Domain.User;
using Presentation.BaseForms;
using Presentation.Helpers;
using Presentation.Utils;
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
    public partial class FormUserMaintenance : BaseForms.BaseFixedForm
    {
        private DPFP.Template Template;
        #region -> Campos
        private PuestosModels positionModel = new PuestosModels();
        private RolesModels roleModel = new RolesModels();
        private UserModel userModel;
        private bool userModify;
        private string userId;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        #endregion

        #region -> Constructores

        public FormUserMaintenance()
        {//Utilice este constructor cuando desee agregar un nuevo usuario.

            InitializeComponent();
            lblCaption.Text = "Agregar nuevo usuario";
            userModel = new UserModel();//Inicializar modelo de dominio de usuario.
            userModify = false;//Establecer userModify en falso.

            cmbPosition.DataSource = positionModel.GetPuestos(urlApi).ToArray();
            cmbPosition.DisplayMember = "DescripcionPuesto";
            cmbPosition.ValueMember = "Id";
            cmbPosition.SelectedIndex = -1;//Sin seleccion de indice.

            cmbRoles.DataSource = roleModel.GetRoles(urlApi).ToArray();
            cmbRoles.DisplayMember = "DescripcionRol";
            cmbRoles.ValueMember = "Id";
        }

        public FormUserMaintenance(UserModel _userModel, bool isUserProfile)
        {
            InitializeComponent();
            this.TitleBarColor = Color.MediumSeaGreen;
            btnSave.BackColor = Color.MediumSeaGreen;
            cmbPosition.DataSource = positionModel.GetPuestos(urlApi).ToArray();
            cmbPosition.DisplayMember = "DescripcionPuesto";
            cmbPosition.ValueMember = "Id";

            cmbRoles.DataSource = positionModel.GetPuestos(urlApi).ToArray();
            cmbRoles.DisplayMember = "DescripcionPuesto";
            cmbRoles.ValueMember = "Id";


            userModel = _userModel;
            userModify = true;  
            FillFields();   
            if (isUserProfile) 
            {
                lblCaption.Text = "Actualizar mi perfil de usuario";
                cmbPosition.Enabled = false;
                cmbRoles.Enabled = false;
                txtUsername.Enabled = false;
            }
            else //Caso contrario mostrar titulo  modificar usuario.
                lblCaption.Text = "Modificar usuario";
        }
        #endregion

        #region -> Métodos de Funciones (Guardar y llenar Campos)

        private void FillFields()
        {//Cargar los datos del modelo  en los campos del formulario.
            userId = userModel.Id;
            txtUsername.Text = userModel.UserName;
            //txtPassword.Text = userModel.Password;
            //txtConfirmPass.Text = userModel.Password;
            txtFirstName.Text = userModel.NombreUsuario;
            cmbPosition.Text = userModel.Puesto;
            cmbRoles.SelectedValue = userModel.Roles;
            txtEmail.Text = userModel.NumeroTelefono;
        }

        /// <summary>
        /// Metodo que llena el modelo a enviar para guardar la informacion del usuario nuevo
        /// </summary>
        private void FillUserModel()
        {//LLenar modelo

            userModel.Id = userId;
            userModel.UserName = txtUsername.Text;
            userModel.Contraseña = txtPassword.Text;
            userModel.NombreUsuario = txtFirstName.Text;
            userModel.Puesto = cmbPosition.Text;
            userModel.NumeroTelefono = txtEmail.Text;
            var items = cmbRoles.SelectedItems.Cast<RolesModels>();
            var fin = items.Select(a => a.DescripcionRol).ToList();
            List<string> lstitems = new List<string>();
            foreach (string str in fin)
            {
                lstitems.Add(str);
            }
            userModel.Roles = lstitems;
        }

        /// <summary>
        /// Metodo que se llama para Crear un nuevo Usuario o para Actualizarlo
        /// </summary>
        private async void Save()
        {//Guardar cambios.
            int result = -1;
            try
            {
                FillUserModel();//Obtener modelo de vista.
                var validateData = new DataValidation(userModel);//Validar campos del objeto.
                if (userModify == true)
                {
                    result = await userModel.ModifyUser(urlApi);//Invocar metodo ModifyUser del modelo de usuario.
                    if (result > 0)
                    {
                        MessageBox.Show("Usuario actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;//Establecer Ok como resultado de dialogo del formulario.
                        this.Close();//Cerrar formulario
                    }
                    else
                    {
                        MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    var validatePassword = txtPassword.Text == txtConfirmPass.Text;//Validar contraseñas.
                    if (validateData.Result == true && validatePassword == true)
                    {
                        result = await userModel.CreateUser(urlApi); //Invocar metodo CreateUser del modelo de usuario.

                        if (result > 0)
                        {
                            MessageBox.Show("Usuario agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; //Establecer Ok como resultado de dialogo del formulario.
                            this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else //Si el objeto o contraseña NO es válido, mostrar mensaje segun el caso.
                    {
                        if (validateData.Result == false)
                            MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                            MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }
        }
        #endregion

        #region -> Metodos de eventos

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();//Guardar cambios.
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region -> Metodo para la Captura de la HUELLA
        private void btnRegistrarH_Click(object sender, EventArgs e)
        {
            CatchFingerForm capturar = new CatchFingerForm();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnRegistrarH.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("Se ha capturado la Huella exitosamente.", "Fingerprint Enrollment");
                    userModel.FingerPrint = template.Bytes;
                    txtHuella.Text = Convert.ToBase64String(template.Bytes, 0, template.Bytes.Length);// "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("Error en la Caputara de Huella. favor de intentarlo de nuevo. Cierre la venta y vuelva a intentar", "Fingerprint Enrollment");
                }
            }));
        }

        #endregion
    }
}
