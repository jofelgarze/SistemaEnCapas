using CapaAccesoDatos.Entidades;
using CapaPresentacionWinForm.Reporteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionWinForm.Mantenimiento
{
    public partial class FrmEstudiante : Form
    {
        private ModeloDbEscuela contexto;
        BindingSource source = new BindingSource();
        private Estudiante estudianteSeleccionado;

        private bool flagCargando = true;

        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void Limpiar() {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            chkActivo.Checked = false;
            txtAltura.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbGenero.SelectedValue = "F";
            txtSalario.Text = "";
            estudianteSeleccionado = null;
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            contexto = ((FrmPrincipal)this.MdiParent).ContextoDB as ModeloDbEscuela;
            
            var generos = new List<Catalogo>() {
                new Catalogo{
                    Valor = "F",
                    Descripcion = "Femenino"
                },
                new Catalogo{
                    Valor = "M",
                    Descripcion = "Masculino"
                }
            };
            
            cmbGenero.DataSource = generos;
            cmbGenero.DisplayMember = "Descripcion";
            cmbGenero.ValueMember = "Valor";

            source.DataSource = contexto.Estudiante.ToList();
            dgvEstudiantes.AutoGenerateColumns = false;
            dgvEstudiantes.DataSource = source;
            flagCargando = false;

            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                estudianteSeleccionado = new Estudiante();

                estudianteSeleccionado.Nombres = txtNombres.Text;
                estudianteSeleccionado.Apellidos = txtApellidos.Text;
                estudianteSeleccionado.Activo = chkActivo.Checked;
                estudianteSeleccionado.Altura = Convert.ToDouble(txtAltura.Text);
                estudianteSeleccionado.FechaNacimiento = dtpFechaNacimiento.Value;
                estudianteSeleccionado.Genero = Convert.ToString(cmbGenero.SelectedValue);
                estudianteSeleccionado.Salario = Convert.ToDecimal(txtSalario.Text);
                
                contexto.Estudiante.Add(estudianteSeleccionado);
                txtCodigo.Text = Convert.ToString(estudianteSeleccionado.Id);
                source.Add(estudianteSeleccionado);
            }
            else {

                estudianteSeleccionado.Nombres = txtNombres.Text;
                estudianteSeleccionado.Apellidos = txtApellidos.Text;
                estudianteSeleccionado.Activo = chkActivo.Checked;
                estudianteSeleccionado.Altura = Convert.ToDouble(txtAltura.Text);
                estudianteSeleccionado.FechaNacimiento = dtpFechaNacimiento.Value;
                estudianteSeleccionado.Genero = Convert.ToString(cmbGenero.SelectedValue);
                estudianteSeleccionado.Salario = Convert.ToDecimal(txtSalario.Text);
                
            }

            contexto.SaveChanges();
            
            source.ResetBindings(false);
        }

        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvEstudiantes.SelectedRows.Count > 0 && !flagCargando)
            //{
            //    int codigo = Convert.ToInt32(dgvEstudiantes
            //        .SelectedRows[0].Cells[0].Value);

            //    estudianteSeleccionado = estudiantes.Where(est => est.Id == codigo).Single();

            //    txtCodigo.Text = Convert.ToString(estudianteSeleccionado.Id);
            //    txtNombres.Text = estudianteSeleccionado.Nombres;
            //    txtApellidos.Text = estudianteSeleccionado.Apellidos;
            //    chkActivo.Checked = estudianteSeleccionado.Activo;
            //    txtAltura.Text = Convert.ToString(estudianteSeleccionado.Altura);
            //    dtpFechaNacimiento.Value = estudianteSeleccionado.FechaNacimiento;
            //    cmbGenero.SelectedValue = estudianteSeleccionado.Genero;
            //    txtSalario.Text = Convert.ToString(estudianteSeleccionado.Salario);


            //}
            if (dgvEstudiantes.SelectedRows.Count > 0 && !flagCargando)
                foreach (DataGridViewRow row in this.dgvEstudiantes.SelectedRows)
                {
                    estudianteSeleccionado = row.DataBoundItem as Estudiante;
                    if (estudianteSeleccionado != null)
                    {
                        txtCodigo.Text = Convert.ToString(estudianteSeleccionado.Id);
                        txtNombres.Text = estudianteSeleccionado.Nombres;
                        txtApellidos.Text = estudianteSeleccionado.Apellidos;
                        chkActivo.Checked = estudianteSeleccionado.Activo;
                        txtAltura.Text = Convert.ToString(estudianteSeleccionado.Altura);
                        dtpFechaNacimiento.Value = estudianteSeleccionado.FechaNacimiento;
                        cmbGenero.SelectedValue = estudianteSeleccionado.Genero;
                        txtSalario.Text = Convert.ToString(estudianteSeleccionado.Salario);
                    }
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (estudianteSeleccionado != null) {
                contexto.Estudiante.Remove(estudianteSeleccionado);
                contexto.SaveChanges();
                source.Remove(estudianteSeleccionado);
                Limpiar();
            }
        }

        private void dgvEstudiantes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            dgvEstudiantes.ClearSelection();
            Limpiar();
        }

        private void dgvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0 && !flagCargando)
                foreach (DataGridViewRow row in this.dgvEstudiantes.SelectedRows)
                {
                    estudianteSeleccionado = row.DataBoundItem as Estudiante;
                    FrmReporteEstudiantesVIP frm = new FrmReporteEstudiantesVIP();
                    frm.SalarioMinimo = estudianteSeleccionado.Salario.HasValue ? 
                        estudianteSeleccionado.Salario.Value : 394;

                    if (frm.ShowDialog() == DialogResult.OK) {
                        int codigo = frm.CodigoSeleccionado;

                        estudianteSeleccionado = (source.DataSource as List<Estudiante>).Where(est => est.Id == codigo).Single();

                        MessageBox.Show("El estudiante seleccionado fue " 
                            + estudianteSeleccionado.Nombres 
                            + " " + estudianteSeleccionado.Apellidos);
                    }
                }
        }
    }
}
