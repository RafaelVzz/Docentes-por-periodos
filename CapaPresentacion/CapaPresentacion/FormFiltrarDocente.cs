using CapaLogica;
using CapaPresentacion.FuncionesFormulario;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class FormFiltrarDocente : Form {
        public FormFiltrarDocente() {
            InitializeComponent();
            Utilidades.PersonalizarDataGridView(dgvDataFiltrada);
        }

        ClaseLogica logica = new ClaseLogica();


        private void btnExportarAExcel_Click(object sender, EventArgs e) {
            if (Validaciones.DataGridLimpio(dgvDataFiltrada))
            {
                MessageBox.Show("Debe elegir los filtros a aplicar y ver la tabla para poder exportarla a Excel", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Workbook|*.xlsx";
            saveFile.Title = "Guardar archivo de Excel";
            saveFile.FileName = "FiltradoDocentes.xlsx";

            if (saveFile.ShowDialog() != DialogResult.OK) return;

            string nombreFiltro = Path.GetFileNameWithoutExtension(saveFile.FileName);
            string ruta = saveFile.FileName;

            var wb = new XLWorkbook();
            var dt = (DataTable)dgvDataFiltrada.DataSource;
            wb.Worksheets.Add(dt, "Filtrados");
            wb.SaveAs(ruta);

            logica.GuardarDocentesFiltrados(dt, nombreFiltro);

            MessageBox.Show("Exportación realizada exitosamente", "Filtrar y exportar docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e) {
            if (Validaciones.DataGridLimpio(dgvDataFiltrada))
            {
                Utilidades.LimpiarCampos(txbCedula, txbDocente, cbCondicion, cbCategoriaDocente, cbClasificacion, cbSeccion, cbPrograma, cbNucleo, txbAsignatura, mtxbCantidad, mtxbHoras);
            }
            else
            {
                dgvDataFiltrada.Columns.Clear();
                Utilidades.LimpiarCampos(txbCedula, txbDocente, cbCondicion, cbCategoriaDocente, cbClasificacion, cbSeccion, cbPrograma, cbNucleo, txbAsignatura, mtxbCantidad, mtxbHoras);
            }
        }

        private async void FormFiltrarDocente_Load(object sender, EventArgs e) {
            try
            {
                cbElegirPeriodo.DataSource = await logica.ObtenerPeriodosConPlaceHolder();
                cbElegirPeriodo.DisplayMember = "Periodo";
                cbElegirPeriodo.ValueMember = "Periodo";
                cbElegirPeriodo.SelectedIndex = 0;

                cbPrograma.DataSource = await logica.ObtenerProgramas();
                cbPrograma.SelectedIndex = -1;

                cbCondicion.DataSource = await logica.ObtenerCondiciones();
                cbCondicion.SelectedIndex = -1;

                cbCategoriaDocente.DataSource = await logica.ObtenerCategorias();
                cbCategoriaDocente.SelectedIndex = -1;

                cbNucleo.DataSource = await logica.ObtenerNucleos();
                cbNucleo.SelectedIndex = -1;

                cbSeccion.DataSource = await logica.ObtenerSecciones();
                cbSeccion.SelectedIndex = -1;

                cbClasificacion.DataSource = await logica.ObtenerClasificacion();
                cbClasificacion.SelectedIndex = -1;
            }
            catch (SqlException ex) 
            {
                MessageBox.Show($"Error al consultar la data desde la base de datos, si el error persiste, contacte al administrador. \n\n Error técnico: {ex.Message}", "Filtrar docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnElegirPeriodo_Click(object sender, EventArgs e) {
            bool esValido = Validaciones.HayFiltros(txbCedula, txbDocente, cbCondicion, cbCategoriaDocente, cbClasificacion, cbSeccion, cbPrograma, cbNucleo, txbAsignatura, mtxbCantidad, mtxbHoras);

            if (!esValido && !(rbtnTeoria.Checked || rbtnPractica.Checked || rbtnLab.Checked))
            {
                MessageBox.Show("Debe seleccionar al menos un campo para filtrar", "Filtrado de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (cbElegirPeriodo.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un período.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {

                string periodo = cbElegirPeriodo.SelectedValue.ToString();
                Dictionary<string, object> filtros = new Dictionary<string, object>();

                if (!string.IsNullOrWhiteSpace(txbCedula.Text))
                    filtros["cedula"] = txbCedula.Text;

                if (!string.IsNullOrWhiteSpace(txbDocente.Text))
                    filtros["docente"] = txbDocente.Text;

                if (cbClasificacion.SelectedIndex != -1)
                    filtros["clasificacion"] = cbClasificacion.SelectedItem.ToString();

                if (cbCondicion.SelectedIndex != -1)
                    filtros["condicion"] = cbCondicion.SelectedItem.ToString();

                if (cbCategoriaDocente.SelectedIndex != -1)
                    filtros["categoria_docente"] = cbCategoriaDocente.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(txbAsignatura.Text))
                    filtros["asignatura"] = txbAsignatura.Text;

                if (cbSeccion.SelectedIndex != -1)
                    filtros["seccion"] = cbSeccion.SelectedItem.ToString();

                // RadioButtons: filtra por tipo de horas (> 0)
                if (rbtnTeoria.Checked)
                    filtros["horas_teoricas"] = true;
                else if (rbtnPractica.Checked)
                    filtros["horas_practicas"] = true;
                else if (rbtnLab.Checked)
                    filtros["horas_laboratorio"] = true;


                if (cbPrograma.SelectedIndex != -1)
                    filtros["programa"] = cbPrograma.SelectedItem.ToString();

                if (cbNucleo.SelectedIndex != -1)
                    filtros["nucleo"] = cbNucleo.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(mtxbCantidad.Text))
                    filtros["cantidad"] = mtxbCantidad.Text;

                if (!string.IsNullOrWhiteSpace(mtxbHoras.Text))
                    filtros["cantidad_horas_academicas"] = mtxbHoras.Text;

                if (filtros.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de filtrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var docentesEncontrados = await logica.ObtenerDocentesFiltradosAsync(filtros, periodo);

                dgvDataFiltrada.DataSource = docentesEncontrados;

                if (dgvDataFiltrada.Columns.Contains("IdDocentePorPeriodo"))
                {
                    dgvDataFiltrada.Columns["IdDocentePorPeriodo"].Visible = false;
                }

                if (Validaciones.DataGridLimpio(dgvDataFiltrada))
                {
                    etqRespuesta.Text = "No se encontraron docentes con los filtros especificados";
                    etqRespuesta.ForeColor = System.Drawing.Color.Black;
                    etqRespuesta.Visible = true;
                    dgvDataFiltrada.Columns.Clear();
                }
                else
                {
                    etqRespuesta.Text = "Docentes encontrados:";
                    etqRespuesta.ForeColor = System.Drawing.Color.Black;
                    etqRespuesta.Visible = true;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Ocurrió un error filtrar la data, si el error persiste, contacte al administrador \n\n Error técnico: {ex.Message} " , "Filtrar docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbCedula_TextChanged(object sender, EventArgs e) {
            string cadena = @"^\d{0,8}$";

            Regex regex = new Regex(cadena);

            if (!regex.IsMatch(txbCedula.Text) && txbCedula.Text.Length > 0)
            {
                txbCedula.Text = txbCedula.Text.Substring(0, txbCedula.Text.Length - 1);
                txbCedula.SelectionStart = txbCedula.Text.Length;
            }
        }
    }
}
