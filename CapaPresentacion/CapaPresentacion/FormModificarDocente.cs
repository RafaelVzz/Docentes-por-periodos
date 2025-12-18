using CapaLogica;
using CapaPresentacion.FuncionesFormulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class FormModificarDocente : Form {
        public FormModificarDocente() {
            InitializeComponent();
            clbCamposModificables.ItemCheck += clbCamposModificables_ItemCheck;
            Utilidades.PersonalizarDataGridView(dgvResultados);
        }

        ClaseLogica logica = new ClaseLogica();
        private Dictionary<string, Control> controlsModificables = new Dictionary<string, Control>();

        private async void FormModificarDocente_Load(object sender, EventArgs e) {
            try
            {

                cbPeriodo.DataSource = await logica.ObtenerPeriodosConPlaceHolder();
                cbPeriodo.DisplayMember = "Periodo";
                cbPeriodo.ValueMember = "Periodo";
                cbPeriodo.SelectedIndex = 0;

                dgvResultados.Visible = false;

                dgvResultados.CellValueChanged += dgvResultados_CellValueChanged;
                dgvResultados.CurrentCellDirtyStateChanged += (s, EventArgs) =>
                {
                    if (dgvResultados.IsCurrentCellDirty)
                    {
                        dgvResultados.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    }
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al cargar la ventana. Si el error persiste, contacte al administrador.", "Modificar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void dgvResultados_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (dgvResultados.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                bool estaMarcado = Convert.ToBoolean(dgvResultados.Rows[e.RowIndex].Cells["Seleccionar"].Value);
                string periodo = cbPeriodo.SelectedValue?.ToString();

                if (estaMarcado)
                {
                    LlenarCamposModificables(periodo);
                    // Desmarcar todas las demás
                    foreach (DataGridViewRow row in dgvResultados.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells["Seleccionar"].Value = false;
                        }
                    }
                }
                else
                {
                    clbCamposModificables.Items.Clear();
                    flpControlesDinamicos.Controls.Clear();
                    controlsModificables.Clear();
                }
            }
        }

        private void LlenarCamposModificables(string periodo) {
            
            List<string> campos = logica.ObtenerCamposModificables(periodo);

            clbCamposModificables.Items.Clear();
            //foreach (string campo in campos)
            //{
            //    clbCamposModificables.Items.Add(campo);

            //    if (clbCamposModificables.Items.Contains("IdDocentePorPeriodo"))
            //    {
            //        clbCamposModificables
            //    }
            //}

            for (int i = 0; i < campos.Count; i++)
            {
                clbCamposModificables.Items.Add(campos[i]);

                if (clbCamposModificables.Items[i].ToString() == "IdDocentePorPeriodo")
                {
                    clbCamposModificables.Items.RemoveAt(i);
                }
            }
        }

        private void clbCamposModificables_ItemCheck(object sender, ItemCheckEventArgs e) {
            try {
                this.BeginInvoke((MethodInvoker)delegate
                {

                    string campo = clbCamposModificables.Items[e.Index].ToString();

                    if (e.NewValue == CheckState.Checked)
                    {
                        if (!controlsModificables.ContainsKey(campo))
                        {
                            Label lbl = new Label()
                            {
                                Text = $"Nuevo valor para {campo}:",
                                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                                Font = new Font("Arial", 12),
                                AutoSize = true,
                                Margin = new Padding(0, 5, 0, 0)
                            };

                            TextBox txt = new TextBox()
                            {
                                Width = 250,
                                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                                Margin = new Padding(0, 2, 0, 10),
                                Font = new Font("Arial", 12)
                            };

                            TableLayoutPanel campoPanel = new TableLayoutPanel()
                            {
                                AutoSize = true,
                                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                ColumnCount = 1,
                                RowCount = 1,
                                Margin = new Padding(5)
                            };

                            campoPanel.Controls.Add(lbl, 0, 0);
                            campoPanel.Controls.Add(txt, 0, 1);

                            flpControlesDinamicos.Controls.Add(campoPanel);
                            controlsModificables[campo] = campoPanel;
                        }
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        if (controlsModificables.ContainsKey(campo))
                        {
                            Control panel = controlsModificables[campo];
                            flpControlesDinamicos.Controls.Remove(panel);
                            controlsModificables.Remove(campo);
                        }
                    }
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al consultar las columnas de la base de datos. Si el error persiste, contacte al administrador.", "Modificar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e) {
            if (cbPeriodo.SelectedIndex == 0)
            {
                MessageBox.Show("Error, debe seleccionar un período", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cedula = txbCedula.Text.Trim();
            string periodo = cbPeriodo.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(periodo))
            {
                MessageBox.Show("Debe seleccionar un período y escribir la cédula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            System.Data.DataTable resultados = await logica.ObtenerFilasDeDocentes(cedula, periodo);

            if (resultados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros con esa cédula en el período indicado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvResultados.DataSource = null;
                dgvResultados.Visible = false;
                return;
            }

            dgvResultados.Visible = true;
            dgvResultados.DataSource = resultados;
            dgvResultados.Columns["Seleccionar"].Visible = true;
            dgvResultados.Columns["IdDocentePorPeriodo"].Visible = false;

            //LlenarCamposModificables(periodo);
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

        private async Task CargarResultados(string cedula, string periodo) {
            System.Data.DataTable dt = await logica.ObtenerFilasDeDocentes(cedula, periodo);
            dgvResultados.DataSource = dt;
        }

        private async void btnModificar_Click(object sender, EventArgs e) {
            if (!dgvResultados.Visible)
            {
                MessageBox.Show("Seleccione el período y la cédula para comenzar a modificar.");
                return;
            }

            DataGridViewRow filaSeleccionada = null;

            foreach (DataGridViewRow fila in dgvResultados.Rows)
            {
                if (fila.Cells["Seleccionar"] is DataGridViewCheckBoxCell check && Convert.ToBoolean(check.Value))
                {
                    string periodo = cbPeriodo.SelectedValue?.ToString();

                    filaSeleccionada = fila;
                    break;
                }
            }
            if (filaSeleccionada == null)
            {
                MessageBox.Show("Debes marcar la fila del docente que deseas modificar");
                return;
            }

            // Obtener ID único desde la fila seleccionada
            int idDocente = Convert.ToInt32(filaSeleccionada.Cells["IdDocentePorPeriodo"].Value);

            // Obtener valores nuevos escritos por el usuario
            Dictionary<string, string> camposModificados = new Dictionary<string, string>();

            foreach (var campo in controlsModificables.Keys)
            {
                Control contenedor = controlsModificables[campo];

                TextBox txtNuevoValor = contenedor.Controls.OfType<TextBox>().FirstOrDefault();

                if (txtNuevoValor != null && !string.IsNullOrWhiteSpace(txtNuevoValor.Text))
                {
                    camposModificados[campo] = txtNuevoValor.Text;
                }
            }

            if (camposModificados.Count == 0)
            {
                MessageBox.Show("No se ha ingresado ningún valor nuevo para modificar.");
                return;
            }

            try
            {

                bool exito = logica.ModificarCamposDocentePorId(idDocente, camposModificados); 

                if (exito)
                {
                    MessageBox.Show("Datos modificados correctamente", "Modificar docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Vuelve a cargar los resultados para ver los cambios
                    await CargarResultados(txbCedula.Text, cbPeriodo.Text);
                    clbCamposModificables.Items.Clear();
                    flpControlesDinamicos.Controls.Clear();

                    
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la información.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al intentar modificar los datos. Si el error persiste, contacte al administrador.", "Modificar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

