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
        private PlanesEntrenadorModel plEntrenador = new PlanesEntrenadorModel();
        private List<PlanesModel> ltsPlanes;
        private List<PlanesEntrenadorModel> ltsPlanesEn;
        public int vigencia;
        public int TipoVigencia;
        public int costo;
        public bool singlePlan;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;

        public FormSelectPlan(bool isSinglePlan)
        {
            InitializeComponent();
            singlePlan = isSinglePlan;
            ltsPlanes = plModel.GetPlanes(urlApi).ToList();
            ltsPlanesEn = plEntrenador.GetPlanes(urlApi).ToList();
            if(isSinglePlan)
                cmbPlan.DataSource = ltsPlanes;
            else
                cmbPlan.DataSource = ltsPlanesEn;
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
                if (singlePlan)
                {
                    padre.txtPago.Text = "" + costo;
                    padre.txtPlanActual.Text = cmbPlan.Text;
                    padre.txtVencimiento.Text = vigen.ToString();
                }
                else
                {
                    padre.txtPagoEnt.Text = "" + costo;
                    padre.txtPlanEnt.Text = cmbPlan.Text;
                    padre.txtVencEntr.Text = vigen.ToString();
                }
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = "";
            if (cmbPlan.SelectedIndex != -1)
            {
                temp = (string)cmbPlan.Text;
            }
            if (!String.IsNullOrEmpty(temp) && !temp.Contains("Domain.Configure"))//.PlanesModel")
            {
                if(singlePlan)
                    costo= ltsPlanes.Where(a => a.Descripcion == temp).FirstOrDefault().Costo;
                else
                    costo = ltsPlanesEn.Where(a => a.Descripcion == temp).FirstOrDefault().Costo;
                txtCosto.Text = "$ " + costo;
                if (singlePlan)
                    vigencia = ltsPlanes.Where(a => a.Descripcion == temp).FirstOrDefault().Vigencia;
                else
                    vigencia = ltsPlanesEn.Where(a => a.Descripcion == temp).FirstOrDefault().Vigencia;
                if (singlePlan)
                    TipoVigencia = ltsPlanes.Where(a => a.Descripcion == temp).FirstOrDefault().TipoVigencia;
                else
                    TipoVigencia = ltsPlanesEn.Where(a => a.Descripcion == temp).FirstOrDefault().TipoVigencia;
                string tipo = TipoVigencia == 0 && vigencia == 1 ? "DIA" : TipoVigencia == 0 && vigencia > 1 ? "DIAS" :
                            TipoVigencia == 1 && vigencia == 1 ? "MES" : "MESES";
                txtVigencia.Text = "" + vigencia + " " + tipo;
            }

        }
    }
}
