using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        ClaseLogica logica = new ClaseLogica();

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void cbVerClave_CheckedChanged(object sender, EventArgs e) {
            txbClave.UseSystemPasswordChar = !cbVerClave.Checked;
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e) {
            if (!FuncionesFormulario.Validaciones.CamposLlenos(txbUsuario, txbClave))
            {
                etqRespuesta.Text = "Por favor, llene todos los campos";
                etqRespuesta.Visible = true;
                return;
            }

            string user = txbUsuario.Text.Trim();
            string clave = txbClave.Text;

            etqRespuesta.Text = "Procesando credenciales...";
            etqRespuesta.ForeColor = Color.Black;
            etqRespuesta.Visible = true;

            var resultado = await logica.ValidarLoginAsync(user, clave);

            if (resultado.EsValido)
            {
                FormularioContenedor contenedor = new FormularioContenedor();
                etqRespuesta.Text = resultado.Mensaje;
                etqRespuesta.ForeColor = Color.Green;
                this.Hide();
                contenedor.Show();
            }
            else if (!resultado.EsErrorTecnico && !resultado.EsValido)
            {
                etqRespuesta.Text = resultado.Mensaje;
                etqRespuesta.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show($"Ha ocurrido un error al consultar las credenciales en la base de datos, si el error persiste, contacte al administrador. \n\n Error técnico: {resultado.Mensaje}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                etqRespuesta.Visible = false;
            }
        }

        private void etqIrACambiarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CambiarClave cc = new CambiarClave();
            this.Hide();
            cc.Show();
        }
    }
}
