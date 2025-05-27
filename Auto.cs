using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal class Auto : Vehiculo
    {
        public Auto(int iD, string marca, string modelo, int año, string color,double precio, string estado)
        :base (iD, marca, modelo, año, color)
        {
            Precio = precio;
            Estado = estado;
        }

        

        public double Precio {  get; set; }
        public string Estado { get; set; }
    }
}
