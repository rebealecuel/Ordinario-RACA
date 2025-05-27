using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal interface IAcciones
    {
        List<Auto> ObtenerAuto();
        bool Agregar(int iD2, string marca2, string modelo2, int año2, string color2, double precio2, string estado2);
        bool Actualizar(int iD, string marca, string modelo, int año, string color, double precio, string estado);

        bool Eliminar(int iD);

        bool ExportarExcel();

        bool Impotar();
    }
}
