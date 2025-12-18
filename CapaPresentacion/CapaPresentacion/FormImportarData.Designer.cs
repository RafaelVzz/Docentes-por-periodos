namespace CapaPresentacion {
    partial class FormImportarData {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportarData));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPeriodo = new System.Windows.Forms.TableLayoutPanel();
            this.txbPeriodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportarData = new System.Windows.Forms.Button();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.etqRespuesta = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.tlpPeriodo.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpPeriodo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 0, 1);
            this.tlpPrincipal.Controls.Add(this.panelTabla, 0, 3);
            this.tlpPrincipal.Controls.Add(this.etqRespuesta, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.873491F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.19632F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.06135F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1107, 694);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpPeriodo
            // 
            this.tlpPeriodo.ColumnCount = 2;
            this.tlpPeriodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81055F));
            this.tlpPeriodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.18945F));
            this.tlpPeriodo.Controls.Add(this.txbPeriodo, 1, 0);
            this.tlpPeriodo.Controls.Add(this.label1, 0, 0);
            this.tlpPeriodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPeriodo.Location = new System.Drawing.Point(13, 13);
            this.tlpPeriodo.Name = "tlpPeriodo";
            this.tlpPeriodo.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPeriodo.RowCount = 1;
            this.tlpPeriodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPeriodo.Size = new System.Drawing.Size(1081, 51);
            this.tlpPeriodo.TabIndex = 0;
            // 
            // txbPeriodo
            // 
            this.txbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPeriodo.BackColor = System.Drawing.SystemColors.Window;
            this.txbPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPeriodo.Location = new System.Drawing.Point(445, 13);
            this.txbPeriodo.Margin = new System.Windows.Forms.Padding(3, 3, 250, 3);
            this.txbPeriodo.Name = "txbPeriodo";
            this.txbPeriodo.Size = new System.Drawing.Size(376, 26);
            this.txbPeriodo.TabIndex = 0;
            this.txbPeriodo.TextChanged += new System.EventHandler(this.txbPeriodo_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el período de la tabla (ej: I-2025):";
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnImportarData, 1, 0);
            this.tlpBotones.Controls.Add(this.btnCargarArchivo, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(13, 70);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.Padding = new System.Windows.Forms.Padding(10);
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(1081, 66);
            this.tlpBotones.TabIndex = 1;
            // 
            // btnImportarData
            // 
            this.btnImportarData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarData.AutoSize = true;
            this.btnImportarData.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarData.FlatAppearance.BorderSize = 0;
            this.btnImportarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarData.Image = global::DocentesporPeriodos.Properties.Resources.database;
            this.btnImportarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarData.Location = new System.Drawing.Point(690, 13);
            this.btnImportarData.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.btnImportarData.Name = "btnImportarData";
            this.btnImportarData.Size = new System.Drawing.Size(231, 40);
            this.btnImportarData.TabIndex = 2;
            this.btnImportarData.Text = "Importar data";
            this.btnImportarData.UseVisualStyleBackColor = false;
            this.btnImportarData.Click += new System.EventHandler(this.btnImportarData_Click);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarArchivo.AutoSize = true;
            this.btnCargarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.Image = global::DocentesporPeriodos.Properties.Resources.excel;
            this.btnCargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarArchivo.Location = new System.Drawing.Point(160, 14);
            this.btnCargarArchivo.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(230, 38);
            this.btnCargarArchivo.TabIndex = 1;
            this.btnCargarArchivo.Text = "Cargar archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // panelTabla
            // 
            this.panelTabla.AutoScroll = true;
            this.panelTabla.Controls.Add(this.dgvData);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(13, 164);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Padding = new System.Windows.Forms.Padding(10);
            this.panelTabla.Size = new System.Drawing.Size(1081, 517);
            this.panelTabla.TabIndex = 2;
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(10, 10);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(1061, 497);
            this.dgvData.TabIndex = 1;
            // 
            // etqRespuesta
            // 
            this.etqRespuesta.AutoSize = true;
            this.etqRespuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etqRespuesta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etqRespuesta.Location = new System.Drawing.Point(13, 139);
            this.etqRespuesta.Name = "etqRespuesta";
            this.etqRespuesta.Size = new System.Drawing.Size(1081, 22);
            this.etqRespuesta.TabIndex = 3;
            this.etqRespuesta.Text = "label2";
            this.etqRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etqRespuesta.Visible = false;
            // 
            // FormImportarData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 694);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportarData";
            this.Text = "FormImportarData";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpPeriodo.ResumeLayout(false);
            this.tlpPeriodo.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tlpBotones.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnImportarData;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txbPeriodo;
        private System.Windows.Forms.Label etqRespuesta;
    }
}