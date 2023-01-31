using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clients
{
    public class ClientModel
    {
        private string _id;
        private string _nombreCliente;
        private string _numeroCliente;
        private string _numeroTelefono;
        private string _fechaIngreso;
        private string _fechaVencimiento;
        private string _planActual;
        private byte[] _fingerPrint;
        private bool _activo;
        private string _entrenadorActual;
        private string _idUsuario;
        private string _totalPagado;
        private bool _editVigencia;
        private string _sucursal;
        private string _planEntrenador;
        private Cliente _cliente;
        private PeticionesHttp peticiones = new PeticionesHttp();


        public ClientModel()
        {
            _cliente = new Cliente();
        }

        public ClientModel(string id, string nombreCliente, string numeroCliente, string numeroTelefono, string fechaIngreso, string fechaVencimiento, string planActual,
                            byte[] fingerPrint, bool activo, string entrenadorActual, string idUsuario, string totalPagado, string sucursal, string planEntrenador)
        {
            _id = id;
            _nombreCliente = nombreCliente;
            _numeroCliente = numeroCliente;
            _numeroTelefono = numeroTelefono;
            _fechaIngreso = fechaIngreso;
            _fechaVencimiento = fechaVencimiento;
            _planActual = planActual;
            _fingerPrint = fingerPrint;
            _activo = activo;
            _entrenadorActual = entrenadorActual;
            _idUsuario = idUsuario;
            _totalPagado = totalPagado;
            _sucursal = sucursal;
            _planEntrenador = planEntrenador;
        }

        #region -> Validaciones de metodos Publicos

        public string Id {get { return _id; } set { _id = value; } }

        [Required(ErrorMessage = "Por favor ingrese Nombre del Cliente.")]
        public string NombreCliente { get { return _nombreCliente; } set { _nombreCliente = value; } }
        public string NumeroCliente { get { return _numeroCliente; } set { _numeroCliente = value; } }
        public string NumeroTelefono { get { return _numeroTelefono; } set { _numeroTelefono = value; } }
        public string FechaIngreso { get { return _fechaIngreso; } set { _fechaIngreso = value; } }
        public string FechaVencimiento { get { return _fechaVencimiento; } set { _fechaVencimiento = value; } }
        
        [Required(ErrorMessage = "Por favor ingrese plan Pagado.")]
        public string PlanActual { get { return _planActual; } set { _planActual = value; } }
        public byte[] FingerPrint { get { return _fingerPrint; } set { _fingerPrint = value; } }
        public bool Activo { get { return _activo; } set { _activo = value; } }
        public string EntrenadorActual { get { return _entrenadorActual; } set { _entrenadorActual = value; } }
        public string IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public string TotalPagado { get { return _totalPagado; } set { _totalPagado = value; } }
        public bool EditVigencia { get { return _editVigencia; } set { _editVigencia = value; } }
        public string Sucursal { get { return _sucursal; } set { _sucursal = value; } }
        public string PlanEntrenador { get { return _planEntrenador; } set { _planEntrenador = value; } }
        #endregion


        public async Task<int> CreateClient(string url)
        {
            ClientModel us = this;
            return await peticiones.MethodPostBody<ClientModel>(url, "Clientes/InsertNewClient", us);
        }

        public async Task<int> ModifyClient(string url)
        {
            ClientModel us = this;
            return await peticiones.MethodPostBody<ClientModel>(url, "Clientes/UpdateClient", us);
        }

        public async void CheckIn(string Url,string cliente,string iUsuario)
        {
            await peticiones.MethodGet<object>(Url, "Clientes/RegisterCheckIn/"+cliente+"/"+iUsuario);
        }

        public async Task<object> CleanClients(string url)
        {
           return await peticiones.MethodGet<object>(url, "Clientes/CleanClient");

        }

        public IEnumerable<ClientModel> GetAllClients(string Url)
        {
            string result = peticiones.MethodHtt(Url + "Clientes/GetAllClientes", null);

            var results = JsonConvert.DeserializeObject<List<Cliente>>(result);
            
            return MapModel(results);
        }

        public async Task<ClientModel> GetClientByNum(string url, string idNumber)
        {
            ClientModel us = await peticiones.MethodGet<ClientModel>(url, "Clientes/SearchByClientNumber/" + idNumber);
            if (us != null)
                return us;
            else
                return null;
        }

        public async Task<ClientModel> GetClientByName(string url,string name)
        {
            ClientModel us = await peticiones.MethodGet<ClientModel>(url, "Clientes/SearchByName/" + name);
            if (us != null)
                return us;
            else
                return null;
        }

        private ClientModel MapModel(Cliente entity)
        {//Mapear un solo objeto.
            return new ClientModel()
            {
                Id = entity.id,
                Activo = entity.activo,
                EntrenadorActual = entity.entrenadorActual,
                FechaIngreso = entity.fechaIngreso,
                FechaVencimiento = entity.fechaVencimiento,
                FingerPrint = entity.fingerPrint,
                IdUsuario = entity.idUsuario,
                NombreCliente = entity.nombreCliente,
                NumeroCliente = entity.numeroCliente,
                PlanActual = entity.planActual,
                TotalPagado = entity.totalPagado,
                NumeroTelefono = entity.numeroTelefono,
                Sucursal = entity.sucursal,
                PlanEntrenador = entity.planEntrenador
            };
        }

        private IEnumerable<ClientModel> MapModel(IEnumerable<Cliente> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<ClientModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapModel(user));
            }
            return userModels;
        }
    }

    public class Cliente
    {
        public string id { get; set; }
        public string nombreCliente { get; set; }
        public string numeroCliente { get; set; }
        public string numeroTelefono { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaVencimiento { get; set; }
        public string planActual { get; set; }
        public byte[] fingerPrint { get; set; }
        public bool activo { get; set; }
        public string entrenadorActual { get; set; }
        public string idUsuario { get; set; }
        public string totalPagado { get; set; }
        public string sucursal { get; set; }
        public string planEntrenador { get; set; }
    }
}
