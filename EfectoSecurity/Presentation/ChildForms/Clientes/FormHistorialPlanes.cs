using Domain.Clients;
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
    public partial class FormHistorialPlanes : Form
    {
        private HistoryPlanesClientesModel history = new HistoryPlanesClientesModel();
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        private SucursalModel sucursalModel = new SucursalModel();
        private List<SucursalModel> ltsSucursal;
        public FormHistorialPlanes()
        {
            InitializeComponent();
            ltsSucursal = sucursalModel.GetAllSucursal(urlApi).ToList();
            SucursalModel temp = new SucursalModel();
            temp.Sucursal = "TODAS";
            temp.Activo = true;
            temp.Tipo = "Todo";
            ltsSucursal.Add(temp);
            cmbSucursales.DataSource = ltsSucursal;
            cmbSucursales.DisplayMember = "Sucursal";
            cmbSucursales.ValueMember = "Sucursal";
            cmbSucursales.SelectedIndex = ltsSucursal.Count - 1;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<HistoryPlanesClientesModel> lts = history.GetHisoryByRange(urlApi, "" + DateTime.Parse(FechaInicio.Text).Ticks,
                                                                "" + DateTime.Parse(Fechafinal.Text).Ticks, cmbSucursales.Text).ToList();
            double sum = 0;
            foreach (HistoryPlanesClientesModel tem in lts)
            {
                sum += double.Parse(tem.Costo);
            }
            lblTotal.Text = "$" + sum.ToString();
            dataGridView1.DataSource = lts;
            //dataGridView1.DataSource = history.GetHisoryByRange(urlApi, "" + DateTime.Parse(FechaInicio.Text).Ticks,
            //                                                    "" + DateTime.Parse(Fechafinal.Text).Ticks);
            dataGridView1.Columns["Costo"].Visible = false;
        }
    }
}
