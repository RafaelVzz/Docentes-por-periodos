using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class RegistroDeExportaciones
    {
        public bool HayExportaciones { get; set; }
        public string Mensaje { get; set; }
        public bool EsErrorTecnico { get; set; }
    }
}
