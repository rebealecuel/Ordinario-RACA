using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal class Acciones : IAcciones
    {
        private List<Auto> listaautos = new List<Auto>()
        {
            new Auto (1,"Chebrolet","Onix",2020,"negro",100000,"Disponible")
        };
        public List<Auto> ObtenerAuto()
        {
            try 
            {
                return listaautos;
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
