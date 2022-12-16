using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User
{
    public class HistoryUserModel
    {
        private PeticionesHttp peticiones = new PeticionesHttp();
        private string _id;
        private string _fechaEntrada;
        private string _fechaSalida;
        private string _idUsuario;
        private string _fechaRegistro;
        private HistoryUser _historyUser;

        public HistoryUserModel()
        {
            _historyUser = new HistoryUser();
        }

        public HistoryUserModel(string id, string fechaEntrada, string fechaSalida, string idUsuario, string fechaRegistro)
        {
            _id = id;
            _fechaEntrada = fechaEntrada;
            _fechaSalida = fechaSalida;
            _idUsuario = idUsuario;
            _fechaRegistro = fechaRegistro;
        }

        #region -> validaciones de Datos Publicos
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }

        public string FechaHoraEntrada { get { return _fechaEntrada; } set { _fechaEntrada= value; } }

        public string FechaRegistro { get { return _fechaRegistro; } set { _fechaRegistro = value; } }

        public string FechaHoraSalida { get { return _fechaSalida; } set { _fechaSalida = value; }}
        #endregion

        public IEnumerable<HistoryUserModel> GetHistorialByIdAndRange(string url, string idUser,string FInicio,string FFinal)
        {
            string result = peticiones.MethodHtt(url + "Usuarios/GetAsistenciasPorUsuarioYRango/"
                                                                    + idUser + "/" + FInicio + "/" + FFinal, null);
            var results = JsonConvert.DeserializeObject<List<HistoryUser>>(result);

            return MapModel(results);
        }


        private HistoryUserModel MapModel(HistoryUser entity)
        {//Mapear un solo objeto.
            return new HistoryUserModel()
            {
                Id = entity.id,
                FechaHoraEntrada=entity.fechaHoraEntrada,
                FechaHoraSalida=entity.fechaHoraSalida,
                FechaRegistro=entity.fechaRegistro,
                IdUsuario=entity.idUsuario
            };
        }

        private IEnumerable<HistoryUserModel> MapModel(IEnumerable<HistoryUser> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<HistoryUserModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }

    }

    public class HistoryUser
    {
        public string id { get; set; }
        public string fechaHoraEntrada { get; set; }
        public string fechaHoraSalida { get; set; }
        public string idUsuario { get; set; }
        public string fechaRegistro { get; set; }
    }

}
