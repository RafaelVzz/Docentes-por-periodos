using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CapaPresentacion.FuncionesFormulario {
    internal static class Validaciones 
    {
        internal static bool CamposLlenos(Control user, Control pasword) {
            return !string.IsNullOrWhiteSpace(user.Text) &&
                !string.IsNullOrWhiteSpace(pasword.Text);
        }

        internal static bool CamposLlenosCambiarClave(Control user, Control pin, Control clave, Control repetirClave) {
            return !string.IsNullOrWhiteSpace(user.Text) &&
                !string.IsNullOrWhiteSpace(pin.Text) &&
                !string.IsNullOrEmpty(clave.Text) &&
                !string.IsNullOrWhiteSpace(repetirClave.Text);
        }

        internal static bool ClaveIgual(MaterialSingleLineTextField clave, MaterialSingleLineTextField repetir) {
            return clave.Text == repetir.Text;
        }

        internal static bool DataGridLimpio(DataGridView dgv) {
            return dgv.Rows.Count == 0;
        }

        public static bool HayFiltros(TextBox txbCedula, TextBox txbDocente, ComboBox cbCondicion, ComboBox cbCategoria, ComboBox cbClasificacion, ComboBox cbSeccion, ComboBox cbPrograma, ComboBox cbNucleo, TextBox txbAsignatura, MaskedTextBox txbCantidad, MaskedTextBox txbHoras) {
            return !string.IsNullOrWhiteSpace(txbCedula.Text) ||
                   !string.IsNullOrWhiteSpace(txbDocente.Text) ||
                   cbCondicion.SelectedIndex > 0 ||
                   cbCategoria.SelectedIndex > 0 ||
                   cbClasificacion.SelectedIndex > 0 ||
                   cbSeccion.SelectedIndex > 0 ||
                   cbPrograma.SelectedIndex > 0 ||
                   cbNucleo.SelectedIndex > 0 ||
                   !string.IsNullOrWhiteSpace(txbAsignatura.Text) ||
                   !string.IsNullOrWhiteSpace(txbCantidad.Text) ||
                   !string.IsNullOrWhiteSpace(txbHoras.Text);
        }
    }
}
