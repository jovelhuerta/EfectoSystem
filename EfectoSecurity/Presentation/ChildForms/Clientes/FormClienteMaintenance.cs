using Presentation.BaseForms;
using Presentation.Helpers;
using Presentation.Utils;
using DevExpress.Utils;
using Domain.Clients;
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
using Common.Cache;
using System.Globalization;
using DevExpress.XtraPrinting.Export.Pdf;

namespace Presentation.ChildForms.Clientes
{
    public partial class FormClienteMaintenance : BaseForms.BaseFixedForm
    {
        private DPFP.Template Template;
        private UserModel usModel = new UserModel();
        private PlanesModel plModel = new PlanesModel();
        //private List<PlanesModel> ltsPlanes;
        private ClientModel cltModel;
        private bool profileIs;
        private bool modify;
        private string clienteId;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private readonly string sucursalProp = Properties.Settings.Default.Sucursal;

        public FormClienteMaintenance()
        {
            InitializeComponent();
            lblCaption.Text = "Agregar nuevo Cliente";
            cltModel = new ClientModel();

            modify = false;
            SetEntrenadoresCMB();
            HideOrShowFields(false);
        }

        public FormClienteMaintenance(ClientModel mod, bool isProfile)
        {
            InitializeComponent();
            this.TitleBarColor = Color.MediumSeaGreen;
            btnSave.BackColor = Color.MediumSeaGreen;
            modify = true;
            SetEntrenadoresCMB();
            HideOrShowFields(true);
            profileIs = isProfile;
            cltModel = mod;
            if (isProfile)
            {
                dateVencimiento.Enabled = true;
                dateVenciEntr.Enabled = true;
                cltModel.EditVigencia = true;
                cltModel.EditVigenciaEntrenador = true;
            }
            
            ModelToFill();

        }

        /// <summary>
        /// Metodo que llena el combo de los entrenadores
        /// </summary>
        private void SetEntrenadoresCMB()
        {
            UserModel tem = new UserModel();
            tem.NombreUsuario = "SIN ENTRENADOR";
            List<UserModel> lts = new List<UserModel>();
            lts.Add(tem);
            lts.AddRange(usModel.GetAllUsers(urlApi).ToList().Where(a => a.Puesto == "ENTRENADOR").ToList());


            cmbEntrenador.DataSource = lts;
            cmbEntrenador.DisplayMember = "NombreUsuario";
            cmbEntrenador.ValueMember = "NombreUsuario";

            //ltsPlanes = plModel.GetPlanes(urlApi).ToList();
        }

        /// <summary>
        /// Metodo para ocual o mostrar campos
        /// </summary>
        /// <param name="action"></param>
        private void HideOrShowFields(bool action)
        {
            lblPlanActual.Visible = action;
            txtPlanActual.Visible = action;
            lblVencimiento.Visible = action;
            dateVencimiento.Visible = action;
            lblPago.Visible = action;
            txtPago.Visible = action;
            lblPlanEnt.Visible = action;
            txtPlanEnt.Visible = action;
            lblVenEnt.Visible = action;
            dateVenciEntr.Visible = action;
            lblUltEnt.Visible = action;
            txtPagoEnt.Visible = action;

            txtPago.Enabled = false;
            txtPagoEnt.Enabled = false;
            dateVencimiento.Enabled = false;
            dateVenciEntr.Enabled = false;
            txtPlanEnt.Enabled = false;
            txtPlanActual.Enabled = false;
            lblPlanEnt.Enabled = false;
        }

