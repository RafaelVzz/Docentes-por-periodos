namespace CapaPresentacion {
    partial class FormFiltrarDocente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltrarDocente));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbElegirPeriodo = new System.Windows.Forms.ComboBox();
            this.btnElegirPeriodo = new System.Windows.Forms.Button();
            this.gbFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.mtxbHoras = new System.Windows.Forms.MaskedTextBox();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbNucleo = new System.Windows.Forms.ComboBox();
            this.cbPrograma = new System.Windows.Forms.ComboBox();
            this.cbCategoriaDocente = new System.Windows.Forms.ComboBox();
            this.txbAsignatura = new System.Windows.Forms.TextBox();
            this.txbDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.gbTipoDeHora = new System.Windows.Forms.GroupBox();
            this.rbtnLab = new System.Windows.Forms.RadioButton();
            this.rbtnPractica = new System.Windows.Forms.RadioButton();
            this.rbtnTeoria = new System.Windows.Forms.RadioButton();
            this.mtxbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.dgvDataFiltrada = new System.Windows.Forms.DataGridView();
            this.tlpExportarYLimpiar = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.btnExportarAExcel = new System.Windows.Forms.Button();
            this.etqRespuesta = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbFiltrosBusqueda.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.gbTipoDeHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFiltrada)).BeginInit();
            this.tlpExportarYLimpiar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpPrincipal.Controls.Add(this.gbFiltrosBusqueda, 0, 1);
            this.tlpPrincipal.Controls.Add(this.dgvDataFiltrada, 0, 3);
            this.tlpPrincipal.Controls.Add(this.tlpExportarYLimpiar, 0, 4);
            this.tlpPrincipal.Controls.Add(this.etqRespuesta, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.676558F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.02077F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.637982F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.46587F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.013694F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1107, 694);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cbElegirPeriodo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnElegirPeriodo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1081, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbElegirPeriodo
            // 
            this.cbElegirPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbElegirPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbElegirPeriodo.FormattingEnabled = true;
            this.cbElegirPeriodo.Location = new System.Drawing.Point(3, 5);
            this.cbElegirPeriodo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbElegirPeriodo.Name = "cbElegirPeriodo";
            this.cbElegirPeriodo.Size = new System.Drawing.Size(858, 26);
            this.cbElegirPeriodo.TabIndex = 6;
            this.cbElegirPeriodo.Text = "Seleccione el periodo";
            // 
            // btnElegirPeriodo
            // 
            this.btnElegirPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElegirPeriodo.AutoSize = true;
            this.btnElegirPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.btnElegirPeriodo.FlatAppearance.BorderSize = 0;
            this.btnElegirPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirPeriodo.Image = global::DocentesporPeriodos.Properties.Resources.search;
            this.btnElegirPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElegirPeriodo.Location = new System.Drawing.Point(867, 3);
            this.btnElegirPeriodo.Name = "btnElegirPeriodo";
            this.btnElegirPeriodo.Size = new System.Drawing.Size(211, 30);
            this.btnElegirPeriodo.TabIndex = 7;
            this.btnElegirPeriodo.Text = "Filtrar";
            this.btnElegirPeriodo.UseVisualStyleBackColor = false;
            this.btnElegirPeriodo.Click += new System.EventHandler(this.btnElegirPeriodo_Click);
            // 
            // gbFiltrosBusqueda
            // 
            this.gbFiltrosBusqueda.Controls.Add(this.tlpFiltros);
            this.gbFiltrosBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiltrosBusqueda.Location = new System.Drawing.Point(13, 58);
            this.gbFiltrosBusqueda.Name = "gbFiltrosBusqueda";
            this.gbFiltrosBusqueda.Size = new System.Drawing.Size(1081, 257);
            this.gbFiltrosBusqueda.TabIndex = 1;
            this.gbFiltrosBusqueda.TabStop = false;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 4;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltros.Controls.Add(this.mtxbHoras, 1, 5);
            this.tlpFiltros.Controls.Add(this.cbSeccion, 1, 3);
            this.tlpFiltros.Controls.Add(this.cbClasificacion, 3, 1);
            this.tlpFiltros.Controls.Add(this.cbNucleo, 1, 4);
            this.tlpFiltros.Controls.Add(this.cbPrograma, 3, 3);
            this.tlpFiltros.Controls.Add(this.cbCategoriaDocente, 1, 2);
            this.tlpFiltros.Controls.Add(this.txbAsignatura, 3, 2);
            this.tlpFiltros.Controls.Add(this.txbDocente, 3, 0);
            this.tlpFiltros.Controls.Add(this.label3, 2, 0);
            this.tlpFiltros.Controls.Add(this.label21, 0, 5);
            this.tlpFiltros.Controls.Add(this.label19, 2, 4);
            this.tlpFiltros.Controls.Add(this.label17, 0, 4);
            this.tlpFiltros.Controls.Add(this.label15, 2, 3);
            this.tlpFiltros.Controls.Add(this.label13, 0, 3);
            this.tlpFiltros.Controls.Add(this.label11, 2, 2);
            this.tlpFiltros.Controls.Add(this.label9, 0, 2);
            this.tlpFiltros.Controls.Add(this.label7, 2, 1);
            this.tlpFiltros.Controls.Add(this.label5, 0, 1);
            this.tlpFiltros.Controls.Add(this.label1, 0, 0);
            this.tlpFiltros.Controls.Add(this.txbCedula, 1, 0);
            this.tlpFiltros.Controls.Add(this.cbCondicion, 1, 1);
            this.tlpFiltros.Controls.Add(this.gbTipoDeHora, 2, 5);
            this.tlpFiltros.Controls.Add(this.mtxbCantidad, 3, 4);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(3, 16);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 6;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFiltros.Size = new System.Drawing.Size(1075, 238);
            this.tlpFiltros.TabIndex = 0;
            // 
            // mtxbHoras
            // 
            this.mtxbHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxbHoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbHoras.Location = new System.Drawing.Point(271, 203);
            this.mtxbHoras.Mask = "9";
            this.mtxbHoras.Name = "mtxbHoras";
            this.mtxbHoras.Size = new System.Drawing.Size(262, 26);
            this.mtxbHoras.TabIndex = 44;
            this.mtxbHoras.ValidatingType = typeof(int);
            // 
            // cbSeccion
            // 
            this.cbSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(271, 123);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(262, 26);
            this.cbSeccion.TabIndex = 40;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClasificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(807, 45);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(265, 26);
            this.cbClasificacion.TabIndex = 39;
            // 
            // cbNucleo
            // 
            this.cbNucleo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNucleo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNucleo.FormattingEnabled = true;
            this.cbNucleo.Location = new System.Drawing.Point(271, 162);
            this.cbNucleo.Name = "cbNucleo";
            this.cbNucleo.Size = new System.Drawing.Size(262, 26);
            this.cbNucleo.TabIndex = 35;
            // 
            // cbPrograma
            // 
            this.cbPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPrograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrograma.FormattingEnabled = true;
            this.cbPrograma.Location = new System.Drawing.Point(807, 123);
            this.cbPrograma.Name = "cbPrograma";
            this.cbPrograma.Size = new System.Drawing.Size(265, 26);
            this.cbPrograma.TabIndex = 34;
            // 
            // cbCategoriaDocente
            // 
            this.cbCategoriaDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoriaDocente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaDocente.FormattingEnabled = true;
            this.cbCategoriaDocente.Location = new System.Drawing.Point(271, 84);
            this.cbCategoriaDocente.Name = "cbCategoriaDocente";
            this.cbCategoriaDocente.Size = new System.Drawing.Size(262, 26);
            this.cbCategoriaDocente.TabIndex = 33;
            // 
            // txbAsignatura
            // 
            this.txbAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAsignatura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAsignatura.Location = new System.Drawing.Point(807, 84);
            this.txbAsignatura.Name = "txbAsignatura";
            this.txbAsignatura.Size = new System.Drawing.Size(265, 26);
            this.txbAsignatura.TabIndex = 30;
            this.txbAsignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDocente
            // 
            this.txbDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDocente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDocente.Location = new System.Drawing.Point(807, 6);
            this.txbDocente.Name = "txbDocente";
            this.txbDocente.Size = new System.Drawing.Size(265, 26);
            this.txbDocente.TabIndex = 26;
            this.txbDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Docente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 205);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(262, 23);
            this.label21.TabIndex = 20;
            this.label21.Text = "Cant. horas académicas";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(539, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(262, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "Cantidad";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(262, 23);
            this.label17.TabIndex = 16;
            this.label17.Text = "Núcleo";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(539, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(262, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "Programa";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "Sección";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(539, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Asignatura";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Categoría del docente";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Clasificación";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Condición";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.I";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCedula
            // 
            this.txbCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedula.Location = new System.Drawing.Point(271, 6);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(262, 26);
            this.txbCedula.TabIndex = 25;
            this.txbCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCedula.TextChanged += new System.EventHandler(this.txbCedula_TextChanged);
            // 
            // cbCondicion
            // 
            this.cbCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCondicion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Location = new System.Drawing.Point(271, 45);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(262, 26);
            this.cbCondicion.TabIndex = 32;
            // 
            // gbTipoDeHora
            // 
            this.tlpFiltros.SetColumnSpan(this.gbTipoDeHora, 2);
            this.gbTipoDeHora.Controls.Add(this.rbtnLab);
            this.gbTipoDeHora.Controls.Add(this.rbtnPractica);
            this.gbTipoDeHora.Controls.Add(this.rbtnTeoria);
            this.gbTipoDeHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTipoDeHora.Location = new System.Drawing.Point(539, 198);
            this.gbTipoDeHora.Name = "gbTipoDeHora";
            this.gbTipoDeHora.Size = new System.Drawing.Size(533, 37);
            this.gbTipoDeHora.TabIndex = 38;
            this.gbTipoDeHora.TabStop = false;
            // 
            // rbtnLab
            // 
            this.rbtnLab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtnLab.AutoSize = true;
            this.rbtnLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLab.Location = new System.Drawing.Point(377, 11);
            this.rbtnLab.Name = "rbtnLab";
            this.rbtnLab.Size = new System.Drawing.Size(153, 22);
            this.rbtnLab.TabIndex = 2;
            this.rbtnLab.Text = "Tiene horas en lab";
            this.rbtnLab.UseVisualStyleBackColor = true;
            // 
            // rbtnPractica
            // 
            this.rbtnPractica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnPractica.AutoSize = true;
            this.rbtnPractica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPractica.Location = new System.Drawing.Point(180, 11);
            this.rbtnPractica.Name = "rbtnPractica";
            this.rbtnPractica.Size = new System.Drawing.Size(188, 22);
            this.rbtnPractica.TabIndex = 1;
            this.rbtnPractica.Text = "Tiene horas en práctica";
            this.rbtnPractica.UseVisualStyleBackColor = true;
            // 
            // rbtnTeoria
            // 
            this.rbtnTeoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnTeoria.AutoSize = true;
            this.rbtnTeoria.Checked = true;
            this.rbtnTeoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTeoria.Location = new System.Drawing.Point(6, 11);
            this.rbtnTeoria.Name = "rbtnTeoria";
            this.rbtnTeoria.Size = new System.Drawing.Size(171, 22);
            this.rbtnTeoria.TabIndex = 0;
            this.rbtnTeoria.TabStop = true;
            this.rbtnTeoria.Text = "Tiene horas en teoría";
            this.rbtnTeoria.UseVisualStyleBackColor = true;
            // 
            // mtxbCantidad
            // 
            this.mtxbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxbCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbCantidad.Location = new System.Drawing.Point(807, 162);
            this.mtxbCantidad.Mask = "99999";
            this.mtxbCantidad.Name = "mtxbCantidad";
            this.mtxbCantidad.Size = new System.Drawing.Size(265, 26);
            this.mtxbCantidad.TabIndex = 43;
            this.mtxbCantidad.ValidatingType = typeof(int);
            // 
            // dgvDataFiltrada
            // 
            this.dgvDataFiltrada.AllowUserToAddRows = false;
            this.dgvDataFiltrada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDataFiltrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataFiltrada.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataFiltrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataFiltrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataFiltrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataFiltrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataFiltrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataFiltrada.EnableHeadersVisualStyles = false;
            this.dgvDataFiltrada.Location = new System.Drawing.Point(16, 362);
            this.dgvDataFiltrada.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDataFiltrada.Name = "dgvDataFiltrada";
            this.dgvDataFiltrada.Size = new System.Drawing.Size(1075, 254);
            this.dgvDataFiltrada.TabIndex = 10;
            // 
            // tlpExportarYLimpiar
            // 
            this.tlpExportarYLimpiar.ColumnCount = 2;
            this.tlpExportarYLimpiar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExportarYLimpiar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExportarYLimpiar.Controls.Add(this.btnLimpiarTodo, 1, 0);
            this.tlpExportarYLimpiar.Controls.Add(this.btnExportarAExcel, 0, 0);
            this.tlpExportarYLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExportarYLimpiar.Location = new System.Drawing.Point(13, 625);
            this.tlpExportarYLimpiar.Name = "tlpExportarYLimpiar";
            this.tlpExportarYLimpiar.RowCount = 1;
            this.tlpExportarYLimpiar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExportarYLimpiar.Size = new System.Drawing.Size(1081, 56);
            this.tlpExportarYLimpiar.TabIndex = 11;
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarTodo.AutoSize = true;
            this.btnLimpiarTodo.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarTodo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarTodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTodo.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarTodo.Image = global::DocentesporPeriodos.Properties.Resources.data_cleaning;
            this.btnLimpiarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarTodo.Location = new System.Drawing.Point(715, 5);
            this.btnLimpiarTodo.Margin = new System.Windows.Forms.Padding(175, 3, 175, 3);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(191, 46);
            this.btnLimpiarTodo.TabIndex = 9;
            this.btnLimpiarTodo.Text = "Limpiar";
            this.btnLimpiarTodo.UseVisualStyleBackColor = false;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTabla_Click);
            // 
            // btnExportarAExcel
            // 
            this.btnExportarAExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarAExcel.AutoSize = true;
            this.btnExportarAExcel.BackColor = System.Drawing.Color.Green;
            this.btnExportarAExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportarAExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarAExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarAExcel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExportarAExcel.Image = global::DocentesporPeriodos.Properties.Resources.excel1;
            this.btnExportarAExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarAExcel.Location = new System.Drawing.Point(175, 5);
            this.btnExportarAExcel.Margin = new System.Windows.Forms.Padding(175, 3, 175, 3);
            this.btnExportarAExcel.Name = "btnExportarAExcel";
            this.btnExportarAExcel.Size = new System.Drawing.Size(190, 46);
            this.btnExportarAExcel.TabIndex = 8;
            this.btnExportarAExcel.Text = "Exportar";
            this.btnExportarAExcel.UseVisualStyleBackColor = false;
            this.btnExportarAExcel.Click += new System.EventHandler(this.btnExportarAExcel_Click);
            // 
            // etqRespuesta
            // 
            this.etqRespuesta.AutoSize = true;
            this.etqRespuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etqRespuesta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etqRespuesta.Location = new System.Drawing.Point(13, 318);
            this.etqRespuesta.Name = "etqRespuesta";
            this.etqRespuesta.Size = new System.Drawing.Size(1081, 38);
            this.etqRespuesta.TabIndex = 12;
            this.etqRespuesta.Text = "label2";
            this.etqRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etqRespuesta.Visible = false;
            // 
            // FormFiltrarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 694);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFiltrarDocente";
            this.Text = "FormFiltrarDocente";
            this.Load += new System.EventHandler(this.FormFiltrarDocente_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbFiltrosBusqueda.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.gbTipoDeHora.ResumeLayout(false);
            this.gbTipoDeHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFiltrada)).EndInit();
            this.tlpExportarYLimpiar.ResumeLayout(false);
            this.tlpExportarYLimpiar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbElegirPeriodo;
        private System.Windows.Forms.Button btnElegirPeriodo;
        private System.Windows.Forms.GroupBox gbFiltrosBusqueda;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.ComboBox cbCategoriaDocente;
        private System.Windows.Forms.TextBox txbAsignatura;
        private System.Windows.Forms.TextBox txbDocente;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.ComboBox cbNucleo;
        private System.Windows.Forms.ComboBox cbPrograma;
        private System.Windows.Forms.GroupBox gbTipoDeHora;
        private System.Windows.Forms.RadioButton rbtnLab;
        private System.Windows.Forms.RadioButton rbtnPractica;
        private System.Windows.Forms.RadioButton rbtnTeoria;
        private System.Windows.Forms.DataGridView dgvDataFiltrada;
        private System.Windows.Forms.TableLayoutPanel tlpExportarYLimpiar;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnExportarAExcel;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.MaskedTextBox mtxbCantidad;
        private System.Windows.Forms.MaskedTextBox mtxbHoras;
        private System.Windows.Forms.Label etqRespuesta;
    }
}