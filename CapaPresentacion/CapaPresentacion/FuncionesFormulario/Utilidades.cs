using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using ClosedXML.Excel;

namespace CapaPresentacion.FuncionesFormulario {
    internal static class Utilidades 
    {
        internal static void VisibilidadClave(CheckBox VerClave, MaterialSingleLineTextField clave) {
            clave.UseSystemPasswordChar = !VerClave.Checked;
        }

        public static void AlternarVisibilidadClave(MaterialSingleLineTextField textBox, PictureBox pbVerClave, PictureBox pbOcultarClave) {
            bool Visibilidad = !textBox.UseSystemPasswordChar;
            textBox.UseSystemPasswordChar = Visibilidad;
            pbVerClave.Visible = !Visibilidad;
            pbOcultarClave.Visible = Visibilidad;
        }

        public static void MostrarPanelDesplegable(Button btnDesplegar, Panel panelDesplegable) {
            if (!panelDesplegable.Visible)
            {
                panelDesplegable.Visible = true;
            }
            else
            {
                panelDesplegable.Visible = false;
            }
        }
        public static void CerrarVentana(Form form) {
            form.Close();
        }
        public static void MinimizarVentana(Form form) {
            form.WindowState = FormWindowState.Minimized;
        }
        public static void VentanaNormal(Form form) {
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        public static DataTable LeerExcel(string ruta) {

            DataTable dt = new DataTable();

            using (var libro = new XLWorkbook(ruta))
            {
                var hoja = libro.Worksheets.First();

                var filaEncabezados = hoja.Row(1);
                int totalColumnas = filaEncabezados.LastCellUsed().Address.ColumnNumber;

                for (int i = 1; i <= totalColumnas; i++)
                {
                    string nombreColumna = filaEncabezados.Cell(i).GetValue<string>().Trim();
                    if (string.IsNullOrWhiteSpace(nombreColumna))
                        nombreColumna = $"Columna_{i}";
                    if (dt.Columns.Contains(nombreColumna))
                        nombreColumna += $"_{i}";
                    dt.Columns.Add(nombreColumna);
                }

                int ultimaFila = hoja.LastRowUsed().RowNumber();
                for (int f = 2; f <= ultimaFila; f++)
                {
                    var fila = hoja.Row(f);
                    var nuevaFila = dt.NewRow();

                    for (int c = 1; c <= totalColumnas; c++)
                    {
                        nuevaFila[c - 1] = fila.Cell(c).GetValue<string>().Trim();
                    }

                    dt.Rows.Add(nuevaFila);
                }
            }

            return dt;

        }

        public static void PersonalizarDataGridView(DataGridView dgv) {

            dgv.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            dgv.DefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Mostrar los bordes internos de celdas (tipo Excel)
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Black;

            // Opcional para visual más limpia
            dgv.RowTemplate.Height = 25;
            dgv.AllowUserToResizeRows = false;

            // Autoajuste de columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 229, 255);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(153, 204, 255);
        }

        //public static void CargarArchivoExcel(OpenFileDialog ofd, string rutaArchivoExcel, DataGridView dgv) {
        //    ofd.Filter = "Archivos Excel |*.xlsx;*.xls";
        //    ofd.Title = "Seleccionar archivo Excel";

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        rutaArchivoExcel = ofd.FileName;
        //        DataTable dt = LeerExcel(rutaArchivoExcel);
        //        dgv.AutoGenerateColumns = true;
        //        dgv.DataSource = dt;
        //    }
        //}

        public static void AbrilFormularioEnPanel(Form formHijo, Form formularioActivo, Panel pnlContenedor) {
            if (formularioActivo != null) // hay un formulario activo
            {
                formularioActivo.Close();
                formularioActivo.Dispose(); // bd / ejecucion de sentencias que esten atadas a la sesion actual
            }

            formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.Show();
        }

        public static void LimpiarCampos(TextBox txbCedula, TextBox txbDocente, ComboBox cbCondicion, ComboBox cbCategoria, ComboBox cbClasificacion, ComboBox cbSeccion, ComboBox cbPrograma, ComboBox cbNucleo, TextBox txbAsignatura, MaskedTextBox txbCantidad, MaskedTextBox txbHoras)
        {
            txbCedula.Text = string.Empty;
            txbDocente.Text = string.Empty;
            cbCondicion.Text = string.Empty;
            cbCategoria.Text = string.Empty;
            cbClasificacion.Text = string.Empty;
            cbSeccion.Text = string.Empty; 
            cbPrograma.Text = string.Empty;
            cbNucleo.Text = string.Empty;
            txbAsignatura.Text = string.Empty;
            txbCantidad.Text = string.Empty;
            txbHoras.Text = string.Empty;
        }
    }
}
