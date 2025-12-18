using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CapaDatos {
    public class LectorIni 
    {
        private readonly string rutaArchivo; //Config.ini

        public LectorIni(string ruta) 
        {
            rutaArchivo = ruta;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]

        private static extern int GetPrivateProfileString
            (
            string seccion, string clave, string valorPorDefecto,
            StringBuilder retorno , int tamano, string rutaArchivo
            );

        public string LeerValor(string seccion, string clave) 
        {
            var buffer = new StringBuilder(255);

            GetPrivateProfileString(seccion, clave, "", buffer, 255, rutaArchivo);
            return buffer.ToString();
        }
    }
}
