using System;
using System.Collections.Generic;
using System.IO;
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

        Correo correo = new Correo();

        public List<Auto> ObtenerAuto()
        {
            try
            {
                return listaautos;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
        public bool Actualizar(int iD, string marca, string modelo, int año, string color, double precio, string estado)
        {
            try
            {
                var objetoeliminar = listaautos.Find(x => x.ID == iD);

                if (objetoeliminar != null)
                {
                    listaautos.Remove(objetoeliminar);
                    listaautos.Add(new Auto(iD, marca, modelo, año, color, precio, estado));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }
        public bool ExportarExcel()
        {
            try
            {
                var rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var rutaArchivo = Path.Combine(rutaEscritorio, "Autos_Exportado.x1xs");

                using (var workbook = new XlWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    worksheet.Cell(1, 1).Value = "Id";
                    worksheet.Cell(1, 2).Value = "Marca";
                    worksheet.Cell(1, 3).Value = "Modelo";
                    worksheet.Cell(1, 4).Value = "Año";
                    worksheet.Cell(1, 5).Value = "Color";
                    worksheet.Cell(1, 6).Value = "Precio";
                    worksheet.Cell(1, 7).Value = "Estado";

                    for (int i = 0; i < listaautos.Count; i++)
                    {
                        var aut = listaautos[i];
                        worksheet.Cell(i + 2, 1).Value = aut.ID;
                        worksheet.Cell(i + 2, 1).Value = aut.Marca;
                        worksheet.Cell(i + 2, 1).Value = aut.Modelo;
                        worksheet.Cell(i + 2, 1).Value = aut.Año;
                        worksheet.Cell(i + 2, 1).Value = aut.Color;
                        worksheet.Cell(i + 2, 1).Value = aut.Precio;
                        worksheet.Cell(i + 2, 1).Value = aut.Estado;
                    }

                    workbook.SaveAs(rutaArchivo);
                }
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }
        public bool Importar()
        {
            try
            {
                var downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                var filePath = Path.Combine(downloadsPath, "Autos_Importados.x1xs");

                if (!File.Exists(filePath))
                {
                    return false;
                }
                using (var workbook = new XlWorkbook())
                {
                    var worksheet = workbook.Worksheets("Sheet1");
                    var rows = worksheet.RowsUsed().Skip(1);

                    foreach (var row in rows)
                    {
                        int id = int.Parse(row.Cell(1).GetValue<string>());
                        string marca = row.Cell(2).GetValue<string>();
                        string modelo = row.Cell(3).GetValue<string>();
                        int año = int.Parse(row.Cell(4).GetValue<string>());
                        string color = row.Cell(5).GetValue<string>();
                        double precio = double.Parse(row.Cell(6).GetValue<string>());
                        string estado = row.Cell(7).GetValue<string>();

                        listaautos.Add(new Auto(id, marca, modelo, año, color, precio, estado));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool Agregar(int iD2, string marca2, string modelo2, int año2, string color2, double precio2, string estado2)
        {
            try
            {
                listaautos.Add(new Auto(iD2, marca2, modelo2, año2, color2, precio2, estado2));
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }
    }
}
