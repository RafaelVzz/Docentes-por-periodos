using CapaLogica;
using CapaPresentacion.FuncionesFormulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class FormTablasHastaElMomento : Form {

        private string _periodo;
        private ClaseLogica logica = new ClaseLogica();
        public FormTablasHastaElMomento(string periodo) {
            InitializeComponent();
            FuncionesFormulario.Utilidades.PersonalizarDataGridView(dgvInformes);
            _periodo = periodo;
            try
            {
                CargarDatosPorPeriodo();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al intentar conectar a la base de datos. Si el error persiste, contacte al administrador.", "Tablas hasta el momento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosPorPeriodo() {
            DataTable dt = logica.ObtenerDataPorPeriodo(_periodo);

            if (dgvInformes.Columns.Contains("IdDocentePorPeriodo"))
            {
                dgvInformes.Columns["IdDocentePorPeriodo"].Visible = false;
            }
            else if (dgvInformes.Columns.Contains("nombreFiltro"))
            {
                dgvInformes.Columns["nombreFiltro"].Visible = false;
            }
            dgvInformes.DataSource = dt;
        }
    }
}
