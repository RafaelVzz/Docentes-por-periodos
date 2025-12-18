namespace CapaPresentacion {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txbClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbVerClave = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.etqIrACambiarClave = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.etqRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbClave
            // 
            this.txbClave.Depth = 0;
            this.txbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Hint = "Contraseña";
            this.txbClave.Location = new System.Drawing.Point(136, 298);
            this.txbClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '\0';
            this.txbClave.SelectedText = "";
            this.txbClave.SelectionLength = 0;
            this.txbClave.SelectionStart = 0;
            this.txbClave.Size = new System.Drawing.Size(244, 23);
            this.txbClave.TabIndex = 29;
            this.txbClave.UseSystemPasswordChar = true;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Depth = 0;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Hint = "Usuario";
            this.txbUsuario.Location = new System.Drawing.Point(136, 220);
            this.txbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.Size = new System.Drawing.Size(244, 23);
            this.txbUsuario.TabIndex = 28;
            this.txbUsuario.UseSystemPasswordChar = false;
            // 
            // cbVerClave
            // 
            this.cbVerClave.AutoSize = true;
            this.cbVerClave.Depth = 0;
            this.cbVerClave.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbVerClave.Location = new System.Drawing.Point(257, 333);
            this.cbVerClave.Margin = new System.Windows.Forms.Padding(0);
            this.cbVerClave.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbVerClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbVerClave.Name = "cbVerClave";
            this.cbVerClave.Ripple = true;
            this.cbVerClave.Size = new System.Drawing.Size(123, 30);
            this.cbVerClave.TabIndex = 30;
            this.cbVerClave.Text = "Ver contraseña";
            this.cbVerClave.UseVisualStyleBackColor = true;
            this.cbVerClave.CheckedChanged += new System.EventHandler(this.cbVerClave_CheckedChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSize = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(151, 430);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(205, 32);
            this.btnIniciarSesion.TabIndex = 31;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // etqIrACambiarClave
            // 
            this.etqIrACambiarClave.Location = new System.Drawing.Point(0, 488);
            this.etqIrACambiarClave.Name = "etqIrACambiarClave";
            this.etqIrACambiarClave.Size = new System.Drawing.Size(508, 16);
            this.etqIrACambiarClave.TabIndex = 32;
            this.etqIrACambiarClave.TabStop = true;
            this.etqIrACambiarClave.Text = "¿Olvidó su contraseña?";
            this.etqIrACambiarClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etqIrACambiarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.etqIrACambiarClave_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DocentesporPeriodos.Properties.Resources.boton_de_quitar_cuadrado;
            this.button1.Location = new System.Drawing.Point(483, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.BackgroundImage = global::DocentesporPeriodos.Properties.Resources.carga_de_datos__1_1;
            this.materialDivider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(508, 124);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // etqRespuesta
            // 
            this.etqRespuesta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etqRespuesta.Location = new System.Drawing.Point(0, 383);
            this.etqRespuesta.Name = "etqRespuesta";
            this.etqRespuesta.Size = new System.Drawing.Size(508, 23);
            this.etqRespuesta.TabIndex = 33;
            this.etqRespuesta.Text = "label2";
            this.etqRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etqRespuesta.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 515);
            this.Controls.Add(this.etqRespuesta);
            this.Controls.Add(this.etqIrACambiarClave);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.cbVerClave);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbUsuario;
        private MaterialSkin.Controls.MaterialCheckBox cbVerClave;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.LinkLabel etqIrACambiarClave;
        private System.Windows.Forms.Label etqRespuesta;
    }
}