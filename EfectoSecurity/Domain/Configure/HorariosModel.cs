using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configure
{
    public class HorariosModel
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private string _horaEntrada;
        private bool _activo;
        private int _minutosTolerancia;
        private string _idPuesto;
        private Horario _horario;

        public HorariosModel()
        {
            _horario = new Horario();
        }

        public HorariosModel(string id, string horaEntrada, bool activo, int minutosTolerancia, string idPuesto)
        {
            _id = id;
            _horaEntrada = horaEntrada;
            _activo = activo;
            _minutosTolerancia = minutosTolerancia;
            _idPuesto = idPuesto;
        }

        #region ->Validacion de Datos Publicos
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string HoraEntrada
        {
            get { return _horaEntrada; }
            set { _horaEntrada = value; }
        }

        public int MinutosTolerancia
        { 
            get { return _minutosTolerancia; } 
            set { _minutosTolerancia = value; }
        }

        public string IdPuesto
        {
            get { return _idPuesto; }
            set { _idPuesto = value; }  
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        [NotMapped]
        public string DescripcionPuesto { get; set; }

        #endregion

        public IEnumerable<HorariosModel> GetHorarios(string url)
        {
            string s = peticiones.MethodHtt(url + "HorariosUsuarios/GetAllHrUsuarios", null, "GET");
            var results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Horario>>(s);
            return MapModel(results);
        }

        public async Task<int> CreateHorario(string url)
        {
            HorariosModel pl = this;
            return await peticiones.MethodPostBody<HorariosModel>(url, "HorariosUsuarios/InsertHorarioUsuario", pl);
        }

        public async Task<HorariosModel> GetHorarioById(string url, string idPlan)
        {
            HorariosModel us = await peticiones.MethodGet<HorariosModel>(url, "HorariosUsuarios/GetHrUsuariosById/" + idPlan);
            if (us != null)
                return us;
            else
                return null;
        }

        public async Task<int> ModifyHorario(string url)
        {
            HorariosModel us = this;
            return await peticiones.MethodPostBody<HorariosModel>(url, "HorariosUsuarios/UpdateHorarioUsuario", us);
        }

        private HorariosModel MapModel(Horario pt)
        {//Mapear un solo objeto.
            return new HorariosModel()
            {
                Id = pt.Id,
                HoraEntrada=pt.horaEntrada,
                IdPuesto=pt.idPuesto,
                MinutosTolerancia=pt.minutosTolerancia
            };
        }

        private IEnumerable<HorariosModel> MapModel(IEnumerable<Horario> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<HorariosModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }

    }

    public class Horario
    {
        public string Id { get; set; }
        public string horaEntrada { get; set; }
        public int minutosTolerancia { get; set; }
        public string idPuesto { get; set; }
        public bool activo { get; set; }
    }
}
