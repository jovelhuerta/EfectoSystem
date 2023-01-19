using Domain.Configure;
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

namespace Presentation.ChildForms
{
    public partial class FormVerifyUser : BaseForms.BaseFixedForm
    {
        /// <summary>
        /// Esta clase hereda de la clase BaseFixedForm.
        /// </summary>
        /// 

        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private UserModel userModel = new UserModel();
        private PuestosModels positionModel = new PuestosModels();
        private RolesModels roleModel = new RolesModels();
        private SucursalModel sucursalModel= new SucursalModel();

        public FormVerifyUser()
        {
            InitializeComponent();
            txtConcect.Text = Properties.Settings.Default.ApiEfGym;
            txtNameSucursal.Text = Properties.Settings.Default.Sucursal;
            txtTypeSucursal.Text = Properties.Settings.Default.Tipo;
        }
        private void VerifyConectedUser()
        {

            if (!String.IsNullOrEmpty(txtConcect.Text))
            {
                Properties.Settings.Default.ApiEfGym = txtConcect.Text;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblMessage.Text = "Su contraseña es incorrecto, vuelva a intentarlo";
            }
        }

        private async void SaveSucursal()
        {
            if (!String.IsNullOrEmpty(txtNameSucursal.Text) && !String.IsNullOrEmpty(txtTypeSucursal.Text))
            {
                //Actualizamos las Variables Globales
                Properties.Settings.Default.Sucursal = txtNameSucursal.Text;
                Properties.Settings.Default.Tipo = txtTypeSucursal.Text;
                Properties.Settings.Default.Save();
                //Guardamos el nombre a la API
                int vas=await SendSucursal();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblMessage.Text = "Su contraseña es incorrecto, vuelva a intentarlo";
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            VerifyConectedUser();
        }

        private void txtUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                VerifyConectedUser();
        }

        private async Task<string> CheckDataExist()
        {
            var puesto = positionModel.GetPuestos(urlApi);
            //var sistem = positionModel.GetPuestos(urlApi).Last();
            if (puesto == null || puesto.Count() == 0)//No existen datos en la base
            {
                ///Se crea el puesto
                positionModel.DescripcionPuesto = "ADMINISTRADOR DE SISTEMA";
                int res = await positionModel.CreatePuesto(urlApi);
                var puestoSystem = positionModel.GetPuestos(urlApi).Last();
                int rp= await  CreatePositions();
                //Crear ROL
                roleModel.DescripcionRol = "System Administrator";
                res = await roleModel.CreateRol(urlApi);
                var rolSystem = roleModel.GetRoles(urlApi).Last();
                rp= await CreateRoles();
                //Crear usuario Admin
                List<string>roles= new List<string>();
                roles.Add(rolSystem.DescripcionRol);
                userModel.UserName = "JOVELH";
                userModel.Roles = roles;
                userModel.Puesto = puestoSystem.DescripcionPuesto;
                userModel.Contraseña = "timaster99";
                userModel.NombreUsuario = "JORGE JOVEL GOMEZ HUERTA";
                userModel.NumeroTelefono = "9671437996";
                res = await userModel.CreateUser(urlApi);
                return "Usuario: "+userModel.NombreUsuario+ " Creado";
            }
            return "Datos Prioritarios Existentes";
        }

        private async Task<int> CreatePositions()
        {
            positionModel = new PuestosModels();
            positionModel.DescripcionPuesto = "GERENTE GENERAL";
            int res = await positionModel.CreatePuesto(urlApi);
            positionModel = new PuestosModels();
            positionModel.DescripcionPuesto = "ENTRENADOR";
            res = await positionModel.CreatePuesto(urlApi);
            positionModel = new PuestosModels();
            positionModel.DescripcionPuesto = "RECEPCION";
            res = await positionModel.CreatePuesto(urlApi);
            return 1;
        }

        private async Task<int> CreateRoles()
        {
            roleModel = new RolesModels();
            roleModel.DescripcionRol = "General Manager";
            int res = await roleModel.CreateRol(urlApi);
            roleModel = new RolesModels();
            roleModel.DescripcionRol = "Trainer";
            res = await roleModel.CreateRol(urlApi);
            roleModel = new RolesModels();
            roleModel.DescripcionRol = "Receptionist";
            res = await roleModel.CreateRol(urlApi);
            return 1;
        }

        private async Task<int> SendSucursal()
        {
            sucursalModel = new SucursalModel();
            sucursalModel.Sucursal = txtNameSucursal.Text;
            sucursalModel.Tipo = txtTypeSucursal.Text;
            sucursalModel.Activo = true;
            int res = await sucursalModel.CreateSucursal(urlApi);
            return 1;
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
           lblMessage.Text= await CheckDataExist();

        }

        private void btnSaveSucursal_Click(object sender, EventArgs e)
        {
            SaveSucursal();
        }
    }
}
