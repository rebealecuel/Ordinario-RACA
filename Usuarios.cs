using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal class Usuarios
    {
        List<Usuarios> usuarios = new List<Usuarios>()
        {
            new Usuarios ("Rebe", "111")
        };

        public List<Usuarios> Getusuarios()
        { 
            try
            {
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuarios(string user, string password)
        {
            User = user;
            Password = password;
        }

        public string User {  get; set; }
        public string Password { get; set; }
    }
}
