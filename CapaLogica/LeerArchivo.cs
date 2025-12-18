using CapaEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace CapaLogica {
    public static class LeerArchivo 
    {
        public static async Task<List<Docentes>> CargarArchivoDesdeExcel(string ruta)
        {
            return await Task.Run(() =>
            {
                var lista = new List<Docentes>();

                if (!File.Exists(ruta))
                    throw new FileNotFoundException("No se encontró el archivo Excel");

                using (var libro = new XLWorkbook(ruta))
                {
                    var hoja = libro.Worksheet(1);

                    foreach (var fila in hoja.RangeUsed().RowsUsed().Skip(1))
                    {
                        var docente = new Docentes
                        {
                            Cedula = fila.Cell(1).GetString(),
                            Docente = fila.Cell(2).GetString(),
                            Clasificacion = fila.Cell(3).GetString(),
                            Condicion = fila.Cell(4).GetString(),
                            CategoriaDocente = fila.Cell(5).GetString(),
                            Asignatura = fila.Cell(6).GetString(),
                            Seccion = fila.Cell(7).GetString(),
                            HorasTeoricas = int.TryParse(fila.Cell(8).GetString().Trim(), out int ht) ? ht : 0,
                            HorasPracticas = int.TryParse(fila.Cell(9).GetString().Trim(), out int hp) ? hp : 0,
                            HorasLaboratorio = int.TryParse(fila.Cell(10).GetString().Trim(), out int hl) ? hl : 0,
                            CantidadHorasAcademicas = int.TryParse(fila.Cell(11).GetString().Trim(), out int cha) ? cha : 0,
                            Programa = fila.Cell(12).GetString(),
                            Nucleo = fila.Cell(13).GetString(),
                            Cantidad = int.TryParse(fila.Cell(14).GetString().Trim(), out int c) ? c : 0
                        };
                        lista.Add(docente);
                    }
                }
                return lista;
            });
        }
    }
}
