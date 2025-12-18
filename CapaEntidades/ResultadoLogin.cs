using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResultadoLogin
    {
        public bool EsValido {  get; set; }
        public string Mensaje {  get; set; } = string.Empty;
        public string Rol {  get; set; }
        public bool EsErrorTecnico {  get; set; }
    }
}
