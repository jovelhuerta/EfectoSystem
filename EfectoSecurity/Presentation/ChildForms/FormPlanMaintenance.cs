using Domain.Configure;
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

namespace Presentation.ChildForms
{
    public partial class FormPlanMaintenance : BaseForms.BaseFixedForm
    {
        private PlanesModel planModel;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private bool planModify;
        private string planId;
        private List<object> objPlan = new List<object>();
        public FormPlanMaintenance()
        {

            InitializeComponent();
            lblCaption.Text = "Agregar nuevo Plan";
            planModel = new PlanesModel();
            planModify = false;
            SetFieldsCMB();
        }
        public FormPlanMaintenance(PlanesModel plan)
        {
            InitializeComponent();
            this.TitleBarColor = Color.MediumSeaGreen;
            btnSave.BackColor = Color.MediumSeaGreen;

            lblCaption.Text = "Modificar plan";
            SetFieldsCMB();
            planModel = plan;
            planModify = true;
            FillFields();
        }

        /// <summary>
        /// Metodo que llena el combo de Tipos de Vigencia
        /// </summary>
        private void SetFieldsCMB()
        {
            var v = new { id = 0, descripcion = "DIA/DIAS" };
            objPlan.Add(v);
            v = new { id = 1, descripcion = "MES/MESES" };
            objPlan.Add(v);

            cmbTipo.DataSource = objPlan;
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "id";
        }

        /// <summary>
        /// Metodo que llena de los campos del formulario al Modelo
        /// </summary>
        private void FillPlanModel()
        {
            planModel.Id = planId;
            planModel.Costo = int.Parse(txtCosto.Text.Trim());
            planModel.Descripcion = txtName.Text.ToUpper();
            planModel.TipoVigencia = cmbTipo.SelectedIndex;
            planModel.Vigencia = int.Parse(txtVigencia.Text.Trim());
        }

        /// <summary>
        /// Metodo que llenas los campos del Modelo al Formulario 
        /// </summary>
        private void FillFields()
        {//Cargar los datos del modelo  en los campos del formulario.
            planId = planModel.Id;
            txtName.Text = planModel.Descripcion;
            txtCosto.Text = ""+planModel.Costo;
            txtVigencia.Text = ""+planModel.Vigencia;
            cmbTipo.Text = ""+planModel.TipoVigencia;
        }

        /// <summary>
        /// Metodo que realiza el llamado para crear o modificar
        /// </summary>
        private async void Save()
        {
            int result = -1;
            try
            {
                FillPlanModel();
                var validateData = new DataValidation(planModel);//Validar campos del objeto.

                if (validateData.Result)
                {
                    if (planModify)
                    {
                        result = await planModel.ModifyPlan(urlApi);//Invocar metodo ModifyUser del modelo de usuario.
                        if (result > 0)
                        {
                            MessageBox.Show("Plan actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        result = await planModel.CreatePlan(urlApi);
                        if (result > 0)
                        {
                            MessageBox.Show("Plan agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; //Establecer Ok como resultado de dialogo del formulario.
                            this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else //Si el objeto o contraseña NO es válido, mostrar mensaje segun el caso.
                {
                        MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
