using Common.Cache;
using Domain.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms.Clientes
{
    delegate void Function();
    public partial class FormCheckInClient : Form, DPFP.Capture.EventHandler
    {
        /// <summary>
        /// Variables para la Verificacion de huella
        /// </summary>
        private DPFP.Capture.Capture Capturer;
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        public ClientModel fingerclieModel;

        public ClientModel cltModels;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private List<ClientModel> ltsClientes;

        public FormCheckInClient()
        {
            cltModels = new ClientModel();
            ltsClientes = cltModels.GetAllClients(urlApi).ToList();
            InitializeComponent();
        }

        #region -> Metodos y funciones del formulario

        private void btnVerify_Click(object sender, EventArgs e)
        {
            FormVerify verify = new FormVerify();
            AddOwnedForm(verify);
            verify.ShowDialog();

            ModelToFill(true);
        }

        /// <summary>
        /// Metodo que llena las campos desde el modelo cuando se busca al cliente
        /// </summary>
        /// <param name="isCheck"></param>
        private void ModelToFill(bool isCheck)
        {
            if (cltModels != null)
            {
                if (isCheck && cltModels.Id != null)
                    cltModels.CheckIn(urlApi, cltModels.Id, UserCache.IdUser);
                try
                {
                    if (cltModels.Id != null)
                    {
                        DateTime tm = DateTime.Parse(cltModels.FechaVencimiento);
                        txtVencimiento.Text = cltModels.FechaVencimiento;
                        txtTelefono.Text = cltModels.NumeroTelefono;
                        txtPlan.Text = cltModels.PlanActual;
                        txtPlanEnt.Text = cltModels.PlanEntrenador;
                        txtNumero.Text = cltModels.NumeroCliente;
                        txtNombre.Text = cltModels.NombreCliente;
                        txtEntrenador.Text = cltModels.EntrenadorActual;
                        txtIngreso.Text = DateTime.Parse(cltModels.FechaIngreso).ToShortDateString();
                        lblSucursal.Text = cltModels.Sucursal;
                        txtDiasEnt.Text = "";
                        txtVencimientoEnt.Text = "";
                        DateTime now = DateTime.Now;
                        DateTime ven = DateTime.Parse(cltModels.FechaVencimiento);
                        TimeSpan difFechas = ven - now;
                        txtDias.Text = "" + difFechas.Days;
                        if (difFechas.Days < 7)
                        {
                            lblAlerta.Visible = true;
                            txtVencimiento.BackColor = Color.DarkOrange;
                            lblAlerta.ForeColor = Color.DarkOrange;
                            lblAlerta.Text = "Plan por vencer Dias Restantes:" + difFechas.Days;
                        }
                        if (difFechas.Days <= 0)
                        {
                            lblAlerta.Visible = true;
                            txtVencimiento.BackColor = Color.Red;
                            lblAlerta.ForeColor = Color.Red;
                            lblAlerta.Text = "PLAN VENCIDO";
                        }
                        if (difFechas.Days > 7)
                        {
                            lblAlerta.Visible = false;
                            txtVencimiento.BackColor = Color.LightGray;
                        }
                        if (cltModels.FechaEntrenador != null)
                        {
                            txtVencimientoEnt.Text = cltModels.FechaEntrenador;
                            DateTime venEnt = DateTime.Parse(cltModels.FechaEntrenador);
                            TimeSpan difFechasEnt = venEnt - now;
                            txtDiasEnt.Text = "" + difFechasEnt.Days;
                            if (difFechasEnt.Days < 7)
                            {
                                lblAlertaEnt.Visible = true;
                                txtVencimientoEnt.BackColor = Color.DarkOrange;
                                lblAlertaEnt.ForeColor = Color.DarkOrange;
                                lblAlertaEnt.Text = "Plan por vencer Dias Restantes:" + difFechasEnt.Days;
                            }
                            if (difFechasEnt.Days <= 0)
                            {
                                lblAlertaEnt.Visible = true;
                                txtVencimientoEnt.BackColor = Color.Red;
                                lblAlertaEnt.ForeColor = Color.Red;
                                lblAlertaEnt.Text = "PLAN VENCIDO";
                            }
                            if (difFechasEnt.Days > 7)
                            {
                                lblAlertaEnt.Visible = false;
                                txtVencimientoEnt.BackColor = Color.LightGray;
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                    throw;
                }
            }

        }

        /// <summary>
        /// Metodo que llena los datos del modelo a los campos desde la huella
        /// </summary>
        /// <param name="isCheck"></param>
        /// <param name="isFinger"></param>
        private void ModelToFill(bool isCheck,bool isFinger)
        {
            if (cltModels != null)
            {
                if (isCheck && cltModels.Id != null)
                    cltModels.CheckIn(urlApi, cltModels.Id, UserCache.IdUser);
                try
                {
                    if (cltModels.Id != null)
                    {
                        this.Invoke(new Function(delegate () {
                            
                        
                        DateTime tm = DateTime.Parse(cltModels.FechaVencimiento);
                            tm=tm.AddDays(1);
                        txtVencimiento.Text = cltModels.FechaVencimiento;
                        txtTelefono.Text = cltModels.NumeroTelefono;
                        txtPlan.Text = cltModels.PlanActual;
                        txtPlanEnt.Text= cltModels.PlanEntrenador;
                        txtNumero.Text = cltModels.NumeroCliente;
                        txtNombre.Text = cltModels.NombreCliente;
                        txtEntrenador.Text = cltModels.EntrenadorActual;
                        txtIngreso.Text = DateTime.Parse(cltModels.FechaIngreso).ToShortDateString();
                        txtDiasEnt.Text = "";
                        txtVencimientoEnt.Text = "";
                        DateTime now = DateTime.Now;
                        DateTime ven = DateTime.Parse(cltModels.FechaVencimiento);
                        TimeSpan difFechas = ven - now;
                        txtDias.Text = "" + difFechas.Days;
                        if (difFechas.Days < 7)
                        {
                            lblAlerta.Visible = true;
                            txtVencimiento.BackColor = Color.DarkOrange;
                            lblAlerta.ForeColor = Color.DarkOrange;
                            lblAlerta.Text = "Plan por vencer Dias Restantes:" + difFechas.Days;
                        }
                        if (difFechas.Days <= 0)
                        {
                            lblAlerta.Visible = true;
                            txtVencimiento.BackColor = Color.Red;
                            lblAlerta.ForeColor = Color.Red;
                            lblAlerta.Text = "PLAN VENCIDO";
                        }
                        if (difFechas.Days > 7)
                        {
                            lblAlerta.Visible = false;
                            txtVencimiento.BackColor = Color.LightGray;
                        }

                            if (cltModels.FechaEntrenador != null)
                            {
                                txtVencimientoEnt.Text = cltModels.FechaEntrenador;
                                DateTime venEnt = DateTime.Parse(cltModels.FechaEntrenador);
                                TimeSpan difFechasEnt = venEnt - now;
                                txtDiasEnt.Text = "" + difFechasEnt.Days;
                                if (difFechasEnt.Days < 7)
                                {
                                    lblAlertaEnt.Visible = true;
                                    txtVencimientoEnt.BackColor = Color.DarkOrange;
                                    lblAlertaEnt.ForeColor = Color.DarkOrange;
                                    lblAlertaEnt.Text = "Plan por vencer Dias Restantes:" + difFechasEnt.Days;
                                }
                                if (difFechasEnt.Days <= 0)
                                {
                                    lblAlertaEnt.Visible = true;
                                    txtVencimientoEnt.BackColor = Color.Red;
                                    lblAlertaEnt.ForeColor = Color.Red;
                                    lblAlertaEnt.Text = "PLAN VENCIDO";
                                }
                                if (difFechasEnt.Days > 7)
                                {
                                    lblAlertaEnt.Visible = false;
                                    txtVencimientoEnt.BackColor = Color.LightGray;
                                }
                            }


                        }));
                    }
                }
                catch (Exception e)
                {

                    throw;
                }
            }

        }


        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cltModels.NombreCliente))
            {
                Stop();
                var userForm = new FormClienteMaintenance(cltModels, true);
                DialogResult result = userForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var userDM = await cltModels.GetClientByNum(urlApi, cltModels.Id);
                    cltModels = userDM;
                    ModelToFill(false);
                    ltsClientes = cltModels.GetAllClients(urlApi).ToList();
                    Init();
                    Start();
                }
                else
                {
                    Init();
                    Start();
                }
                
            }
        }

        private async void SearchByName()
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                var Dom = await cltModels.GetClientByName(urlApi, txtName.Text);
                if (Dom == null)
                {
                    MessageBox.Show("Cliente no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¿El Cliente: " + Dom.NombreCliente + " es correcto?", "Cliente Encontrado", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cltModels = Dom;
                        ModelToFill(true);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Favor de escribir nombre completo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Stop();
            var userForm = new FormClienteMaintenance();
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                ltsClientes = cltModels.GetAllClients(urlApi).ToList();
                Init();
                Start();
            }
            else
            {
                Init();
                Start();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchByName();
        }

        #endregion

        #region -> Metodos para la inicializacion del funcionamiento del lector de huellas

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();              // Create a capture operation.
                Verificator = new DPFP.Verification.Verification();
                if (null != Capturer)
                    Capturer.EventHandler = this;                   // Subscribe for capturing events.
                else
                    MessageBox.Show("No se pudo iniciar la operación de captura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar la operación de captura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    
                }
                catch
                {
                    
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {

                }
            }
        }
        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }
        private void FormCheckInClient_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void FormCheckInClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        #endregion
        
        /// <summary>
        /// Metodo para verificar la huella de los clientes
        /// </summary>
        /// <param name="Sample"></param>
        protected void Process(DPFP.Sample Sample)
        {
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;
                bool fined = false;
                //Checar de los clientes la huella que Coincide
                foreach (var emp in ltsClientes.Where(a => a.FingerPrint != null).ToList())
                {
                    stream = new MemoryStream(emp.FingerPrint);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    //UpdateStatus(result.FARAchieved + 1);
                    if (result.Verified)
                    {
                        //MakeReport("The fingerprint was VERIFIED. " + emp.NombreCliente);
                        fingerclieModel = emp;
                        fined = true;
                        break;
                    }
                }
                if (!fined)
                    MessageBox.Show("No se encontro algun cliente , intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    cltModels = fingerclieModel;
                    ModelToFill(true,true);
                }


            }
        }


        


        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            //MakeReport("La muestra ha sido capturada");
            //SetPrompt("Escanea tu misma huella otra vez");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("La huella fue removida del lector");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El lector fue tocado");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El Lector de huellas ha sido conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El Lector de huellas ha sido desconectado");
            MessageBox.Show("El Lector de huellas ha sido desconectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            //if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            //    MakeReport("La calidad de la muestra es BUENA");
            //else
            //    MakeReport("La calidad de la muestra es MALA");
        }
        #endregion

    }

}
