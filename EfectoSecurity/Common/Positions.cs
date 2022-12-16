using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Positions
    {
        /// <summary>
        /// Esta estructura almacena los cargos del usuario, escencial para
        /// realizar las condiciones de los permisos de usuario (Para el ejemplo del proyecto).
        /// De igual manera esto es opcional, en su lugar puedes usar
        /// una tabla de cargos en la base de datos, puedes hacerlo
        /// mediante enumeraciones y el ID de los cargos.
        /// </summary>

        public const string GeneralManager = "GERENTE GENERAL";
        public const string AdministrativeAssistant = "Administrative assistant";
        public const string SystemAdministrator = "ADMINISTRADOR DE SISTEMA";
        public const string Recepcionist = "RECEPCION";
        public const string Couch = "ENTRENADOR";

    }
}
