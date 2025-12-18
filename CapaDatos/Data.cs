using CapaEntidades;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class Data {

        private readonly Conexion conexion = new Conexion();

        public async Task<ResultadoLogin> ValidarLoginAsync(string usuario, string clave)
        {
            var resultado = new ResultadoLogin();

            using (SqlConnection conn = conexion.ConexionBD())
            {
                try
                {
                    await conn.OpenAsync();
                    string query = "SELECT * FROM Usuarios WHERE nombreUsuario = @usuario AND clave = @clave";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        object respuesta = await cmd.ExecuteScalarAsync();

                        if (respuesta != null)
                        {
                            resultado.EsErrorTecnico = false;
                            resultado.EsValido = true;
                            resultado.Mensaje = "Credenciales válidas";
                        }
                        else
                        {
                            resultado.EsErrorTecnico = false;
                            resultado.EsValido = false;
                            resultado.Mensaje = "Credenciales inválidas";
                        }
                    }
                }
                catch (Exception ex) 
                {
                    resultado.EsValido = false;
                    resultado.EsErrorTecnico = true;
                    resultado.Mensaje = ex.Message;
                }
                return resultado;
            }
        }

        public bool CambiarClave(string usuario, int pin, string clave) {
            using (SqlConnection conn = conexion.ConexionBD())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Usuarios SET clave = @clave WHERE nombreUsuario = @nombreUsuario AND pinUnico = @pinUnico";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@pinUnico", pin);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public async Task<ResultadoCambioDeClave> CambiarClaveAsync(string usuario, int pin, string clave)
        {
            var resultado = new ResultadoCambioDeClave();

            using (SqlConnection conn = conexion.ConexionBD())
            {
                try
                {
                    await conn.OpenAsync();

                    string query = "UPDATE Usuarios SET clave = @clave WHERE nombreUsuario = @nombreUsuario AND pinUnico = @pinUnico";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreUsuario", usuario);
                        cmd.Parameters.AddWithValue("@pinUnico", pin);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();

                        if (filasAfectadas > 0)
                        {
                            resultado.Exito = true;
                            resultado.EsErrorTecnico = false;
                            resultado.Mensaje = "Cambio de contraseña exitoso";
                        }
                        else
                        {
                            resultado.Exito = false;
                            resultado.EsErrorTecnico = false;
                            resultado.Mensaje = "Cambio de contraseña fallido, verifique su nombre de usuario y pin";
                        }
                    }
                }
                catch(Exception ex)
                {
                    resultado.Exito= false;
                    resultado.EsErrorTecnico = true;
                    resultado.Mensaje = ex.Message;
                }
            }
            return resultado;
        }

        private int TryParseEntero(object valor) {
            if (valor == null || valor == DBNull.Value)
                return 0;

            int resultado;
            return int.TryParse(valor.ToString(), out resultado) ? resultado : 0;
        }

        public bool InsertarDocentesDeExcel(DataTable dt, string periodo) {
            int filasAfectadas = 0;

            using (SqlConnection conn = conexion.ConexionBD())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        

                        foreach (DataRow fila in dt.Rows)
                        {
                            string cedula = fila["cedula"].ToString();
                            string docente = fila["docente"].ToString();
                            string clasificacion = fila["clasificacion"].ToString();
                            string condicion = fila["condicion"].ToString();
                            string categoriaDocente = fila["categoria_docente"].ToString();
                            string asignatura = fila["asignatura"].ToString();
                            string seccion = fila["seccion"].ToString();
                            int horasTeoricas = TryParseEntero(fila["horas_teoricas"]);
                            int horasPracticas = TryParseEntero(fila["horas_practicas"]);
                            int horasLaboratorio = TryParseEntero(fila["horas_laboratorio"]);
                            int cantidadHorasAcademicas = TryParseEntero(fila["cantidad_horas_academicas"]);
                            string programa = fila["programa"].ToString();
                            string nucleo = fila["nucleo"].ToString();
                            int cantidad = TryParseEntero(fila["cantidad"]);


                            string query = "INSERT INTO dataDocentes (cedula, docente, clasificacion, condicion, categoria_docente, asignatura, seccion, horas_teoricas, horas_practicas, horas_laboratorio, cantidad_horas_academicas, programa, nucleo, cantidad, periodo)" +
                                "VALUES (@cedula, @docente, @clasificacion, @condicion, @categoria_docente, @asignatura, @seccion, @horas_teoricas, @horas_practicas, @horas_laboratorio, @cantidad_horas_academicas, @programa, @nucleo, @cantidad, @periodo)";

                            SqlCommand cmd = new SqlCommand(query, conn, trans);

                            cmd.Parameters.AddWithValue("@cedula", cedula);
                            cmd.Parameters.AddWithValue("@docente", docente);
                            cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                            cmd.Parameters.AddWithValue("@condicion", condicion);
                            cmd.Parameters.AddWithValue("@categoria_docente", categoriaDocente);
                            cmd.Parameters.AddWithValue("@asignatura", asignatura);
                            cmd.Parameters.AddWithValue("@seccion", seccion);
                            cmd.Parameters.AddWithValue("@horas_teoricas", horasTeoricas);
                            cmd.Parameters.AddWithValue("@horas_practicas", horasPracticas);
                            cmd.Parameters.AddWithValue("@horas_laboratorio", horasLaboratorio);
                            cmd.Parameters.AddWithValue("@cantidad_horas_academicas", cantidadHorasAcademicas);
                            cmd.Parameters.AddWithValue("@programa", programa);
                            cmd.Parameters.AddWithValue("@nucleo", nucleo);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@periodo", periodo);

                            filasAfectadas += cmd.ExecuteNonQuery();
                            
                        }
                        trans.Commit();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception(ex.Message);

                    }
                }

            }
        }

        public async Task<RegistroDeImportaciones> InsertarDocentesDeExcelAsync(DataTable dt, string periodo)
        {
            var docentes = new RegistroDeImportaciones();
            int filasAfectadas = 0;

            using (SqlConnection conn = conexion.ConexionBD())
            {
                await conn.OpenAsync();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (DataRow fila in dt.Rows)
                        {
                            string cedula = fila["cedula"].ToString();
                            string docente = fila["docente"].ToString();
                            string clasificacion = fila["clasificacion"].ToString();
                            string condicion = fila["condicion"].ToString();
                            string categoriaDocente = fila["categoria_docente"].ToString();
                            string asignatura = fila["asignatura"].ToString();
                            string seccion = fila["seccion"].ToString();
                            int horasTeoricas = TryParseEntero(fila["horas_teoricas"]);
                            int horasPracticas = TryParseEntero(fila["horas_practicas"]);
                            int horasLaboratorio = TryParseEntero(fila["horas_laboratorio"]);
                            int cantidadHorasAcademicas = TryParseEntero(fila["cantidad_horas_academicas"]);
                            string programa = fila["programa"].ToString();
                            string nucleo = fila["nucleo"].ToString();
                            int cantidad = TryParseEntero(fila["cantidad"]);


                            string query = "INSERT INTO dataDocentes (cedula, docente, clasificacion, condicion, categoria_docente, asignatura, seccion, horas_teoricas, horas_practicas, horas_laboratorio, cantidad_horas_academicas, programa, nucleo, cantidad, periodo)" +
                                "VALUES (@cedula, @docente, @clasificacion, @condicion, @categoria_docente, @asignatura, @seccion, @horas_teoricas, @horas_practicas, @horas_laboratorio, @cantidad_horas_academicas, @programa, @nucleo, @cantidad, @periodo)";

                            SqlCommand cmd = new SqlCommand(query, conn, trans);

                            cmd.Parameters.AddWithValue("@cedula", cedula);
                            cmd.Parameters.AddWithValue("@docente", docente);
                            cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                            cmd.Parameters.AddWithValue("@condicion", condicion);
                            cmd.Parameters.AddWithValue("@categoria_docente", categoriaDocente);
                            cmd.Parameters.AddWithValue("@asignatura", asignatura);
                            cmd.Parameters.AddWithValue("@seccion", seccion);
                            cmd.Parameters.AddWithValue("@horas_teoricas", horasTeoricas);
                            cmd.Parameters.AddWithValue("@horas_practicas", horasPracticas);
                            cmd.Parameters.AddWithValue("@horas_laboratorio", horasLaboratorio);
                            cmd.Parameters.AddWithValue("@cantidad_horas_academicas", cantidadHorasAcademicas);
                            cmd.Parameters.AddWithValue("@programa", programa);
                            cmd.Parameters.AddWithValue("@nucleo", nucleo);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@periodo", periodo);

                            filasAfectadas += await cmd.ExecuteNonQueryAsync();

                        }
                        trans.Commit();

                        if (filasAfectadas > 0)
                        {
                            docentes.HayImportaciones = true;
                            docentes.Mensaje = "Data importada correctamente";
                            docentes.EsErrorTecnico = false;
                        }
                        else
                        {
                            docentes.HayImportaciones = false;
                            docentes.Mensaje = "No se pudo importar la data.";
                            docentes.EsErrorTecnico = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        docentes.HayImportaciones = false;
                        docentes.Mensaje = ex.Message;
                        docentes.EsErrorTecnico = true;

                    }
                }
                return docentes;
            }
        }

        public DataTable ObtenerDataPorPeriodo(string periodo) {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ConexionBD())
            {
                conn.Open();
                string query = "SELECT * FROM dataDocentes WHERE Periodo = @periodo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@periodo", periodo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;

        }

        public async Task<List<string>> ObtenerPeriodosUnicos() {
            List<string> lista = new List<string>();
            using (SqlConnection conn = conexion.ConexionBD())
            {
                await conn.OpenAsync();
                string query = "SELECT DISTINCT Periodo FROM dataDocentes ORDER BY Periodo DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
                {
                    lista.Add(reader["Periodo"].ToString());
                }
            }
            return lista;
        }

        
        public async Task<List<string>> ObtenerProgramas() {
            return await ObtenerValoresUnicos("programa");
        }

       
        public async Task<List<string>> ObtenerCondiciones() {
            return await ObtenerValoresUnicos("condicion");
        }

        
        public async Task<List<string>> ObtenerCategorias() {
            return await ObtenerValoresUnicos("categoria_docente");
        }

       
        public async Task<List<string>> ObtenerNucleos() {
            return await ObtenerValoresUnicos("nucleo");
        }

        public async Task<List<string>> ObtenerSecciones() {
            return await ObtenerValoresUnicos("seccion");
        }

        public async Task<List<string>> ObtenerClasificacion() {
            return await ObtenerValoresUnicos("clasificacion");
        }

        public async Task<DataTable> ObtenerPeriodosConPlaceholder() {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("periodo");

            tabla.Rows.Add("Seleccione el período para comenzar a filtrar");

            using (SqlConnection conn = conexion.ConexionBD())
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT periodo FROM dataDocentes ORDER BY Periodo DESC", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (await reader.ReadAsync())
                {
                    tabla.Rows.Add(reader.GetString(0));
                }
            }
            return tabla;
        }
        private async Task<List<string>> ObtenerValoresUnicos(string nombreColumna) {
            List<string> lista = new List<string>();
            using (SqlConnection conn = conexion.ConexionBD())
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand($"SELECT DISTINCT {nombreColumna} FROM dataDocentes WHERE {nombreColumna} IS NOT NULL AND {nombreColumna} <> ''", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (await dr.ReadAsync())
                {
                    lista.Add(dr.GetString(0));
                }
            }
            return lista;
        }

        public DataTable FiltrarDocentes(Dictionary<string, object> filtros, string periodo) {
            using (SqlConnection conn = conexion.ConexionBD())
            {
                conn.Open();

                string query = "SELECT * FROM dataDocentes WHERE periodo = @Periodo";

                foreach (var filtro in filtros)
                {
                    string columna = filtro.Key;

                    if (columna == "horas_teoricas" || columna == "horas_practicas" || columna == "horas_laboratorio")
                    {
                        query += $" AND {columna} > 0";
                    }
                    else
                    {
                        query += $" AND {columna} = @{columna}";
                    }
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Periodo", periodo);

                foreach (var filtro in filtros)
                {
                    string columna = filtro.Key;

                    if (columna != "horas_teoricas" && columna != "horas_practicas" && columna != "horas_laboratorio")
                    {
                        cmd.Parameters.AddWithValue("@" + columna, filtro.Value);
                    }
                }
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public async Task<DataTable> FiltrarDocentesAsync(Dictionary<string, object> filtros, string periodo)
        {
            DataTable dt = new DataTable();
            var listaDocentes = new List<Docentes>();

            using (SqlConnection conn = conexion.ConexionBD())
            {
                try
                {
                    await conn.OpenAsync();

                    string query = "SELECT * FROM dataDocentes WHERE periodo = @Periodo";

                    foreach (var filtro in filtros)
                    {
                        string columna = filtro.Key;

                        if (columna == "horas_teoricas" || columna == "horas_practicas" || columna == "horas_laboratorio")
                        {
                            query += $" AND {columna} > 0";
                        }
                        else
                        {
                            query += $" AND {columna} = @{columna}";
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Periodo", periodo);

                        foreach (var filtro in filtros)
                        {
                            string columna = filtro.Key;

                            if (columna != "horas_teoricas" && columna != "horas_practicas" && columna != "horas_laboratorio")
                            {
                                cmd.Parameters.AddWithValue("@" + columna, filtro.Value);
                            }
                        }
                        await cmd.ExecuteScalarAsync();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        //var docente = new Docentes()
                        //{
                        //    Cedula = dt.Rows[0].ToString(),
                        //    Docente = dt.Columns[1].ToString(),
                        //    Clasificacion = dt.Columns[2].ToString(),
                        //    Condicion = dt.Columns[3].ToString(),
                        //    CategoriaDocente = dt.Columns[4].ToString(),
                        //    Asignatura = dt.Columns[5].ToString(),
                        //    Seccion = dt.Columns[6].ToString(),
                        //    HorasTeoricas = int.TryParse(dt.Columns[7].ToString(), out int ht) ? ht : 0,
                        //    HorasPracticas = int.TryParse(dt.Columns[8].ToString(), out int hp) ? hp : 0,
                        //    HorasLaboratorio = int.TryParse(dt.Columns[9].ToString(), out int hl) ? hl : 0,
                        //    CantidadHorasAcademicas = int.TryParse(dt.Columns[10].ToString(), out int cha) ? cha : 0,
                        //    Programa = dt.Columns[11].ToString(),
                        //    Nucleo = dt.Columns[12].ToString(),
                        //    Cantidad = int.TryParse(dt.Columns[13].ToString(), out int c) ? c : 0
                        //};

                        //listaDocentes.Add(docente);

                        //if (busqueda != null)
                        //{
                        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //    da.Fill(dt);
                        //}
                        //else
                        //{
                        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //    da.Fill(dt);
                        //}
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dt;
            }
        }

        public void InsertarDocenteFiltrado(DataRow row, string nombreFiltro) {
            using (SqlConnection conn = conexion.ConexionBD())
            {
                conn.Open();
                string query = @"INSERT INTO docentesFiltrados
                            (cedula, docente, clasificacion, condicion, categoria_docente, asignatura, seccion,
                             horas_teoricas, horas_practicas, horas_laboratorio, cantidad_horas_academicas,
                             programa, nucleo, cantidad, periodo, nombreFiltro)
                             VALUES
                            (@cedula, @docente, @clasificacion, @condicion, @categoria_docente, @asignatura, @seccion,
                             @horas_teoricas, @horas_practicas, @horas_laboratorio, @cantidad_horas_academicas,
                             @programa, @nucleo, @cantidad, @periodo, @nombreFiltro)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cedula", row["cedula"]);
                cmd.Parameters.AddWithValue("@docente", row["docente"]);
                cmd.Parameters.AddWithValue("@clasificacion", row["clasificacion"]);
                cmd.Parameters.AddWithValue("@condicion", row["condicion"]);
                cmd.Parameters.AddWithValue("@categoria_docente", row["categoria_docente"]);
                cmd.Parameters.AddWithValue("@asignatura", row["asignatura"]);
                cmd.Parameters.AddWithValue("@seccion", row["seccion"]);
                cmd.Parameters.AddWithValue("@horas_teoricas", row["horas_teoricas"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@horas_practicas", row["horas_practicas"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@horas_laboratorio", row["horas_laboratorio"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@cantidad_horas_academicas", row["cantidad_horas_academicas"]);
                cmd.Parameters.AddWithValue("@programa", row["programa"]);
                cmd.Parameters.AddWithValue("@nucleo", row["nucleo"]);
                cmd.Parameters.AddWithValue("@cantidad", row["cantidad"]);
                cmd.Parameters.AddWithValue("@periodo", row["periodo"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@nombreFiltro", nombreFiltro);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerFiltrado(string nombreFiltro) {
            using (SqlConnection conn = conexion.ConexionBD())
            {
                string query = "SELECT * FROM docentesFiltrados WHERE nombreFiltro = @NombreFiltro";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreFiltro", nombreFiltro);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public async Task<List<string>> ObtenerFiltrosGuardados() {
            List<string> lista = new List<string>();
            using (SqlConnection conn = conexion.ConexionBD())
            {
                await conn.OpenAsync();
                string query = "SELECT DISTINCT NombreFiltro FROM docentesFiltrados ORDER BY nombreFiltro DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                while (reader.Read())
                {
                    lista.Add(reader["NombreFiltro"].ToString());
                }
            }
            return lista;
        }

        public List<string> ObtenerNombresDeColumnas(string periodo) {
            List<string> columnas = new List<string>();

            using (SqlConnection conn = conexion.ConexionBD())
            {
                conn.Open();
                string query = "SELECT TOP 1 * FROM dataDocentes WHERE periodo = @Periodo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Periodo", periodo);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();

                foreach (DataRow row in schemaTable.Rows)
                {
                    string columnName = row["ColumnName"].ToString();
                    if (columnName != "periodo")
                    {
                        columnas.Add(columnName);
                    }
                }
            }
            return columnas;
        }
        public async Task<DataTable> ObtenerFilasPorCedulaYPeriodo(string cedula, string periodo) {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ConexionBD())
            {
                await conn.OpenAsync();
                string query = "SELECT * FROM dataDocentes WHERE cedula = @cedula AND periodo = @periodo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Periodo", periodo);

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    tabla.Load(reader);
                }
            }
            return tabla;
        }

        public bool ModificarCamposDocentePorId(int idDocente, Dictionary<string, string> camposModificados) {
            if (camposModificados.Count == 0)
                return false;

            using (SqlConnection conn = conexion.ConexionBD())
            {
                conn.Open();

                List<string> asignaciones = new List<string>();
                SqlCommand cmd = new SqlCommand();

                foreach (var campo in camposModificados)
                {
                    string parametro = $"@{campo.Key.Replace(" ", "")}";
                    asignaciones.Add($"{campo.Key} = {parametro}");
                    cmd.Parameters.AddWithValue(parametro, campo.Value);
                }

                string setClause = string.Join(", ", asignaciones);
                string query = $"UPDATE dataDocentes SET {setClause} WHERE IdDocentePorPeriodo = @Id";

                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Id", idDocente);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public async Task<RegistroDeImportaciones> SinRegistrosDeImportacionesAsync()
        {
            var import = new RegistroDeImportaciones();

            using (SqlConnection conn = conexion.ConexionBD())
            {
                try
                {
                    await conn.OpenAsync();
                    string query = "SELECT COUNT(*) FROM dataDocentes";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    int cuenta = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    if (cuenta > 0)
                    {
                        import.EsErrorTecnico = false;
                        import.HayImportaciones = true;
                    }
                    else
                    {
                        import.EsErrorTecnico = false;
                        import.HayImportaciones = false;
                        import.Mensaje = "Aún no se han realizado importaciones.";
                    }
                }
                catch (Exception ex)
                {
                    import.EsErrorTecnico = true;
                    import.HayImportaciones = false;
                    import.Mensaje = ex.Message;
                }
            }
            return import;
        }


        public async Task<RegistroDeExportaciones> SinRegistrosDeFiltrosAsync()
        {
            var export = new RegistroDeExportaciones();

            using (SqlConnection conn = conexion.ConexionBD())
            {
                try
                {
                    await conn.OpenAsync();
                    string query = "SELECT COUNT(*) FROM docentesFiltrados";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    int cuenta = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    if (cuenta > 0)
                    {
                        export.EsErrorTecnico = false;
                        export.HayExportaciones = true;
                    }
                    else
                    {
                        export.EsErrorTecnico = false;
                        export.HayExportaciones = false;
                        export.Mensaje = "Aún no se han realizado exportaciones.";
                    }
                }
                catch (Exception ex)
                {
                    export.EsErrorTecnico = true;
                    export.HayExportaciones = false;
                    export.Mensaje = ex.Message;
                }
            }
            return export;
        }
    }
}
