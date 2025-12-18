using CapaLogica;
using CapaPresentacion.FuncionesFormulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class FormularioContenedor : Form {

        public FormularioContenedor() {
            InitializeComponent();
            MenuDefault();
        }

        #region Control de MenuDesplegable
        private void HideMenu()
        {
            if (panelModeloDocentes.Visible == true)
                panelModeloDocentes.Visible = false;
            //if (panelModeloInformes.Visible == true)
            //    panelModeloInformes.Visible = false;

            if (panelModeloInformes.Visible == true && pnlBotonesDinamicosImportaciones.Visible == true)
            {
                pnlBotonesDinamicosImportaciones.Visible = false;
                panelModeloInformes.Visible = false;
            }
            if (panelModeloInformes.Visible == true && pnlBotonesDinamicosExportaciones.Visible == true)
            {
                pnlBotonesDinamicosExportaciones.Visible = false;
                panelModeloInformes.Visible = false;
            }
            if (panelModeloData.Visible == true)
                panelModeloData.Visible = false;
        }

        private void ShowMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void MenuDefault()
        {
            panelModeloDocentes.Visible = false;
            panelModeloInformes.Visible = false;
            panelModeloData.Visible = false;
            pnlBotonesDinamicosExportaciones.Visible = false;
            pnlBotonesDinamicosImportaciones.Visible = false;
        }

        #endregion

        ClaseLogica logica = new ClaseLogica();
        private Form formularioActivo = null;

        private Point mouseOffset;
        private bool estaArrastrando;

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && !(this.WindowState == FormWindowState.Maximized))
            {
                estaArrastrando = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                estaArrastrando = false;
            }
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e) {
            if (estaArrastrando)
            {
                this.Location = new Point(this.Location.X + e.X - mouseOffset.X,
                                           this.Location.Y + e.Y - mouseOffset.Y);
            }
        }

        private async Task CargarBotonesDePeriodos() {
            try
            {

                List<string> periodos = await logica.ObtenerPeriodosUnicos();

                pnlBotonesDinamicosImportaciones.Controls.Clear();

                foreach (string periodo in periodos)
                {
                    Button btn = new Button();
                    btn.AutoSize = true;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Text = "Período " + periodo;
                    btn.Tag = periodo;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Dock = DockStyle.Top;
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Arial", 10);
                    btn.Click += BtnPeriodo_Click;
                    btn.MouseEnter += Btn_MouseEnter;
                    btn.MouseLeave += Btn_MouseLeave;

                    pnlBotonesDinamicosImportaciones.Controls.Add(btn);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar obtener los períodos . Si el error persiste, contacte al administrador." + "\n\n\n" + $"Mensaje tecnico: {ex.Message}", "Formulario Contenedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarBotonesDeFiltros() {
            try
            {

                List<string> filtros = await logica.ObtenerFiltrosGuardados();

                pnlBotonesDinamicosExportaciones.Controls.Clear();

                foreach (string nombreFiltro in filtros)
                {
                    Button btn = new Button();
                    ttFormularioPrincipal.SetToolTip(btn, nombreFiltro);
                    btn.AutoSize = true;
                    btn.Anchor = AnchorStyles.Top;
                    btn.Anchor = AnchorStyles.Bottom;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Text = nombreFiltro;
                    btn.Tag = nombreFiltro;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Dock = DockStyle.Top;
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Arial", 10);
                    btn.MouseEnter += Btn_MouseEnter;
                    btn.MouseLeave += Btn_MouseLeave;
                    btn.Click += BtnFiltro_Click;

                    pnlBotonesDinamicosExportaciones.Controls.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar los filtros. Si el error persiste, contacte al administrador." + "\n\n\n" + $"Mensaje tecnico: {ex.Message}", "Formulario Contenedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPeriodo_Click(object sender, EventArgs e) {
            HideMenu();
            Button btn = sender as Button;
            string periodo = btn.Tag.ToString();

            FormTablasHastaElMomento formPeriodo = new FormTablasHastaElMomento(periodo);

            Utilidades.AbrilFormularioEnPanel(formPeriodo, formularioActivo, panelContenedor);
            formularioActivo = formPeriodo;
        }

        private void BtnFiltro_Click(object sender, EventArgs e) {
            HideMenu();
            Button btn = sender as Button;
            string filtro = btn.Tag.ToString();

            FormFiltrosHastaElMomento formPeriodo = new FormFiltrosHastaElMomento(filtro);

            Utilidades.AbrilFormularioEnPanel(formPeriodo, formularioActivo, panelContenedor);
            formularioActivo = formPeriodo;
        }

        private void Btn_MouseEnter(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void Btn_MouseLeave(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e) {
            FuncionesFormulario.Utilidades.MinimizarVentana(this);
        }

        private void btnVentanaNormal_Click(object sender, EventArgs e) {
            FuncionesFormulario.Utilidades.VentanaNormal(this);
        }

        private void btnDesplegarOpcionesDocente_Click(object sender, EventArgs e) {
            ShowMenu(panelModeloDocentes);
        }

        private async void btnDesplegarInformes_Click(object sender, EventArgs e) {
            ShowMenu(panelModeloInformes);
            await CargarBotonesDePeriodos();
            await CargarBotonesDeFiltros();
        }

        private void btnDesplegarOpcionesData_Click(object sender, EventArgs e) {
            ShowMenu(panelModeloData);
        }

        private void btnImportarNuevaData_Click(object sender, EventArgs e) {
            HideMenu();
            FuncionesFormulario.Utilidades.AbrilFormularioEnPanel(new FormImportarData(), formularioActivo, panelContenedor);
        }

        private void btnFiltrarDocentes_Click(object sender, EventArgs e) {
            HideMenu();
            FuncionesFormulario.Utilidades.AbrilFormularioEnPanel(new FormFiltrarDocente(), formularioActivo, panelContenedor);
        }

        private async void btnAbrirPanelBotonesDinamicosImportaciones_Click(object sender, EventArgs e) {
                //if (await logica.SinRegistrosDeImportaciones())
                //{
                //    HideMenu();
                //    MessageBox.Show("Aún no se han realizado importaciones.", "Formulario contenedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                var importacion = await logica.SinRegistrosDeImportacionesAsync();

                if (!importacion.HayImportaciones)
                {
                    HideMenu();
                    MessageBox.Show($"{importacion.Mensaje}", "Importaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            else if (importacion.EsErrorTecnico)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar las importaciones. Si el error persiste, contacte al administrador." + "\n\n\n" + $"Mensaje tecnico: {importacion.Mensaje}", "Formulario Contenedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                ShowMenu(pnlBotonesDinamicosImportaciones);
        }
        
        

        private async void btnAbrirPanelExportacionesDeData_Click(object sender, EventArgs e) {
            //if (logica.SinRegistrosDeFiltros())
            //{
            //    HideMenu();
            //    MessageBox.Show("Aún no se han realizado exportaciones de filtrado de datos.", "Formulario contenedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}



            var exportacion = await logica.SinRegistrosDeFiltrosAsync();

            if (!exportacion.HayExportaciones)
            {
                HideMenu();
                MessageBox.Show($"{exportacion.Mensaje}", "Exportaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (exportacion.EsErrorTecnico)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar las exportaciones. Si el error persiste, contacte al administrador." + "\n\n\n" + $"Mensaje tecnico: {exportacion.Mensaje}", "Formulario Contenedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                ShowMenu(pnlBotonesDinamicosExportaciones);
        }

        private void btnModificarDocente_Click(object sender, EventArgs e) {
            HideMenu();
            FuncionesFormulario.Utilidades.AbrilFormularioEnPanel(new FormModificarDocente(), formularioActivo, panelContenedor);
        }

        private void btnDesplegarOpcionesDocente_MouseEnter(object sender, EventArgs e) {
            btnDesplegarOpcionesDocente.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnDesplegarOpcionesDocente_MouseLeave(object sender, EventArgs e) {
            btnDesplegarOpcionesDocente.BackColor = Color.White;
        }

        private void btnFiltrarDocentes_MouseEnter(object sender, EventArgs e) {
            btnFiltrarDocentes.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnFiltrarDocentes_MouseLeave(object sender, EventArgs e) {
            btnFiltrarDocentes.BackColor = Color.White;
        }

        private void btnModificarDocente_MouseEnter(object sender, EventArgs e) {
            btnModificarDocente.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnModificarDocente_MouseLeave(object sender, EventArgs e) {
            btnModificarDocente.BackColor = Color.White;
        }

        private void btnDesplegarInformes_MouseEnter(object sender, EventArgs e) {
            btnDesplegarInformes.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnDesplegarInformes_MouseLeave(object sender, EventArgs e) {
            btnDesplegarInformes.BackColor = Color.White;
        }

        private void btnAbrirPanelBotonesDinamicosImportaciones_MouseEnter(object sender, EventArgs e) {
            btnAbrirPanelBotonesDinamicosImportaciones.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnAbrirPanelBotonesDinamicosImportaciones_MouseLeave(object sender, EventArgs e) {
            btnAbrirPanelBotonesDinamicosImportaciones.BackColor = Color.White;
        }

        private void btnAbrirPanelExportacionesDeData_MouseEnter(object sender, EventArgs e) {
            btnAbrirPanelExportacionesDeData.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnAbrirPanelExportacionesDeData_MouseLeave(object sender, EventArgs e) {
            btnAbrirPanelExportacionesDeData.BackColor = Color.White;
        }

        private void btnDesplegarOpcionesData_MouseEnter(object sender, EventArgs e) {
            btnDesplegarOpcionesData.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnDesplegarOpcionesData_MouseLeave(object sender, EventArgs e) {
            btnDesplegarOpcionesData.BackColor = Color.White;
        }

        private void btnImportarNuevaData_MouseEnter(object sender, EventArgs e) {
            btnImportarNuevaData.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnImportarNuevaData_MouseLeave(object sender, EventArgs e) {
            btnImportarNuevaData.BackColor = Color.White;
        }

        private void btnAcercaDe_MouseEnter(object sender, EventArgs e) {
            btnAcercaDe.BackColor = Color.FromArgb(0, 174, 242);
        }

        private void btnAcercaDe_MouseLeave(object sender, EventArgs e) {
            btnAcercaDe.BackColor = Color.White;
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            HideMenu();
            FuncionesFormulario.Utilidades.AbrilFormularioEnPanel(new FormAcercaDe(), formularioActivo, panelContenedor);
        }
    }
}
