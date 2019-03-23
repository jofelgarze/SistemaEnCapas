namespace CapaPresentacionWinForm
{
    partial class FrmPrincipal
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
            this.mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.optEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReporteria = new System.Windows.Forms.ToolStripMenuItem();
            this.optEstudiantesVIP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMantenimiento,
            this.mniReporteria});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(586, 24);
            this.mnsMenuPrincipal.TabIndex = 3;
            this.mnsMenuPrincipal.Text = "menuStrip1";
            // 
            // mniMantenimiento
            // 
            this.mniMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optEstudiantes});
            this.mniMantenimiento.Name = "mniMantenimiento";
            this.mniMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.mniMantenimiento.Text = "&Mantenimiento";
            // 
            // optEstudiantes
            // 
            this.optEstudiantes.Name = "optEstudiantes";
            this.optEstudiantes.Size = new System.Drawing.Size(180, 22);
            this.optEstudiantes.Text = "&Estudiantes";
            this.optEstudiantes.Click += new System.EventHandler(this.optEstudiantes_Click);
            // 
            // mniReporteria
            // 
            this.mniReporteria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optEstudiantesVIP});
            this.mniReporteria.Name = "mniReporteria";
            this.mniReporteria.Size = new System.Drawing.Size(73, 20);
            this.mniReporteria.Text = "Reporteria";
            // 
            // optEstudiantesVIP
            // 
            this.optEstudiantesVIP.Name = "optEstudiantesVIP";
            this.optEstudiantesVIP.Size = new System.Drawing.Size(180, 22);
            this.optEstudiantesVIP.Text = "Estudiantes VIP";
            this.optEstudiantesVIP.Click += new System.EventHandler(this.optEstudiantesVIP_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Academico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.mnsMenuPrincipal.ResumeLayout(false);
            this.mnsMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem optEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem mniReporteria;
        private System.Windows.Forms.ToolStripMenuItem optEstudiantesVIP;
    }
}