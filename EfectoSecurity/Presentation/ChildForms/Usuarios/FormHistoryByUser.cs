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

namespace Presentation.ChildForms.Usuarios
{
    public partial class FormHistoryByUser : BaseForms.BaseFixedForm
    {

        private HistoryUserModel hstModel = new HistoryUserModel();
        private List<HistoryUserModel> lts;
        private readonly string urlApi = Properties.Settings.Default.ApiEfGym;
        public FormHistoryByUser(string idUser,string FechaI,string FechaF)
        {
            InitializeComponent();
            GetDataHistory(idUser,FechaI,FechaF);
        }

        private  void GetDataHistory(string idUser, string FechaI, string FechaF)
        {
            //lts=  await 
            dataGridView1.DataSource = hstModel.GetHistorialByIdAndRange(urlApi, idUser, FechaI, FechaF);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["FechaRegistro"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
