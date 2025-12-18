using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace CapaDatos {
    internal class Conexion 
    {
        //string cadena = "Server=WILMERHP\\MSSQLSERVER2,1433;Database=AplicacionLenguaje1;User Id=loginRafael;Password=w4210;";
        private readonly string cadenaConexion;

        public Conexion() 
        {
            string rutaIni = AppDomain.CurrentDomain.BaseDirectory + "Config.ini";

            if (!File.Exists(rutaIni))
                throw new FileNotFoundException("El archivo Config.ini no fue encontrado");

            var lector = new LectorIni(rutaIni);
            string servidor = lector.LeerValor("Conexion", "Servidor");
            string baseDatos = lector.LeerValor("Conexion", "BaseDatos");
            string usuario = lector.LeerValor("Conexion", "Usuario");
            string clave = lector.LeerValor("Conexion", "Clave");

            cadenaConexion = $"Data Source={servidor};Initial Catalog={baseDatos};User Id={usuario};Password={clave};";
        }

        public SqlConnection ConexionBD() {
            return new SqlConnection(cadenaConexion);
        }
    }
}
