using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configure
{
    public class RolesModels
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private string _descripcion;
        private bool _activo;
        private Roles _roles;

        public RolesModels()
        {
            _roles = new Roles();
        }
        public RolesModels(string id, string descripcion, bool activo)
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
        public string DescripcionRol
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


        public IEnumerable<RolesModels> GetRoles(string url)
        {
            string s = peticiones.MethodHtt(url + "Configuracion/GetAllRoles", null, "GET");
            var results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Roles>>(s);
            return MapModel(results);
        }

        public async Task<int> CreateRol(string url)
        {
            RolesModels us = this;
            return await peticiones.MethodPostBody<RolesModels>(url, "Configuracion/InsertRol", us);
        }

        private RolesModels MapModel(Roles pt)
        {//Mapear un solo objeto.
            return new RolesModels()
            {
                Id = pt.id,
                DescripcionRol = pt.descripcionRol,
                Activo = pt.activo
            };
        }

        private IEnumerable<RolesModels> MapModel(IEnumerable<Roles> Entities)
        {//Mapear colección de objetos.
            var userModels = new List<RolesModels>();
            foreach (var user in Entities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }
    }

    public class Roles
    {
        public string id { get; set; }
        public string descripcionRol { get; set; }
        public bool activo { get; set; }
    }
}
