using Domain.Clients;
using Presentation.BaseForms;
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
    public partial class FormVerify : FingerPrintForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private ClientModel cltModel;
        private List<ClientModel> ltsClientes;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormVerify()
        {
            cltModel = new ClientModel();
            ltsClientes = cltModel.GetAllClients(urlApi).ToList();
            InitializeComponent();
        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR),false, FAR);
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;
                bool fined = false;
                foreach (var emp in ltsClientes.Where(a=>a.FingerPrint!=null).ToList())
                {
                    stream = new MemoryStream(emp.FingerPrint);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved+1);
                    if (result.Verified)
                    {
                        MakeReport("The fingerprint was VERIFIED. " + emp.NombreCliente);
                        cltModel = emp;
                        fined = true;
                        break;
                    }
                }
                if(!fined)
                    MessageBox.Show("No se encontro algun cliente , intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Cliente: "+cltModel.NombreCliente, "Cliente Encontrado", MessageBoxButtons.YesNo);
                    FormCheckInClient padre = Owner as FormCheckInClient;
                    
                    if (dialogResult == DialogResult.Yes)
                    {
                        padre.cltModels = cltModel;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        padre.cltModels = null;
                    }
                    
                }


            }
        }
    }
}
