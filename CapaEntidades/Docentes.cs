using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Docentes 
    {
        public string Cedula { get; set; }
        public string Docente { get; set; }
        public string Clasificacion {  get; set; }
        public string Condicion {  get; set; }
        public string CategoriaDocente {  get; set; }
        public string Asignatura {  get; set; }
        public string Seccion {  get; set; }
        public int HorasTeoricas {  get; set; }
        public int HorasPracticas {  get; set; }
        public int HorasLaboratorio {  get; set; }
        public int CantidadHorasAcademicas {  get; set; }
        public string Programa {  get; set; }
        public string Nucleo {  get; set; }
        public int Cantidad {  get; set; }

        public string Mensaje {  get; set; }
    }
}
