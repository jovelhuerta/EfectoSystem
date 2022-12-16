using Domain.Configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ChildForms.Clientes
{
    public partial class FormSelectPlan : BaseForms.BaseFixedForm
    {
        private PlanesModel plModel = new PlanesModel();
        private List<PlanesModel> ltsPlanes;
        public int vigencia;
        public int TipoVigencia;
        public int costo;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;

        public FormSelectPlan()
        {
            InitializeComponent();
            ltsPlanes = plModel.GetPlanes(urlApi).ToList();
            cmbPlan.DataSource = ltsPlanes;
            cmbPlan.DisplayMember = "Descripcion";
            cmbPlan.ValueMember = "Descripcion";
            cmbPlan.SelectedIndex = -1;//Sin seleccion de indice.
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Favor de Seleccionar un Plan, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbPlan.SelectedIndex >= 0)
            {
                FormClienteMaintenance padre = Owner as FormClienteMaintenance;
                DateTime vigen = DateTime.Now;
                if(TipoVigencia==0)//Por DIA
                    vigen=DateTime.Now.AddDays(vigencia);
                else//POR MES
                    vigen = DateTime.Now.AddMonths(vigencia);
                padre.txtPago.Text = ""+costo;
                padre.txtPlanActual.Text = cmbPlan.Text;
                padre.txtVencimiento.Text=vigen.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = "";
            if (cmbPlan.SelectedIndex != -1)
                temp = (string)cmbPlan.Text;
            if (!String.IsNullOrEmpty(temp) &&temp != "Domain.Configure.PlanesModel")
            {
                costo= ltsPlanes.Where(a => a.Descripcion == temp).FirstOrDefault().Costo;
                txtCosto.Text = "$ " + costo;
                vigencia = ltsPlanes.Where(a => a.Descripcion == temp).FirstOrDefault().Vigencia;
                TipoVigencia = ltsPlanes.Where(a => a.Descripcion == temp).FirstOrDefault().TipoVigencia;
                string tipo = TipoVigencia == 0 && vigencia == 1 ? "DIA" : TipoVigencia == 0 && vigencia > 1 ? "DIAS" :
                            TipoVigencia == 1 && vigencia == 1 ? "MES" : "MESES";
                txtVigencia.Text = "" + vigencia + " " + tipo;
            }

        }
    }
}
