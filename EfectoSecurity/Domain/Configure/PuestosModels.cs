using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configure
{
    public class PuestosModels
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private string _descripcion;
        private bool _activo;
        private Puestos _puestos;

        public PuestosModels()
        {
            _puestos = new Puestos();
        }

        public PuestosModels(string id, string descripcion, bool activo)
        {
            _id = id;
            _descripcion = descripcion;
            _activo = activo;
        }

        #region ->Validacion de Datos Publicos
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string DescripcionPuesto
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        #endregion

        public IEnumerable<PuestosModels> GetPuestos(string url)
        {
            string s = peticiones.MethodHtt(url+ "Configuracion/GetAllPuestos", null, "GET");
            var results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Puestos>>(s);
            return MapModel(results);
        }

        public async Task<int> CreatePuesto(string url)
        {
            PuestosModels us = this;
            return await peticiones.MethodPostBody<PuestosModels>(url, "Configuracion/InsertPuesto", us);
        }

        private PuestosModels MapModel(Puestos pt)
        {//Mapear un solo objeto.
            return new PuestosModels()
            {
                Id = pt.id,
                DescripcionPuesto = pt.descripcionPuesto,
                Activo= pt.activo
            };
        }

        private IEnumerable<PuestosModels> MapModel(IEnumerable<Puestos> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<PuestosModels>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }
    }

    public class Puestos
    {
        public string id { get; set; }
        public string descripcionPuesto { get; set; }
        public bool activo { get; set; }
    }
}
