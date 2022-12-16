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
    public partial class FormHorarioMaintenance : BaseForms.BaseFixedForm
    {
        private HorariosModel horariosModel;
        private PuestosModels puestosModel = new PuestosModels();

        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private bool horarioModify;
        private string horarioId;

        public FormHorarioMaintenance()
        {
            InitializeComponent();
            horariosModel = new HorariosModel();
            lblCaption.Text = "Agregar nuevo Horario";
            horarioModify = false;
            SetFieldsCombo();
        }

        public FormHorarioMaintenance(HorariosModel model)
        {
            InitializeComponent();
            this.TitleBarColor = Color.MediumSeaGreen;
            btnSave.BackColor = Color.MediumSeaGreen;

            lblCaption.Text = "Modificar horario";
            SetFieldsCombo();
            
            horariosModel = model;
            horarioModify = true;
            FillFields();
        }

        private void SetFieldsCombo()
        {
            cmbPuesto.DataSource = puestosModel.GetPuestos(urlApi).ToList();
            cmbPuesto.DisplayMember = "descripcionPuesto";
            cmbPuesto.ValueMember = "id";
        }

        /// <summary>
        /// Metodo que llena Del Modelo al Formulario
        /// </summary>
        private void FillFields()
        {
            horarioId = horariosModel.Id;
            string temp = horariosModel.HoraEntrada.Substring(11, 8);
            txtHora.Value = DateTime.Parse(temp);
            txtTolerancia.Text = ""+horariosModel.MinutosTolerancia;
            cmbPuesto.Text = horariosModel.IdPuesto;
        }

        /// <summary>
        /// Metodo que llena del formulario al modelo
        /// </summary>
        private void FillPlanModel()
        {
            DateTime myDate = txtHora.Value.Date +
                    txtHora.Value.TimeOfDay;
            horariosModel.Id = horarioId;
            horariosModel.HoraEntrada= myDate.ToString();
            horariosModel.MinutosTolerancia = int.Parse(txtTolerancia.Text.Trim());
            horariosModel.IdPuesto = (string)cmbPuesto.SelectedValue;
        }

        /// <summary>
        /// Metodo que realiza guardar nuevo o Editar Registro
        /// </summary>
        /// 
        private async void SaveMethod()
        {
            int result = -1;
            try
            {
                FillPlanModel();
                var validateData = new DataValidation(horariosModel);//Validar campos del objeto.
                if (validateData.Result)
                {
                    if (horarioModify)
                    {
                        result = await horariosModel.ModifyHorario(urlApi);
                        if (result > 0)
                        {
                            MessageBox.Show("Horario actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        result = await horariosModel.CreateHorario(urlApi);
                        if (result > 0)
                        {
                            MessageBox.Show("Horario agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; 
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMethod();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
