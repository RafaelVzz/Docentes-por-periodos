namespace CapaPresentacion {
    partial class FormularioContenedor {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioContenedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.ttFormularioPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.panelModeloDocentes = new System.Windows.Forms.Panel();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnFiltrarDocentes = new System.Windows.Forms.Button();
            this.panelModeloInformes = new System.Windows.Forms.Panel();
            this.pnlBotonesDinamicosExportaciones = new System.Windows.Forms.Panel();
            this.btnAbrirPanelExportacionesDeData = new System.Windows.Forms.Button();
            this.pnlBotonesDinamicosImportaciones = new System.Windows.Forms.Panel();
            this.btnAbrirPanelBotonesDinamicosImportaciones = new System.Windows.Forms.Button();
            this.panelModeloData = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnImportarNuevaData = new System.Windows.Forms.Button();
            this.btnDesplegarOpcionesData = new System.Windows.Forms.Button();
            this.btnDesplegarInformes = new System.Windows.Forms.Button();
            this.btnDesplegarOpcionesDocente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.btnVentanaNormal = new System.Windows.Forms.Button();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelModeloDocentes.SuspendLayout();
            this.panelModeloInformes.SuspendLayout();
            this.panelModeloData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.btnMinimizarVentana);
            this.panel1.Controls.Add(this.btnVentanaNormal);
            this.panel1.Controls.Add(this.btnCerrarVentana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 38);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(248, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1138, 694);
            this.panelContenedor.TabIndex = 2;
            // 
            // panelModeloDocentes
            // 
            this.panelModeloDocentes.BackColor = System.Drawing.Color.White;
            this.panelModeloDocentes.Controls.Add(this.btnModificarDocente);
            this.panelModeloDocentes.Controls.Add(this.btnFiltrarDocentes);
            this.panelModeloDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModeloDocentes.Location = new System.Drawing.Point(0, 285);
            this.panelModeloDocentes.Name = "panelModeloDocentes";
            this.panelModeloDocentes.Size = new System.Drawing.Size(248, 55);
            this.panelModeloDocentes.TabIndex = 2;
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.AutoSize = true;
            this.btnModificarDocente.BackColor = System.Drawing.Color.White;
            this.btnModificarDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarDocente.FlatAppearance.BorderSize = 0;
            this.btnModificarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDocente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(0, 27);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(248, 27);
            this.btnModificarDocente.TabIndex = 3;
            this.btnModificarDocente.Text = "Modificar docente";
            this.btnModificarDocente.UseVisualStyleBackColor = false;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            this.btnModificarDocente.MouseEnter += new System.EventHandler(this.btnModificarDocente_MouseEnter);
            this.btnModificarDocente.MouseLeave += new System.EventHandler(this.btnModificarDocente_MouseLeave);
            // 
            // btnFiltrarDocentes
            // 
            this.btnFiltrarDocentes.AutoSize = true;
            this.btnFiltrarDocentes.BackColor = System.Drawing.Color.White;
            this.btnFiltrarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltrarDocentes.FlatAppearance.BorderSize = 0;
            this.btnFiltrarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarDocentes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarDocentes.Location = new System.Drawing.Point(0, 0);
            this.btnFiltrarDocentes.Name = "btnFiltrarDocentes";
            this.btnFiltrarDocentes.Size = new System.Drawing.Size(248, 27);
            this.btnFiltrarDocentes.TabIndex = 2;
            this.btnFiltrarDocentes.Text = "Filtrar docentes";
            this.btnFiltrarDocentes.UseVisualStyleBackColor = false;
            this.btnFiltrarDocentes.Click += new System.EventHandler(this.btnFiltrarDocentes_Click);
            this.btnFiltrarDocentes.MouseEnter += new System.EventHandler(this.btnFiltrarDocentes_MouseEnter);
            this.btnFiltrarDocentes.MouseLeave += new System.EventHandler(this.btnFiltrarDocentes_MouseLeave);
            // 
            // panelModeloInformes
            // 
            this.panelModeloInformes.AutoScroll = true;
            this.panelModeloInformes.Controls.Add(this.pnlBotonesDinamicosExportaciones);
            this.panelModeloInformes.Controls.Add(this.btnAbrirPanelExportacionesDeData);
            this.panelModeloInformes.Controls.Add(this.pnlBotonesDinamicosImportaciones);
            this.panelModeloInformes.Controls.Add(this.btnAbrirPanelBotonesDinamicosImportaciones);
            this.panelModeloInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModeloInformes.Location = new System.Drawing.Point(0, 402);
            this.panelModeloInformes.Name = "panelModeloInformes";
            this.panelModeloInformes.Size = new System.Drawing.Size(248, 67);
            this.panelModeloInformes.TabIndex = 2;
            // 
            // pnlBotonesDinamicosExportaciones
            // 
            this.pnlBotonesDinamicosExportaciones.AutoScroll = true;
            this.pnlBotonesDinamicosExportaciones.AutoSize = true;
            this.pnlBotonesDinamicosExportaciones.BackColor = System.Drawing.Color.White;
            this.pnlBotonesDinamicosExportaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotonesDinamicosExportaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotonesDinamicosExportaciones.Location = new System.Drawing.Point(0, 67);
            this.pnlBotonesDinamicosExportaciones.Name = "pnlBotonesDinamicosExportaciones";
            this.pnlBotonesDinamicosExportaciones.Size = new System.Drawing.Size(231, 2);
            this.pnlBotonesDinamicosExportaciones.TabIndex = 6;
            this.pnlBotonesDinamicosExportaciones.Visible = false;
            // 
            // btnAbrirPanelExportacionesDeData
            // 
            this.btnAbrirPanelExportacionesDeData.AutoSize = true;
            this.btnAbrirPanelExportacionesDeData.BackColor = System.Drawing.Color.White;
            this.btnAbrirPanelExportacionesDeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirPanelExportacionesDeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPanelExportacionesDeData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPanelExportacionesDeData.Location = new System.Drawing.Point(0, 34);
            this.btnAbrirPanelExportacionesDeData.Name = "btnAbrirPanelExportacionesDeData";
            this.btnAbrirPanelExportacionesDeData.Size = new System.Drawing.Size(231, 33);
            this.btnAbrirPanelExportacionesDeData.TabIndex = 5;
            this.btnAbrirPanelExportacionesDeData.Text = "Exportaciones de data";
            this.btnAbrirPanelExportacionesDeData.UseVisualStyleBackColor = false;
            this.btnAbrirPanelExportacionesDeData.Click += new System.EventHandler(this.btnAbrirPanelExportacionesDeData_Click);
            this.btnAbrirPanelExportacionesDeData.MouseEnter += new System.EventHandler(this.btnAbrirPanelExportacionesDeData_MouseEnter);
            this.btnAbrirPanelExportacionesDeData.MouseLeave += new System.EventHandler(this.btnAbrirPanelExportacionesDeData_MouseLeave);
            // 
            // pnlBotonesDinamicosImportaciones
            // 
            this.pnlBotonesDinamicosImportaciones.AutoScroll = true;
            this.pnlBotonesDinamicosImportaciones.AutoSize = true;
            this.pnlBotonesDinamicosImportaciones.BackColor = System.Drawing.Color.White;
            this.pnlBotonesDinamicosImportaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotonesDinamicosImportaciones.Location = new System.Drawing.Point(0, 34);
            this.pnlBotonesDinamicosImportaciones.Name = "pnlBotonesDinamicosImportaciones";
            this.pnlBotonesDinamicosImportaciones.Size = new System.Drawing.Size(231, 0);
            this.pnlBotonesDinamicosImportaciones.TabIndex = 4;
            this.pnlBotonesDinamicosImportaciones.Visible = false;
            // 
            // btnAbrirPanelBotonesDinamicosImportaciones
            // 
            this.btnAbrirPanelBotonesDinamicosImportaciones.AutoSize = true;
            this.btnAbrirPanelBotonesDinamicosImportaciones.BackColor = System.Drawing.Color.White;
            this.btnAbrirPanelBotonesDinamicosImportaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirPanelBotonesDinamicosImportaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPanelBotonesDinamicosImportaciones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPanelBotonesDinamicosImportaciones.Location = new System.Drawing.Point(0, 0);
            this.btnAbrirPanelBotonesDinamicosImportaciones.Name = "btnAbrirPanelBotonesDinamicosImportaciones";
            this.btnAbrirPanelBotonesDinamicosImportaciones.Size = new System.Drawing.Size(231, 34);
            this.btnAbrirPanelBotonesDinamicosImportaciones.TabIndex = 3;
            this.btnAbrirPanelBotonesDinamicosImportaciones.Text = "Importaciones de data";
            this.btnAbrirPanelBotonesDinamicosImportaciones.UseVisualStyleBackColor = false;
            this.btnAbrirPanelBotonesDinamicosImportaciones.Click += new System.EventHandler(this.btnAbrirPanelBotonesDinamicosImportaciones_Click);
            this.btnAbrirPanelBotonesDinamicosImportaciones.MouseEnter += new System.EventHandler(this.btnAbrirPanelBotonesDinamicosImportaciones_MouseEnter);
            this.btnAbrirPanelBotonesDinamicosImportaciones.MouseLeave += new System.EventHandler(this.btnAbrirPanelBotonesDinamicosImportaciones_MouseLeave);
            // 
            // panelModeloData
            // 
            this.panelModeloData.BackColor = System.Drawing.Color.White;
            this.panelModeloData.Controls.Add(this.btnImportarNuevaData);
            this.panelModeloData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModeloData.Location = new System.Drawing.Point(0, 531);
            this.panelModeloData.Name = "panelModeloData";
            this.panelModeloData.Size = new System.Drawing.Size(248, 57);
            this.panelModeloData.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.btnAcercaDe);
            this.panel2.Controls.Add(this.panelModeloData);
            this.panel2.Controls.Add(this.btnDesplegarOpcionesData);
            this.panel2.Controls.Add(this.panelModeloInformes);
            this.panel2.Controls.Add(this.btnDesplegarInformes);
            this.panel2.Controls.Add(this.panelModeloDocentes);
            this.panel2.Controls.Add(this.btnDesplegarOpcionesDocente);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 694);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 51);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCENTES POR PERIODO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 172);
            this.panel3.TabIndex = 2;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AutoSize = true;
            this.btnAcercaDe.BackColor = System.Drawing.Color.White;
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.Black;
            this.btnAcercaDe.Image = global::DocentesporPeriodos.Properties.Resources.informacion;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 588);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(10);
            this.btnAcercaDe.Size = new System.Drawing.Size(248, 62);
            this.btnAcercaDe.TabIndex = 5;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            this.btnAcercaDe.MouseEnter += new System.EventHandler(this.btnAcercaDe_MouseEnter);
            this.btnAcercaDe.MouseLeave += new System.EventHandler(this.btnAcercaDe_MouseLeave);
            // 
            // btnImportarNuevaData
            // 
            this.btnImportarNuevaData.AutoSize = true;
            this.btnImportarNuevaData.BackColor = System.Drawing.Color.White;
            this.btnImportarNuevaData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportarNuevaData.FlatAppearance.BorderSize = 0;
            this.btnImportarNuevaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarNuevaData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarNuevaData.Image = global::DocentesporPeriodos.Properties.Resources.icono_excel;
            this.btnImportarNuevaData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportarNuevaData.Location = new System.Drawing.Point(0, 0);
            this.btnImportarNuevaData.Name = "btnImportarNuevaData";
            this.btnImportarNuevaData.Size = new System.Drawing.Size(248, 59);
            this.btnImportarNuevaData.TabIndex = 3;
            this.btnImportarNuevaData.Text = "Ver y generar nueva tabla";
            this.btnImportarNuevaData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportarNuevaData.UseVisualStyleBackColor = false;
            this.btnImportarNuevaData.Click += new System.EventHandler(this.btnImportarNuevaData_Click);
            this.btnImportarNuevaData.MouseEnter += new System.EventHandler(this.btnImportarNuevaData_MouseEnter);
            this.btnImportarNuevaData.MouseLeave += new System.EventHandler(this.btnImportarNuevaData_MouseLeave);
            // 
            // btnDesplegarOpcionesData
            // 
            this.btnDesplegarOpcionesData.AutoSize = true;
            this.btnDesplegarOpcionesData.BackColor = System.Drawing.Color.White;
            this.btnDesplegarOpcionesData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesplegarOpcionesData.FlatAppearance.BorderSize = 0;
            this.btnDesplegarOpcionesData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegarOpcionesData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarOpcionesData.ForeColor = System.Drawing.Color.Black;
            this.btnDesplegarOpcionesData.Image = global::DocentesporPeriodos.Properties.Resources.importar;
            this.btnDesplegarOpcionesData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegarOpcionesData.Location = new System.Drawing.Point(0, 469);
            this.btnDesplegarOpcionesData.Name = "btnDesplegarOpcionesData";
            this.btnDesplegarOpcionesData.Padding = new System.Windows.Forms.Padding(6, 10, 10, 10);
            this.btnDesplegarOpcionesData.Size = new System.Drawing.Size(248, 62);
            this.btnDesplegarOpcionesData.TabIndex = 4;
            this.btnDesplegarOpcionesData.Text = "       Importar data";
            this.btnDesplegarOpcionesData.UseVisualStyleBackColor = false;
            this.btnDesplegarOpcionesData.Click += new System.EventHandler(this.btnDesplegarOpcionesData_Click);
            this.btnDesplegarOpcionesData.MouseEnter += new System.EventHandler(this.btnDesplegarOpcionesData_MouseEnter);
            this.btnDesplegarOpcionesData.MouseLeave += new System.EventHandler(this.btnDesplegarOpcionesData_MouseLeave);
            // 
            // btnDesplegarInformes
            // 
            this.btnDesplegarInformes.AutoSize = true;
            this.btnDesplegarInformes.BackColor = System.Drawing.Color.White;
            this.btnDesplegarInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesplegarInformes.FlatAppearance.BorderSize = 0;
            this.btnDesplegarInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegarInformes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarInformes.ForeColor = System.Drawing.Color.Black;
            this.btnDesplegarInformes.Image = global::DocentesporPeriodos.Properties.Resources.informe_seo;
            this.btnDesplegarInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegarInformes.Location = new System.Drawing.Point(0, 340);
            this.btnDesplegarInformes.Name = "btnDesplegarInformes";
            this.btnDesplegarInformes.Padding = new System.Windows.Forms.Padding(10);
            this.btnDesplegarInformes.Size = new System.Drawing.Size(248, 62);
            this.btnDesplegarInformes.TabIndex = 3;
            this.btnDesplegarInformes.Text = "Informes";
            this.btnDesplegarInformes.UseVisualStyleBackColor = false;
            this.btnDesplegarInformes.Click += new System.EventHandler(this.btnDesplegarInformes_Click);
            this.btnDesplegarInformes.MouseEnter += new System.EventHandler(this.btnDesplegarInformes_MouseEnter);
            this.btnDesplegarInformes.MouseLeave += new System.EventHandler(this.btnDesplegarInformes_MouseLeave);
            // 
            // btnDesplegarOpcionesDocente
            // 
            this.btnDesplegarOpcionesDocente.AutoSize = true;
            this.btnDesplegarOpcionesDocente.BackColor = System.Drawing.Color.White;
            this.btnDesplegarOpcionesDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesplegarOpcionesDocente.FlatAppearance.BorderSize = 0;
            this.btnDesplegarOpcionesDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegarOpcionesDocente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarOpcionesDocente.ForeColor = System.Drawing.Color.Black;
            this.btnDesplegarOpcionesDocente.Image = global::DocentesporPeriodos.Properties.Resources.profesor__1_;
            this.btnDesplegarOpcionesDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegarOpcionesDocente.Location = new System.Drawing.Point(0, 223);
            this.btnDesplegarOpcionesDocente.Name = "btnDesplegarOpcionesDocente";
            this.btnDesplegarOpcionesDocente.Padding = new System.Windows.Forms.Padding(10);
            this.btnDesplegarOpcionesDocente.Size = new System.Drawing.Size(248, 62);
            this.btnDesplegarOpcionesDocente.TabIndex = 2;
            this.btnDesplegarOpcionesDocente.Text = "Docentes";
            this.btnDesplegarOpcionesDocente.UseVisualStyleBackColor = false;
            this.btnDesplegarOpcionesDocente.Click += new System.EventHandler(this.btnDesplegarOpcionesDocente_Click);
            this.btnDesplegarOpcionesDocente.MouseEnter += new System.EventHandler(this.btnDesplegarOpcionesDocente_MouseEnter);
            this.btnDesplegarOpcionesDocente.MouseLeave += new System.EventHandler(this.btnDesplegarOpcionesDocente_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.pictureBox1.Image = global::DocentesporPeriodos.Properties.Resources.carga_de_datos__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = global::DocentesporPeriodos.Properties.Resources.minus;
            this.btnMinimizarVentana.Location = new System.Drawing.Point(1223, 0);
            this.btnMinimizarVentana.Name = "btnMinimizarVentana";
            this.btnMinimizarVentana.Size = new System.Drawing.Size(53, 38);
            this.btnMinimizarVentana.TabIndex = 2;
            this.btnMinimizarVentana.UseVisualStyleBackColor = true;
            this.btnMinimizarVentana.Click += new System.EventHandler(this.btnMinimizarVentana_Click);
            // 
            // btnVentanaNormal
            // 
            this.btnVentanaNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVentanaNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVentanaNormal.FlatAppearance.BorderSize = 0;
            this.btnVentanaNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanaNormal.Image = global::DocentesporPeriodos.Properties.Resources.maximize;
            this.btnVentanaNormal.Location = new System.Drawing.Point(1276, 0);
            this.btnVentanaNormal.Name = "btnVentanaNormal";
            this.btnVentanaNormal.Size = new System.Drawing.Size(61, 38);
            this.btnVentanaNormal.TabIndex = 3;
            this.btnVentanaNormal.UseVisualStyleBackColor = true;
            this.btnVentanaNormal.Click += new System.EventHandler(this.btnVentanaNormal_Click);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Image = global::DocentesporPeriodos.Properties.Resources.close__1_;
            this.btnCerrarVentana.Location = new System.Drawing.Point(1337, 0);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(49, 38);
            this.btnCerrarVentana.TabIndex = 1;
            this.btnCerrarVentana.UseVisualStyleBackColor = true;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // FormularioContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 732);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioContenedor";
            this.panel1.ResumeLayout(false);
            this.panelModeloDocentes.ResumeLayout(false);
            this.panelModeloDocentes.PerformLayout();
            this.panelModeloInformes.ResumeLayout(false);
            this.panelModeloInformes.PerformLayout();
            this.panelModeloData.ResumeLayout(false);
            this.panelModeloData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Button btnVentanaNormal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolTip ttFormularioPrincipal;
        private System.Windows.Forms.Button btnDesplegarOpcionesDocente;
        private System.Windows.Forms.Panel panelModeloDocentes;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnFiltrarDocentes;
        private System.Windows.Forms.Button btnDesplegarInformes;
        private System.Windows.Forms.Panel panelModeloInformes;
        private System.Windows.Forms.Panel pnlBotonesDinamicosExportaciones;
        private System.Windows.Forms.Button btnAbrirPanelExportacionesDeData;
        private System.Windows.Forms.Panel pnlBotonesDinamicosImportaciones;
        private System.Windows.Forms.Button btnAbrirPanelBotonesDinamicosImportaciones;
        private System.Windows.Forms.Button btnDesplegarOpcionesData;
        private System.Windows.Forms.Panel panelModeloData;
        private System.Windows.Forms.Button btnImportarNuevaData;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}