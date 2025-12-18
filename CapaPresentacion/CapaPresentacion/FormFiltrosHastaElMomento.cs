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
    public partial class FormFiltrosHastaElMomento : Form {
        
        private string nombreFiltro;
        ClaseLogica logica = new ClaseLogica();

        public FormFiltrosHastaElMomento(string nombreFiltro) {
            InitializeComponent();
            Utilidades.PersonalizarDataGridView(dgvFiltros);
            this.nombreFiltro = nombreFiltro;
            CargarDatos(nombreFiltro);
        }

        private void CargarDatos(string nombreFiltro) {
            DataTable dt = logica.ObtenerFiltrado(nombreFiltro);
            dgvFiltros.DataSource = dt;

            if (dgvFiltros.Columns.Contains("IdDocentePorPeriodo"))
            {
                dgvFiltros.Columns["IdDocentePorPeriodo"].Visible = false;
            }
            else if (dgvFiltros.Columns.Contains("nombreFiltro"))
            {
                dgvFiltros.Columns["nombreFiltro"].Visible = false;
            }
        }
    }
}
