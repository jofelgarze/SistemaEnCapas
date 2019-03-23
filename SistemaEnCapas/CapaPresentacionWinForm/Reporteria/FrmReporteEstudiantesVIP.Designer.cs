namespace CapaPresentacionWinForm.Reporteria
{
    partial class FrmReporteEstudiantesVIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.tlyFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.flpBotonera = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.erpValidacionReporte = new System.Windows.Forms.ErrorProvider(this.components);
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.Panel2.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            this.tlyFormulario.SuspendLayout();
            this.flpBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidacionReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // spcPrincipal
            // 
            this.spcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.spcPrincipal.Name = "spcPrincipal";
            this.spcPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcPrincipal.Panel1
            // 
            this.spcPrincipal.Panel1.Controls.Add(this.tlyFormulario);
            // 
            // spcPrincipal.Panel2
            // 
            this.spcPrincipal.Panel2.Controls.Add(this.dgvReporte);
            this.spcPrincipal.Size = new System.Drawing.Size(424, 274);
            this.spcPrincipal.SplitterDistance = 97;
            this.spcPrincipal.TabIndex = 0;
            // 
            // tlyFormulario
            // 
            this.tlyFormulario.ColumnCount = 4;
            this.tlyFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlyFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlyFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlyFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlyFormulario.Controls.Add(this.lblSalarioMinimo, 1, 1);
            this.tlyFormulario.Controls.Add(this.txtSalarioMinimo, 2, 1);
            this.tlyFormulario.Controls.Add(this.flpBotonera, 0, 2);
            this.tlyFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyFormulario.Location = new System.Drawing.Point(0, 0);
            this.tlyFormulario.Name = "tlyFormulario";
            this.tlyFormulario.RowCount = 4;
            this.tlyFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlyFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlyFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlyFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlyFormulario.Size = new System.Drawing.Size(424, 97);
            this.tlyFormulario.TabIndex = 0;
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Location = new System.Drawing.Point(69, 18);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(75, 13);
            this.lblSalarioMinimo.TabIndex = 0;
            this.lblSalarioMinimo.Text = "Salario Minimo";
            this.lblSalarioMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSalarioMinimo.Location = new System.Drawing.Point(150, 21);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(204, 20);
            this.txtSalarioMinimo.TabIndex = 1;
            // 
            // flpBotonera
            // 
            this.tlyFormulario.SetColumnSpan(this.flpBotonera, 4);
            this.flpBotonera.Controls.Add(this.btnCancelar);
            this.flpBotonera.Controls.Add(this.btnExportar);
            this.flpBotonera.Controls.Add(this.btnConsultar);
            this.flpBotonera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonera.Location = new System.Drawing.Point(3, 47);
            this.flpBotonera.Name = "flpBotonera";
            this.flpBotonera.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpBotonera.Size = new System.Drawing.Size(418, 29);
            this.flpBotonera.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(340, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExportar.Location = new System.Drawing.Point(259, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(178, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombreCompleto,
            this.colSalario});
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.Location = new System.Drawing.Point(0, 0);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.Size = new System.Drawing.Size(424, 173);
            this.dgvReporte.TabIndex = 0;
            // 
            // erpValidacionReporte
            // 
            this.erpValidacionReporte.ContainerControl = this;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Visible = false;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreCompleto.DataPropertyName = "NombreCompleto";
            this.colNombreCompleto.HeaderText = "Nombre";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.ReadOnly = true;
            // 
            // colSalario
            // 
            this.colSalario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSalario.DataPropertyName = "Salario";
            this.colSalario.HeaderText = "Salario";
            this.colSalario.Name = "colSalario";
            this.colSalario.ReadOnly = true;
            this.colSalario.Width = 64;
            // 
            // FrmReporteEstudiantesVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 274);
            this.Controls.Add(this.spcPrincipal);
            this.Name = "FrmReporteEstudiantesVIP";
            this.Text = "Reporte Estudiantes VIP";
            this.spcPrincipal.Panel1.ResumeLayout(false);
            this.spcPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            this.tlyFormulario.ResumeLayout(false);
            this.tlyFormulario.PerformLayout();
            this.flpBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidacionReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcPrincipal;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.TableLayoutPanel tlyFormulario;
        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.FlowLayoutPanel flpBotonera;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ErrorProvider erpValidacionReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalario;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
    }
}