using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuarios
    {
        public int IdUsuario {  get; private set; }
        public string NombreDeUsuario { get; set; }
        public string Clave {  get; set; }
        public int PinUnico {  get; set; }
        public string Rol {  get; set; }
        public string Mensaje {  get; set; }
    }
}