        /// <summary>
        /// Metodo que llena los campos desde el modelo
        /// </summary>
        private void ModelToFill()
        {
            clienteId = cltModel.Id;
            txtName.Text = cltModel.NombreCliente;
            txtPlanActual.Text = cltModel.PlanActual;
            txtTelefono.Text = cltModel.NumeroTelefono;
            lblSucursal.Text = cltModel.Sucursal;
            dateVencimiento.Value = DateTime.Parse( cltModel.FechaVencimiento,CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
            txtPlanEnt.Text = cltModel.PlanEntrenador;
            if(cltModel.FechaEntrenador!=null)
                dateVenciEntr.Value = DateTime.Parse(cltModel.FechaEntrenador, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
            cmbEntrenador.Text = cltModel.EntrenadorActual;
            DateTime now = DateTime.Now;
            DateTime ven = DateTime.Parse(cltModel.FechaVencimiento);
            
            TimeSpan difFechas = ven - now;
            
            lblInfo.Visible = false;
            lblInfoEnt.Visible = false;
            if (difFechas.Days <= 0)
            {
                dateVencimiento.CalendarForeColor = Color.Red;
                lblInfo.Visible = true;
                lblInfo.Text = "PLAN VENCIDO";
                lblInfo.ForeColor = Color.Red;
            }
            if (cltModel.FechaEntrenador != null)
            {
                DateTime venEnt = DateTime.Parse(cltModel.FechaEntrenador);
                TimeSpan difFechasEnt = venEnt - now;
                if (difFechasEnt.Days <= 0)
                {
                    dateVenciEntr.CalendarForeColor = Color.Red;
                    lblInfoEnt.Visible = true;
                    lblInfoEnt.Text = "PLAN VENCIDO";
                    lblInfoEnt.ForeColor = Color.Red;
                }
            }
                
        }

        /// <summary>
        /// Metodo que llena el Modelo desde los campos
        /// </summary>
        private void FillToModel()
        {
            cltModel.Id = clienteId;
            cltModel.EntrenadorActual = cmbEntrenador.Text;
            cltModel.FechaVencimiento = dateVencimiento.Text;
            cltModel.IdUsuario = UserCache.IdUser;
            cltModel.NombreCliente = txtName.Text;
            cltModel.NumeroTelefono = txtTelefono.Text;
            cltModel.PlanActual = txtPlanActual.Text;
            cltModel.TotalPagado = txtPago.Text;
            cltModel.PlanEntrenador = txtPlanEnt.Text; //Plan del Entrenador
            cltModel.FechaEntrenador = dateVenciEntr.Text;
            cltModel.Sucursal = sucursalProp;
        }

        /// <summary>
        /// Metodo para guardar o modificar
        /// </summary>
        private async void Save()
        {
            int result = -1;
            try
            {
                FillToModel();
                var validateData = new DataValidation(cltModel);
                if (validateData.Result)
                {
                    if (modify)
                    {
                        result = await cltModel.ModifyClient(urlApi);
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        result = await cltModel.CreateClient(urlApi);
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var message = ExceptionManager.GetMessage(ex);
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnPlan_Click(object sender, EventArgs e)
        {
            var userForm = new FormSelectPlan(true);
            AddOwnedForm(userForm);
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                dateVencimiento.BackColor = Color.LightGray;
                //if (profileIs)//Si viene de Editar
                //{

                //    DateTime now = DateTime.Now;
                //    DateTime ven = DateTime.Parse(txtVencimiento.Text);
                //    TimeSpan difFechas = ven - now;
                //    DateTime fv = DateTime.Parse(dateVencimiento.Text);
                //    fv = fv.AddDays(difFechas.Days+1);
                //    dateVencimiento.Text = fv.ToShortDateString();
                //}
                //else
                dateVencimiento.Text = txtVencimiento.Text;
                cltModel.EditVigencia = false;
                HideOrShowFields(true);
                dateVencimiento.Enabled = true;
            }
        }

        private void btnPlanEntrenador_Click(object sender, EventArgs e)
        {
            var userForm = new FormSelectPlan(false);
            AddOwnedForm(userForm);
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                dateVenciEntr.BackColor = Color.LightGray;
                //if (profileIs)//Si viene de Editar
                //{

                //    DateTime now = DateTime.Now;
                //    DateTime ven = DateTime.Parse(txtVencimiento.Text);
                //    TimeSpan difFechas = ven - now;
                //    DateTime fv = DateTime.Parse(dateVencimiento.Text);
                //    fv = fv.AddDays(difFechas.Days+1);
                //    dateVencimiento.Text = fv.ToShortDateString();
                //}
                //else
                dateVenciEntr.Text = txtVencEntr.Text;
                cltModel.EditVigenciaEntrenador = false;
                HideOrShowFields(true);
                dateVenciEntr.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }


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
                    MessageBox.Show("Se ha capturado exitosamente la Huella", "Caputara de Huella");
                    cltModel.FingerPrint = template.Bytes;
                    //txtHuella.Text = Convert.ToBase64String(template.Bytes, 0, template.Bytes.Length);// "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("No fue posible la caputara de Huella. Repite el procedimiento", "Fingerprint Enrollment");
                }
            }));
        }

        #endregion

        
    }
}
