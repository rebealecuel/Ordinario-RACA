using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal class Usuarios
    {
        private static List<Usuarios> usuario = new List<Usuarios>()
        {
            new Usuarios{User = "Rebe", Password = "1111"},
            new Usuarios{User = "Ale", Password = "3333"},
            new Usuarios{User = "Angel", Password = "2469"}
        };

        public List<Usuarios> Getusuarios()
        { 
            return usuario;
        }

        public Usuarios(string user, string password)
        {
            User = user;
            Password = password;
        }

        public Usuarios() { }

        public string User {  get; set; }
        public string Password { get; set; }
    }
}
