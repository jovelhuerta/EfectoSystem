using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configure
{
    public class PlanesEntrenadorModel
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private int _costo;
        private string _descripcion;
        private int _vigencia;
        private int _tipoVigencia;
        private bool _activo;
        private PlanesEntrenador _planes;

        public PlanesEntrenadorModel()
        {
            _planes = new PlanesEntrenador();
        }
        public PlanesEntrenadorModel(string id, int costo, string descripcion, int vigencia, int tipoVigencia, bool activo)
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
            set { _costo = value; }
        }


        #endregion

        #region ->Metodos publicos y privados de funcionalidad

        /// <summary>
        /// Metodo que obtiene todos los planes
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public IEnumerable<PlanesEntrenadorModel> GetPlanes(string url)
        {
            string s = peticiones.MethodHtt(url + "PlanesEntrenador/GetAllPlanes", null, "GET");
            var results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PlanesEntrenador>>(s);
            return MapModel(results);
        }

        /// <summary>
        /// Metodo que Crea un nuevo Plan
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> CreatePlan(string url)
        {
            PlanesEntrenadorModel pl = this;
            return await peticiones.MethodPostBody<PlanesEntrenadorModel>(url, "PlanesEntrenador/InsertNewPlan", pl);
        }

        /// <summary>
        /// Metodo que Modifica un plan
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> ModifyPlan(string url)
        {
            PlanesEntrenadorModel us = this;
            return await peticiones.MethodPostBody<PlanesEntrenadorModel>(url, "PlanesEntrenador/UpdatePlan", us);
        }

        /// <summary>
        /// Metodo que obtiene la informacion del plan por el Id
        /// </summary>
        /// <param name="url"></param>
        /// <param name="idPlan"></param>
        /// <returns></returns>
        public async Task<PlanesEntrenadorModel> GetPlanById(string url, string idPlan)
        {
            PlanesEntrenadorModel us = await peticiones.MethodGet<PlanesEntrenadorModel>(url, "PlanesEntrenador/GetPlanById/" + idPlan);
            if (us != null)
                return us;
            else
                return null;
        }

        /// <summary>
        /// Metodo para eliminar plan por Id
        /// </summary>
        /// <param name="url"></param>
        /// <param name="idPlan"></param>
        /// <returns></returns>
        public async Task<object> DeletePlan(string url, string idPlan)
        {
            return await peticiones.MethodGet<object>(url, "PlanesEntrenador/DeletePlan/" + idPlan);
        }

        private PlanesEntrenadorModel MapModel(PlanesEntrenador pt)
        {//Mapear un solo objeto.
            return new PlanesEntrenadorModel()
            {
                Id = pt.Id,
                Descripcion = pt.Descripcion,
                Activo = pt.Activo,
                Vigencia = pt.Vigencia,
                Costo = pt.Costo,
                TipoVigencia = pt.TipoVigencia
            };
        }

        private IEnumerable<PlanesEntrenadorModel> MapModel(IEnumerable<PlanesEntrenador> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<PlanesEntrenadorModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }

        #endregion
    }

    public class PlanesEntrenador
    {
        public string Id { get; set; }
        public int Costo { get; set; }
        public string Descripcion { get; set; }
        public int Vigencia { get; set; }
        public int TipoVigencia { get; set; }
        public bool Activo { get; set; }

    }

}
