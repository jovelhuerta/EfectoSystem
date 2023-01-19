using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configure
{
    public class SucursalModel
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private string _sucursal;
        private string _tipo;
        private bool _activo;
        private SucursalM _sucursalm;

        public SucursalModel()
        {
            _sucursalm =new SucursalM();
        }

        public SucursalModel(string id, string sucursal,string tipo,bool activo)
        {
            _id = id;
            _sucursal =sucursal;
            _tipo = tipo;
            _activo =activo;
        }
        #region ->Validacion de Datos Publicos
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Sucursal
        {
            get { return _sucursal; }
            set { _sucursal=value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set{ _tipo = value;}
        }
        public bool Activo
        {
            get { return _activo; }
            set{ _activo = value;}
        }
        #endregion

        public async Task<int> CreateSucursal(string url)
        {
            SucursalModel mod = this;
            return await peticiones.MethodPostBody<SucursalModel>
                (url, "Sucursales/InsertSucursal", mod);
        }

        public IEnumerable<SucursalModel> GetAllSucursal(string url)
        {
            string s = peticiones.MethodHtt(url + "Sucursales/GetAllSucursales", null, "GET");
            var results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SucursalM>>(s);
            return MapModel(results);
        }

        private SucursalModel MapModel(SucursalM data)
        {
            return new SucursalModel()
            {
                Id = data.Id,
                Sucursal=data.Sucursal,
                Tipo=data.Tipo,
                Activo=data.Activo
            };
        }

        private IEnumerable<SucursalModel>MapModel(IEnumerable<SucursalM> userEntities)
        {
            var userModels = new List<SucursalModel>();
            foreach (var userEntity in userEntities)
                userModels.Add(MapModel(userEntity));
            return userModels;
        }
    }

    public class SucursalM
    {
        public string Id { get; set; }
        public string Sucursal { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
    }
}
