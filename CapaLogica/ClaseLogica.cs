using CapaDatos;
using CapaEntidades;
using DocumentFormat.OpenXml.Office2010.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica {
    public class ClaseLogica 
    {
        private Data data = new Data(); 

        public async Task<ResultadoLogin> ValidarLoginAsync(string usuario, string clave)
        {
            return await data.ValidarLoginAsync(usuario, clave);
        }

        public async Task<ResultadoCambioDeClave> CambiarClaveAsync(string usuario, int pin, string clave)
        {
            return await data.CambiarClaveAsync(usuario, pin, clave);
        }

        public async Task<RegistroDeImportaciones> ImportarDataAExcelAsync(DataTable dt, string periodo) {
            return await data.InsertarDocentesDeExcelAsync(dt, periodo);
        }
        public DataTable ObtenerDataPorPeriodo(string periodo) {
            return data.ObtenerDataPorPeriodo(periodo);
        }
        public async Task<List<string>> ObtenerPeriodosUnicos() {
            return await data.ObtenerPeriodosUnicos();
        }

        public async Task<List<string>> ObtenerProgramas() {
            return await data.ObtenerProgramas();
        }

        public async Task<List<string>> ObtenerCondiciones() {
            return await data.ObtenerCondiciones();
        }

        public async Task<List<string>> ObtenerCategorias() {
            return await data.ObtenerCategorias();
        }

        public async Task<List<string>> ObtenerNucleos() {
            return await data.ObtenerNucleos();
        }

        public async Task<List<string>> ObtenerSecciones() {
            return await data.ObtenerSecciones();
        }

        public async Task<List<string>> ObtenerClasificacion() {
            return await data.ObtenerClasificacion();
        }

        public async Task<DataTable> ObtenerPeriodosConPlaceHolder() {
            return await data.ObtenerPeriodosConPlaceholder();
        }

        public DataTable ObtenerDocentesFiltrados(Dictionary<string, object> filtros, string periodo) {
            return data.FiltrarDocentes(filtros, periodo);
        }

        public async Task<DataTable> ObtenerDocentesFiltradosAsync(Dictionary<string, object> filtros, string periodo)
        {
            return await data.FiltrarDocentesAsync(filtros, periodo);
        }

        public void GuardarDocentesFiltrados(DataTable tabla, string nombreFiltro) {
            foreach (DataRow row in tabla.Rows)
            {
                data.InsertarDocenteFiltrado(row, nombreFiltro);
            }
        }
        public DataTable ObtenerFiltrado(string nombreFiltro) {
            return data.ObtenerFiltrado(nombreFiltro);
        }

        public async Task<List<string>> ObtenerFiltrosGuardados() {
            return await data.ObtenerFiltrosGuardados();
        }

        public List<string> ObtenerCamposModificables(string periodo) {
            return data.ObtenerNombresDeColumnas(periodo);
        }

        public async Task<DataTable> ObtenerFilasDeDocentes(string cedula, string periodo) {
            return await data.ObtenerFilasPorCedulaYPeriodo(cedula, periodo);
        }

        public bool ModificarCamposDocentePorId(int idDocente, Dictionary<string, string> camposModificados) {
            return data.ModificarCamposDocentePorId(idDocente, camposModificados);
        }

        public async Task<RegistroDeImportaciones> SinRegistrosDeImportacionesAsync() {
            return await data.SinRegistrosDeImportacionesAsync();
        }

        public async Task<RegistroDeExportaciones> SinRegistrosDeFiltrosAsync() {
            return await data.SinRegistrosDeFiltrosAsync();
        }
    }
}
