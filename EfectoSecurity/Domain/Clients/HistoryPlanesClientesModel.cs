using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clients
{
    public class HistoryPlanesClientesModel
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _cliente;
        private string _fechaPago;
        private string _fechaVencimiento;
        private string _planCosto;
        private string _registro;
        private string _costo;
        private string _sucursal;
        private HistoryPlan _historyPlan;

        public HistoryPlanesClientesModel()
        {
            _historyPlan = new HistoryPlan();
        }
        public HistoryPlanesClientesModel(string cliente, string fechaPago, string fechaVencimiento,
            string planCosto, string registro, string costo, string sucursal)
        {
            _cliente = cliente;
            _fechaPago = fechaPago;
            _fechaVencimiento = fechaVencimiento;
            _planCosto = planCosto;
            _registro = registro;
            _costo = costo;
            _sucursal = sucursal;
        }

        #region -> Validaciones de Datos Publicos
        public string Cliente { get { return _cliente; } set { _cliente = value; } }
        public string FechaPago { get { return _fechaPago; } set { _fechaPago = value; } }
        public string FechaVencimiento { get { return _fechaVencimiento; } set { _fechaVencimiento = value; } }

        public string PlanCosto { get { return _planCosto; } set { _planCosto = value; } }
        public string Registro { get { return _registro; } set { _registro = value; } }
        public string Costo { get { return _costo; } set { _costo = value; } }
        public string Sucursal { get { return _sucursal; } set { _sucursal = value; } } 

        #endregion

        public IEnumerable<HistoryPlanesClientesModel> GetHisoryByRange(string url, string FInicio, string FFinal
            ,string sucursal )
        {
            string result = peticiones.MethodHtt(url + "Clientes/GetHistorialPlanes/"
                                                                     + FInicio + "/" + FFinal+"/"+sucursal, null);
            var results = JsonConvert.DeserializeObject<List<HistoryPlan>>(result);
            return MapModel(results);
        }

        private HistoryPlanesClientesModel  MapModel(HistoryPlan entity)
        {//Mapear un solo objeto.
            return new HistoryPlanesClientesModel()
            {
                Cliente = entity.cliente,
                FechaPago = entity.fechaPago,
                FechaVencimiento = entity.fechaVencimiento,
                PlanCosto = entity.planCosto,
                Registro = entity.registro,
                Costo = entity.costo,
                Sucursal=entity.sucursal
            };
        }

        private IEnumerable<HistoryPlanesClientesModel> MapModel(IEnumerable<HistoryPlan> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<HistoryPlanesClientesModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }
    }

    public class HistoryPlan
    {
        public string cliente { get; set; }
        public string fechaPago { get; set; }
        public string fechaVencimiento { get; set; }
        public string planCosto { get; set; }
        public string registro { get; set; }
        public string costo { get; set; }
        public string sucursal { get; set; }
    }
}
