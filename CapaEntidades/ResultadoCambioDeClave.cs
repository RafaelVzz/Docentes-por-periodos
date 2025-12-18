using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResultadoCambioDeClave
    {
        public string Mensaje {  get; set; }
        public bool Exito {  get; set; }
        public bool EsErrorTecnico {  get; set; }
    }
}
