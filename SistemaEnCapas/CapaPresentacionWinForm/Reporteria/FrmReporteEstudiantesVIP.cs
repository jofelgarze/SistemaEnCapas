using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionWinForm.Reporteria
{
    public partial class FrmReporteEstudiantesVIP : Form
    {
        private ReporteEstudiantesService.IReporteEstudiantesService reporteEstudiantesService;

        public decimal SalarioMinimo {
            set {
                txtSalarioMinimo.Text = Convert.ToString(value); 
            }
        }

        public int CodigoSeleccionado
        {
            get
            {
                if (dgvReporte.SelectedRows.Count > 0)
                {
                    var est = dgvReporte.SelectedRows[0].DataBoundItem as
                        ReporteEstudiantesService.EstudianteVIP;
                    return est.Codigo;
                }
                return 0;
            }
        }

        public FrmReporteEstudiantesVIP()
        {
            InitializeComponent();
        }

        private bool ValidarFormularioOK<T>(IEnumerable<T> campos) {

            bool hayErrores = false;

            decimal salario;

            if (!decimal.TryParse(txtSalarioMinimo.Text, out salario))
            {
                erpValidacionReporte.SetError(txtSalarioMinimo, "Debe ser un numero decimal valido");
                hayErrores = true;
            }

            foreach (var inputText in campos)
            {
                if (inputText is TextBox)
                {
                    //Si es un textbox validar que no este vacio
                    if (string.IsNullOrWhiteSpace((inputText as TextBox).Text))
                    {
                        erpValidacionReporte.SetError((inputText as Control), "El campo es obligatorio");
                        hayErrores = true;
                    }
                }
                if (inputText is ComboBox) {
                    //Si es un combo validar que teng una opcion marcada
                    if ((inputText as ComboBox).SelectedValue != null)
                    {
                        erpValidacionReporte.SetError((inputText as Control), "Debe seleccionar una opcion");
                        hayErrores = true;
                    }
                }
            }

            if (!hayErrores)
            {
                erpValidacionReporte.Clear();
            }

            return !hayErrores;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var campos = tlyFormulario.Controls.OfType<TextBox>();

            if (ValidarFormularioOK(campos))
            {                
                reporteEstudiantesService = new ReporteEstudiantesService.ReporteEstudiantesServiceClient();
                dgvReporte.AutoGenerateColumns = false;
                dgvReporte.DataSource = reporteEstudiantesService.EstudiantesSalarioVIP(Convert.ToDecimal(txtSalarioMinimo.Text));
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MessageBox.Show(
                "Saliste de la ventana",                
                "Informacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                "No se ha implementado aun," 
                + " puedes usar EPPLUS o el Motor de Excel", 
                "No disponible", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning);
        }
    }
}
