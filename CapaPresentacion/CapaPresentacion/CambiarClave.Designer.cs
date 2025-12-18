namespace CapaPresentacion {
    partial class CambiarClave {
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
            this.button1 = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.txbNuevaClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbPin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRepetirNuevaClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pbVerClave = new System.Windows.Forms.PictureBox();
            this.pbVerClave2 = new System.Windows.Forms.PictureBox();
            this.pbOcultarClave = new System.Windows.Forms.PictureBox();
            this.pbOcultarClave2 = new System.Windows.Forms.PictureBox();
            this.pbVerPin = new System.Windows.Forms.PictureBox();
            this.pbOcultarPin = new System.Windows.Forms.PictureBox();
            this.etqRespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerClave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarClave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarPin)).BeginInit();
            this.SuspendLayout();
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
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.BackgroundImage = global::DocentesporPeriodos.Properties.Resources.carga_de_datos__1_;
            this.materialDivider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(508, 124);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.AutoSize = true;
            this.btnCambiarClave.BackColor = System.Drawing.Color.Black;
            this.btnCambiarClave.FlatAppearance.BorderSize = 0;
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarClave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarClave.ForeColor = System.Drawing.Color.White;
            this.btnCambiarClave.Location = new System.Drawing.Point(149, 464);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(205, 32);
            this.btnCambiarClave.TabIndex = 21;
            this.btnCambiarClave.Text = "Cambiar contraseña";
            this.btnCambiarClave.UseVisualStyleBackColor = false;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // txbNuevaClave
            // 
            this.txbNuevaClave.Depth = 0;
            this.txbNuevaClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNuevaClave.Hint = "Nueva contraseña";
            this.txbNuevaClave.Location = new System.Drawing.Point(132, 323);
            this.txbNuevaClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNuevaClave.Name = "txbNuevaClave";
            this.txbNuevaClave.PasswordChar = '\0';
            this.txbNuevaClave.SelectedText = "";
            this.txbNuevaClave.SelectionLength = 0;
            this.txbNuevaClave.SelectionStart = 0;
            this.txbNuevaClave.Size = new System.Drawing.Size(244, 23);
            this.txbNuevaClave.TabIndex = 19;
            this.txbNuevaClave.UseSystemPasswordChar = true;
            // 
            // txbPin
            // 
            this.txbPin.Depth = 0;
            this.txbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPin.Hint = "Pin correspondiente";
            this.txbPin.Location = new System.Drawing.Point(132, 270);
            this.txbPin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbPin.Name = "txbPin";
            this.txbPin.PasswordChar = '\0';
            this.txbPin.SelectedText = "";
            this.txbPin.SelectionLength = 0;
            this.txbPin.SelectionStart = 0;
            this.txbPin.Size = new System.Drawing.Size(244, 23);
            this.txbPin.TabIndex = 18;
            this.txbPin.UseSystemPasswordChar = true;
            this.txbPin.TextChanged += new System.EventHandler(this.txbPin_TextChanged);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Depth = 0;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Hint = "Usuario";
            this.txbUsuario.Location = new System.Drawing.Point(132, 217);
            this.txbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.Size = new System.Drawing.Size(244, 23);
            this.txbUsuario.TabIndex = 17;
            this.txbUsuario.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cambio de contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbRepetirNuevaClave
            // 
            this.txbRepetirNuevaClave.Depth = 0;
            this.txbRepetirNuevaClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRepetirNuevaClave.Hint = "Repita la contraseña";
            this.txbRepetirNuevaClave.Location = new System.Drawing.Point(132, 376);
            this.txbRepetirNuevaClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbRepetirNuevaClave.Name = "txbRepetirNuevaClave";
            this.txbRepetirNuevaClave.PasswordChar = '\0';
            this.txbRepetirNuevaClave.SelectedText = "";
            this.txbRepetirNuevaClave.SelectionLength = 0;
            this.txbRepetirNuevaClave.SelectionStart = 0;
            this.txbRepetirNuevaClave.Size = new System.Drawing.Size(244, 23);
            this.txbRepetirNuevaClave.TabIndex = 20;
            this.txbRepetirNuevaClave.UseSystemPasswordChar = true;
            // 
            // pbVerClave
            // 
            this.pbVerClave.Image = global::DocentesporPeriodos.Properties.Resources.invisible;
            this.pbVerClave.Location = new System.Drawing.Point(382, 322);
            this.pbVerClave.Name = "pbVerClave";
            this.pbVerClave.Size = new System.Drawing.Size(24, 24);
            this.pbVerClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVerClave.TabIndex = 22;
            this.pbVerClave.TabStop = false;
            this.pbVerClave.Click += new System.EventHandler(this.pbVerClave_Click);
            // 
            // pbVerClave2
            // 
            this.pbVerClave2.Image = global::DocentesporPeriodos.Properties.Resources.invisible;
            this.pbVerClave2.Location = new System.Drawing.Point(382, 375);
            this.pbVerClave2.Name = "pbVerClave2";
            this.pbVerClave2.Size = new System.Drawing.Size(24, 24);
            this.pbVerClave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVerClave2.TabIndex = 23;
            this.pbVerClave2.TabStop = false;
            this.pbVerClave2.Click += new System.EventHandler(this.pbVerClave2_Click);
            // 
            // pbOcultarClave
            // 
            this.pbOcultarClave.Image = global::DocentesporPeriodos.Properties.Resources.ojo;
            this.pbOcultarClave.Location = new System.Drawing.Point(382, 322);
            this.pbOcultarClave.Name = "pbOcultarClave";
            this.pbOcultarClave.Size = new System.Drawing.Size(24, 24);
            this.pbOcultarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOcultarClave.TabIndex = 24;
            this.pbOcultarClave.TabStop = false;
            this.pbOcultarClave.Click += new System.EventHandler(this.pbOcultarCLave_Click);
            // 
            // pbOcultarClave2
            // 
            this.pbOcultarClave2.Image = global::DocentesporPeriodos.Properties.Resources.ojo;
            this.pbOcultarClave2.Location = new System.Drawing.Point(382, 375);
            this.pbOcultarClave2.Name = "pbOcultarClave2";
            this.pbOcultarClave2.Size = new System.Drawing.Size(24, 24);
            this.pbOcultarClave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOcultarClave2.TabIndex = 25;
            this.pbOcultarClave2.TabStop = false;
            this.pbOcultarClave2.Click += new System.EventHandler(this.pbOcultarClave2_Click);
            // 
            // pbVerPin
            // 
            this.pbVerPin.Image = global::DocentesporPeriodos.Properties.Resources.invisible;
            this.pbVerPin.Location = new System.Drawing.Point(382, 269);
            this.pbVerPin.Name = "pbVerPin";
            this.pbVerPin.Size = new System.Drawing.Size(24, 24);
            this.pbVerPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVerPin.TabIndex = 26;
            this.pbVerPin.TabStop = false;
            this.pbVerPin.Click += new System.EventHandler(this.pbVerPin_Click);
            // 
            // pbOcultarPin
            // 
            this.pbOcultarPin.Image = global::DocentesporPeriodos.Properties.Resources.ojo;
            this.pbOcultarPin.Location = new System.Drawing.Point(382, 269);
            this.pbOcultarPin.Name = "pbOcultarPin";
            this.pbOcultarPin.Size = new System.Drawing.Size(24, 24);
            this.pbOcultarPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOcultarPin.TabIndex = 27;
            this.pbOcultarPin.TabStop = false;
            this.pbOcultarPin.Click += new System.EventHandler(this.pbOcultarPin_Click);
            // 
            // etqRespuesta
            // 
            this.etqRespuesta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etqRespuesta.Location = new System.Drawing.Point(0, 420);
            this.etqRespuesta.Name = "etqRespuesta";
            this.etqRespuesta.Size = new System.Drawing.Size(508, 23);
            this.etqRespuesta.TabIndex = 34;
            this.etqRespuesta.Text = "label2";
            this.etqRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etqRespuesta.Visible = false;
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 515);
            this.Controls.Add(this.etqRespuesta);
            this.Controls.Add(this.pbVerPin);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.txbPin);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txbRepetirNuevaClave);
            this.Controls.Add(this.txbNuevaClave);
            this.Controls.Add(this.pbVerClave);
            this.Controls.Add(this.pbVerClave2);
            this.Controls.Add(this.pbOcultarClave);
            this.Controls.Add(this.pbOcultarClave2);
            this.Controls.Add(this.pbOcultarPin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarClave";
            ((System.ComponentModel.ISupportInitialize)(this.pbVerClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerClave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarClave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarPin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Button btnCambiarClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNuevaClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbPin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbUsuario;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbRepetirNuevaClave;
        private System.Windows.Forms.PictureBox pbVerClave;
        private System.Windows.Forms.PictureBox pbVerClave2;
        private System.Windows.Forms.PictureBox pbOcultarClave;
        private System.Windows.Forms.PictureBox pbOcultarClave2;
        private System.Windows.Forms.PictureBox pbVerPin;
        private System.Windows.Forms.PictureBox pbOcultarPin;
        private System.Windows.Forms.Label etqRespuesta;
    }
}