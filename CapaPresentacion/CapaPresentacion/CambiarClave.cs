using CapaEntidades;
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
    public partial class CambiarClave : Form {
        public CambiarClave() {
            InitializeComponent();
        }

        
        ClaseLogica logica = new ClaseLogica();

        private void button1_Click(object sender, EventArgs e) {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private async void btnCambiarClave_Click(object sender, EventArgs e) {
            if (!FuncionesFormulario.Validaciones.CamposLlenosCambiarClave(txbUsuario, txbPin, txbNuevaClave, txbRepetirNuevaClave))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Cambiar clave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txbUsuario.Text.Trim();
            int pin = int.Parse(txbPin.Text);
            string nuevaClave = txbNuevaClave.Text;
            string repetirClave = txbRepetirNuevaClave.Text;

            etqRespuesta.Text = "Cambiando contraseña...";
            etqRespuesta.ForeColor = Color.Black;
            etqRespuesta.Visible = true;

            var resultado = await logica.CambiarClaveAsync(usuario, pin, nuevaClave);

            if (resultado.Exito && Validaciones.ClaveIgual(txbNuevaClave, txbRepetirNuevaClave))
            {
                Login login = new Login();
                etqRespuesta.Text = resultado.Mensaje;
                etqRespuesta.ForeColor = Color.Green;
                this.Hide();
                login.Show();
            }
            else if (!resultado.Exito && !resultado.EsErrorTecnico)
            {
                etqRespuesta.Text = resultado.Mensaje;
                etqRespuesta.ForeColor = Color.Red;
            }
            else
            {
                etqRespuesta.Visible = false;
                MessageBox.Show($"Ha ocurrido un error al intentar cambiar la contraseña, si el error persiste, contacte al administrador. \n\n Error técnico: {resultado.Mensaje}", "Cambio de clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbOcultarCLave_Click(object sender, EventArgs e) {
            pbOcultarClave.Focus();
            FuncionesFormulario.Utilidades.AlternarVisibilidadClave(txbNuevaClave, pbOcultarClave, pbVerClave);
        }

        private void pbVerClave_Click(object sender, EventArgs e) {
            pbVerClave.Focus();
            FuncionesFormulario.Utilidades.AlternarVisibilidadClave(txbNuevaClave, pbOcultarClave, pbVerClave);
        }

        private void pbVerClave2_Click(object sender, EventArgs e) {
            pbVerClave2.Focus();
            FuncionesFormulario.Utilidades.AlternarVisibilidadClave(txbRepetirNuevaClave, pbOcultarClave2, pbVerClave2);
        }

        private void pbOcultarClave2_Click(object sender, EventArgs e) {
            pbOcultarClave2.Focus();
            FuncionesFormulario.Utilidades.AlternarVisibilidadClave(txbRepetirNuevaClave, pbOcultarClave2, pbVerClave2);
        }

        private void pbVerPin_Click(object sender, EventArgs e) {
            FuncionesFormulario.Utilidades.AlternarVisibilidadClave(txbPin, pbOcultarPin, pbVerPin);
        }

        private void pbOcultarPin_Click(object sender, EventArgs e) {
            FuncionesFormulario.Utilidades.AlternarVisibilidadClave(txbPin, pbOcultarPin, pbVerPin);
        }

        private void txbPin_TextChanged(object sender, EventArgs e) {
            string cadena = @"^\d{0,4}?$";

            Regex regex = new Regex(cadena);

            if (!regex.IsMatch(txbPin.Text) && txbPin.Text.Length > 0)
            {
                txbPin.Text = txbPin.Text.Substring(0, txbPin.Text.Length - 1);
                txbPin.SelectionStart = txbPin.Text.Length;
            }
        }
    }
}
