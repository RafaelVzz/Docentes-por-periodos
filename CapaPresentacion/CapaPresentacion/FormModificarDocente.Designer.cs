namespace CapaPresentacion {
    partial class FormModificarDocente {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarDocente));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.txbCedula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelModificaciones = new System.Windows.Forms.Panel();
            this.tlpSegundaFila = new System.Windows.Forms.TableLayoutPanel();
            this.flpControlesDinamicos = new System.Windows.Forms.FlowLayoutPanel();
            this.clbCamposModificables = new System.Windows.Forms.CheckedListBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.panelModificaciones.SuspendLayout();
            this.tlpSegundaFila.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpBusqueda, 0, 0);
            this.tlpPrincipal.Controls.Add(this.dgvResultados, 0, 1);
            this.tlpPrincipal.Controls.Add(this.panelModificaciones, 0, 2);
            this.tlpPrincipal.Controls.Add(this.panelInferior, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.715134F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.41543F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.18694F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97923F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1107, 694);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.ColumnCount = 3;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBusqueda.Controls.Add(this.cbPeriodo, 0, 0);
            this.tlpBusqueda.Controls.Add(this.txbCedula, 1, 0);
            this.tlpBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tlpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBusqueda.Location = new System.Drawing.Point(13, 13);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 1;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusqueda.Size = new System.Drawing.Size(1081, 45);
            this.tlpBusqueda.TabIndex = 0;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPeriodo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(20, 7);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(20, 3, 20, 5);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(284, 28);
            this.cbPeriodo.TabIndex = 0;
            // 
            // txbCedula
            // 
            this.txbCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCedula.Depth = 0;
            this.txbCedula.Hint = "Cedula del docente a buscar (ejemplo: 12345678):";
            this.txbCedula.Location = new System.Drawing.Point(399, 11);
            this.txbCedula.Margin = new System.Windows.Forms.Padding(75, 3, 75, 3);
            this.txbCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.PasswordChar = '\0';
            this.txbCedula.SelectedText = "";
            this.txbCedula.SelectionLength = 0;
            this.txbCedula.SelectionStart = 0;
            this.txbCedula.Size = new System.Drawing.Size(390, 23);
            this.txbCedula.TabIndex = 1;
            this.txbCedula.UseSystemPasswordChar = false;
            this.txbCedula.TextChanged += new System.EventHandler(this.txbCedula_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::DocentesporPeriodos.Properties.Resources.search1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(867, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(211, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.Location = new System.Drawing.Point(25, 76);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(15);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(1057, 174);
            this.dgvResultados.TabIndex = 1;
            this.dgvResultados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellValueChanged);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelModificaciones
            // 
            this.panelModificaciones.AutoScroll = true;
            this.panelModificaciones.Controls.Add(this.tlpSegundaFila);
            this.panelModificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModificaciones.Location = new System.Drawing.Point(20, 275);
            this.panelModificaciones.Margin = new System.Windows.Forms.Padding(10);
            this.panelModificaciones.Name = "panelModificaciones";
            this.panelModificaciones.Size = new System.Drawing.Size(1067, 323);
            this.panelModificaciones.TabIndex = 2;
            // 
            // tlpSegundaFila
            // 
            this.tlpSegundaFila.ColumnCount = 2;
            this.tlpSegundaFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpSegundaFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpSegundaFila.Controls.Add(this.flpControlesDinamicos, 1, 0);
            this.tlpSegundaFila.Controls.Add(this.clbCamposModificables, 0, 0);
            this.tlpSegundaFila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSegundaFila.Location = new System.Drawing.Point(0, 0);
            this.tlpSegundaFila.Name = "tlpSegundaFila";
            this.tlpSegundaFila.RowCount = 1;
            this.tlpSegundaFila.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSegundaFila.Size = new System.Drawing.Size(1067, 323);
            this.tlpSegundaFila.TabIndex = 0;
            // 
            // flpControlesDinamicos
            // 
            this.flpControlesDinamicos.AutoScroll = true;
            this.flpControlesDinamicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpControlesDinamicos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpControlesDinamicos.Location = new System.Drawing.Point(323, 3);
            this.flpControlesDinamicos.Name = "flpControlesDinamicos";
            this.flpControlesDinamicos.Padding = new System.Windows.Forms.Padding(10);
            this.flpControlesDinamicos.Size = new System.Drawing.Size(741, 317);
            this.flpControlesDinamicos.TabIndex = 2;
            this.flpControlesDinamicos.WrapContents = false;
            // 
            // clbCamposModificables
            // 
            this.clbCamposModificables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCamposModificables.CheckOnClick = true;
            this.clbCamposModificables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbCamposModificables.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCamposModificables.FormattingEnabled = true;
            this.clbCamposModificables.HorizontalScrollbar = true;
            this.clbCamposModificables.Location = new System.Drawing.Point(3, 3);
            this.clbCamposModificables.Name = "clbCamposModificables";
            this.clbCamposModificables.Size = new System.Drawing.Size(314, 317);
            this.clbCamposModificables.TabIndex = 1;
            this.clbCamposModificables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCamposModificables_ItemCheck);
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnModificar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(13, 618);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1081, 63);
            this.panelInferior.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::DocentesporPeriodos.Properties.Resources.profile__1_;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(435, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(211, 57);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormModificarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 694);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarDocente";
            this.Text = "FormModificarDocente";
            this.Load += new System.EventHandler(this.FormModificarDocente_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.panelModificaciones.ResumeLayout(false);
            this.tlpSegundaFila.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Panel panelModificaciones;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TableLayoutPanel tlpSegundaFila;
        private System.Windows.Forms.FlowLayoutPanel flpControlesDinamicos;
        private System.Windows.Forms.CheckedListBox clbCamposModificables;
    }
}