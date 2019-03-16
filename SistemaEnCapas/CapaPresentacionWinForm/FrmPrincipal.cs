using CapaAccesoDatos.Entidades;
using CapaPresentacionWinForm.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionWinForm
{
    public partial class FrmPrincipal : Form
    {
        private ModeloDbEscuela contexto;

        public FrmPrincipal()
        {
            InitializeComponent();
            contexto = new ModeloDbEscuela();
        }

        public DbContext ContextoDB {
            get {
                return contexto;
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            contexto.Dispose();
        }

        private void optEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiante frm = new FrmEstudiante();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
