using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache
    {
        public static string IdUser { get; set; }
        public static string UserName { get; set; }
        public static string NombreUsuario { get; set; }
        public static List<string> roles { get; set; }
        public static string puesto { get; set; }
    }
}
