using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configure
{
    public class PlanesModel
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private int _costo;
        private string _descripcion;
        private int _vigencia;
        private int _tipoVigencia;
        private bool _activo;
        private Planes _planes;

        public PlanesModel()
        {
            _planes = new Planes();
        }
        public PlanesModel(string id, int costo, string descripcion, int vigencia, int tipoVigencia, bool activo)
        {
            _id = id;
            _costo = costo;
            _descripcion = descripcion;
            _vigencia = vigencia;
            _tipoVigencia = tipoVigencia;
            _activo = activo;

        }


        #region  -> Validacion de Metodos Publicos
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Required(ErrorMessage = "Por favor ingrese Descripcion del Plan.")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        [Required(ErrorMessage = "Por favor ingrese Vigencia del Plan.")]
        public int Vigencia
        {
            get { return _vigencia; }
            set { _vigencia = value; }
        }
        [Required(ErrorMessage = "Por favor ingrese Tipo de Vigencia del Plan.")]
        public int TipoVigencia
        {
            get { return _tipoVigencia; }
            set { _tipoVigencia = value; }
        }
        [NotMapped]
        public string DescripcionVigencia { get; set; }
        [Required(ErrorMessage = "Por favor ingrese Costo del Plan.")]
        public int Costo
        {
            get { return _costo; }
            set {_costo = value;}
        }


        #endregion

        #region ->Metodos publicos y privados de funcionalidad

        /// <summary>
        /// Metodo que obtiene todos los planes
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public IEnumerable<PlanesModel> GetPlanes(string url)
        {
            string s = peticiones.MethodHtt(url + "Planes/GetAllPlanes", null, "GET");
            var results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Planes>>(s);
            return MapModel(results);
        }

        /// <summary>
        /// Metodo que Crea un nuevo Plan
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> CreatePlan(string url)
        {
            PlanesModel pl = this;
            return await peticiones.MethodPostBody<PlanesModel>(url, "Planes/InsertNewPlan", pl);
        }

        /// <summary>
        /// Metodo que Modifica un plan
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> ModifyPlan(string url)
        {
            PlanesModel us = this;
            return await peticiones.MethodPostBody<PlanesModel>(url, "Planes/UpdatePlan", us);
        }

        public async Task<PlanesModel> GetPlanById(string url, string idPlan)
        {
            PlanesModel us = await peticiones.MethodGet<PlanesModel>(url, "Planes/GetPlanById/" + idPlan);
            if (us != null)
                return us;
            else
                return null;
        }

        private PlanesModel MapModel(Planes pt)
        {//Mapear un solo objeto.
            return new PlanesModel()
            {
                Id = pt.Id,
                Descripcion = pt.Descripcion,
                Activo = pt.Activo,
                Vigencia=pt.Vigencia,
                Costo=pt.Costo,
                TipoVigencia = pt.TipoVigencia
            };
        }

        private IEnumerable<PlanesModel> MapModel(IEnumerable<Planes> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<PlanesModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }

        #endregion
    }

    public class Planes
    {
        public string Id { get; set; }
        public int Costo { get; set; }
        public string Descripcion { get; set; }
        public int Vigencia { get; set; }
        public int TipoVigencia { get; set; }
        public bool Activo { get; set; }
        
    }
}
