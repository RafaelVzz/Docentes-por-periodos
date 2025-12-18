using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class FormImportarData : Form {
        public FormImportarData() {
            InitializeComponent();
            FuncionesFormulario.Utilidades.PersonalizarDataGridView(dgvData);
        }

        ClaseLogica logica = new ClaseLogica();
        private List<Docentes> dataDocentes = new List<Docentes>();

        public string rutaArchivoExcel = string.Empty;


        private async void btnCargarArchivo_Click(object sender, EventArgs e) 
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos Excel |*.xls;*.xlsx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoExcel = ofd.FileName;
                    etqRespuesta.Text = "Cargando archivo Excel...";
                    etqRespuesta.ForeColor = System.Drawing.Color.Black;
                    etqRespuesta.Visible = true;
                    btnCargarArchivo.Enabled = false;
                    btnImportarData.Enabled = false;

                    try
                    {
                        dataDocentes = await LeerArchivo.CargarArchivoDesdeExcel(rutaArchivoExcel);
                        dgvData.DataSource = dataDocentes;

                        etqRespuesta.Text = "Archivo cargado exitosamente";
                        etqRespuesta.ForeColor = System.Drawing.Color.Green;
                        btnImportarData.Enabled = true;
                    }
                    catch(ArgumentException ae)
                    {
                        etqRespuesta.Visible = false;
                        MessageBox.Show("Error al cargar el achivo, verifique que sea de extensión .xlsx o .xls versión 2007 o superior. \n\n Error técnico: " + ae.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (FileFormatException fe)
                    {
                        MessageBox.Show("Error al cargar el achivo, verifique que sea de extensión .xlsx o .xls versión 2007 o superior. \n\n Error técnico: " + fe.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        btnCargarArchivo.Enabled = true;
                    }
                }
            }    
        }

        private async void btnImportarData_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(rutaArchivoExcel))
            {
                MessageBox.Show("Primero debe cargar un archivo para importarlo.", "Importar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados para importar.", "Importar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string periodo = txbPeriodo.Text.Trim();
            if (string.IsNullOrWhiteSpace(periodo))
            {
                MessageBox.Show("Ingrese el periodo académico.", "Periodo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                DataTable dt = FuncionesFormulario.Utilidades.LeerExcel(rutaArchivoExcel);
                var resultado = await logica.ImportarDataAExcelAsync(dt, periodo);

                if (resultado.HayImportaciones)
                {
                etqRespuesta.Text = resultado.Mensaje;
                etqRespuesta.ForeColor = System.Drawing.Color.Black;
                dgvData.DataSource = null;
                etqRespuesta.Visible = true;
                txbPeriodo.Text = string.Empty;
                }
                else if(!resultado.HayImportaciones && !resultado.EsErrorTecnico)
                {
                etqRespuesta.Visible = true;
                etqRespuesta.Text = resultado.Mensaje;
                etqRespuesta.ForeColor = System.Drawing.Color.Black;
                }
            else
            {
                MessageBox.Show($"Ha ocurrido un error al tratar de importar la data, si el error persiste, contacte al administrador \n\n Error técnico: {resultado.Mensaje}", "Importar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void txbPeriodo_TextChanged(object sender, EventArgs e) {
            string formatoPermitido = @"^I{0,2}(?:-\d{0,4})?$";
            Regex regex = new Regex(formatoPermitido);

            if (!regex.IsMatch(txbPeriodo.Text) && txbPeriodo.Text.Length > 0)
            {
                txbPeriodo.Text = txbPeriodo.Text.Substring(0, txbPeriodo.Text.Length - 1);
                txbPeriodo.SelectionStart = txbPeriodo.Text.Length;
            }
        }
    }
}
