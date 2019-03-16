using CapaAccesoDatos.Entidades;
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
        private List<Estudiante> estudiantes;
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

            
            estudiantes = contexto.Estudiante.ToList();
            dgvEstudiantes.AutoGenerateColumns = false;
            dgvEstudiantes.DataSource = estudiantes;
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
            txtCodigo.Text = Convert.ToString(estudianteSeleccionado.Id);

        }

        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0 && !flagCargando) {
                int codigo = Convert.ToInt32(dgvEstudiantes
                    .SelectedRows[0].Cells[0].Value);

                estudianteSeleccionado = estudiantes.Where(est => est.Id == codigo).Single();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (estudianteSeleccionado != null) {
                contexto.Estudiante.Remove(estudianteSeleccionado);
                contexto.SaveChanges();
                Limpiar();
            }
        }
    }
}
