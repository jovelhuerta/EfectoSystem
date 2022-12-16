using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Web.Script.Serialization;
using System.Net.Http.Headers;
using Common.Cache;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Domain.User
{
    public class UserModel
    {
       
        private string _id;
        private string _userName;
        private string _nombreUsuario;
        private string _numeroTelefono;
        private List<string> _roles;
        private bool _entrada;
        private string _puesto;
        private string _contraseña;
        private byte[] _fingerPrint;
        private UserMongo _user;

        public UserModel()
        {
            _user = new UserMongo();
        }
        private PeticionesHttp peticiones = new PeticionesHttp();
        public UserModel(string id, string userName, string nombreUsuario, string numeroTelefono, List<string> roles, 
            bool entrada, string puesto,string contraseña, byte[] finger)
        {
            _id = id;
            _userName = userName;
            _nombreUsuario = nombreUsuario;
            _numeroTelefono = numeroTelefono;
            _roles = roles;
            _entrada = entrada;
            _puesto = puesto;
            _contraseña = contraseña;
            _fingerPrint = finger;
        }
      
        #region ->Validacion de Datos Publicos
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required(ErrorMessage = "Por favor ingrese usuario.")]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        [Required(ErrorMessage = "Por favor ingrese Nombre del Usuario.")]
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        public string NumeroTelefono
        {
            get { return _numeroTelefono; }
            set { _numeroTelefono = value; }
        }
        //[Required(ErrorMessage = "Por favor seleccion un rol.")]
        public List<string> Roles
        {
            get { return _roles; }
            set { _roles = value; }
        }
        public bool Entrada
        {
            get { return _entrada; }
            set { _entrada = value; }
        }
        [Required(ErrorMessage = "Por favor seleccion un puesto.")]
        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }
        [Required(ErrorMessage = "Por favor ingrese contraseña.")]
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        public byte[] FingerPrint
        {
            get { return _fingerPrint; }
            set { _fingerPrint = value; }

        }
        #endregion


        /// <summary>
        /// Metodo que Realiza el logeo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="urlApi"></param>
        /// <returns></returns>
        public async Task<UserModel> Login(string username, string password, string urlApi)
        {
            var values = new Dictionary<string, string> { { "codUser", username }, { "pass", password } };
            _user = await peticiones.MethodPostForm<UserMongo>(urlApi, "Usuarios/LoginToUser", values);
            if (_user != null)
            {
                UserCache.roles = _user.roles;
                UserCache.IdUser = _user.id;
                UserCache.NombreUsuario = _user.nombreUsuario;
                UserCache.puesto = _user.puesto;
                UserCache.UserName = _user.userName;
                return MapUserModel(_user);
            }
            else
                return null;
        }

        /// <summary>
        /// Metodo para Crear un nuevo Usuario
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> CreateUser(string url)
        {
            UserModel us = this;
            return await peticiones.MethodPostBody<UserModel>(url, "Usuarios/InsertNewUser", us);
        }

        /// <summary>
        /// Metodo para modificar usuarios
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> ModifyUser(string url)
        {
            UserModel us = this;
            return await peticiones.MethodPostBody<UserModel>(url, "Usuarios/UpdateUser", us); 
        }

        /// <summary>
        /// Metodo que pone de baja a los Usuarios
        /// </summary>
        /// <param name="url"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public async Task<int> RemoveUser(string url,string idUser)
        {
            var values = new Dictionary<string, string> { { "idUser", idUser } };
            ResponseData res = await peticiones.MethodPostForm<ResponseData>(url, "Usuarios/SetBajaToUser", values);
            if (res != null)
                return 1;
            else
                return -1;
        }

        public async Task<UserModel> GetUserById(string url,string idUser)
        {
            UserModel us= await peticiones.MethodGet<UserModel>(url, "Usuarios/GetUserById/" + idUser);
            if (us != null)
                return us;
            else
                return null;
        }

        /// <summary>
        /// Metodo que Obtiene a todos los Usuarios
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public IEnumerable<UserModel> GetAllUsers(string Url)
        {
            string result = peticiones.MethodHtt(Url + "Usuarios/GetAllUsersActivate", null);

            var results = JsonConvert.DeserializeObject<List<UserMongo>>(result);
            
            return MapUserModel(results);
        }

        /// <summary>
        /// Metodo para mapear Datos y Piner los datos en Cache
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        private UserModel MapUserModel(UserMongo userEntity)
        {//Mapear un solo objeto.
            return new UserModel()
            {
                Id = userEntity.id,
                UserName = userEntity.userName,
                NombreUsuario = userEntity.nombreUsuario,
                NumeroTelefono = userEntity.numeroTelefono,
                Roles = userEntity.roles,
                Entrada = userEntity.entrada,
                Puesto = userEntity.puesto
            };
        }

        private IEnumerable<UserModel> MapUserModel(IEnumerable<UserMongo> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<UserModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapUserModel(user));
            }
            return userModels;
        }

    }

    public class UserMongo
    {
        public string id { get; set; }
        public string userName { get; set; }
        public string nombreUsuario { get; set; }
        public string numeroTelefono { get; set; }
        public List<string> roles { get; set; }
        public bool entrada { get; set; }
        public string puesto { get; set; }
    }

    public class ResponseData
    {
        public string message { get; set; }
        public bool success { get; set; }
    }
}


