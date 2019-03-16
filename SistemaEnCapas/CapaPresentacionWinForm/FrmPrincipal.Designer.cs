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
            this.mnsMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMantenimiento});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(782, 28);
            this.mnsMenuPrincipal.TabIndex = 3;
            this.mnsMenuPrincipal.Text = "menuStrip1";
            // 
            // mniMantenimiento
            // 
            this.mniMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optEstudiantes});
            this.mniMantenimiento.Name = "mniMantenimiento";
            this.mniMantenimiento.Size = new System.Drawing.Size(122, 24);
            this.mniMantenimiento.Text = "&Mantenimiento";
            // 
            // optEstudiantes
            // 
            this.optEstudiantes.Name = "optEstudiantes";
            this.optEstudiantes.Size = new System.Drawing.Size(216, 26);
            this.optEstudiantes.Text = "&Estudiantes";
            this.optEstudiantes.Click += new System.EventHandler(this.optEstudiantes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenuPrincipal;
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
    }
}