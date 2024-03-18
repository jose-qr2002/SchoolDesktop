using SenatiPractica.common.alumno;
using SenatiPractica.negocio.alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.instructor;
using WindowsFormsApp3.negocio.instructor;

namespace WindowsFormsApp3.presentacion.instructor
{
    public partial class FrmEditarInstructor : Form
    {
        private NegocioInstructor _negocioInstructor = new NegocioInstructor();
        private EntidadInstructor _editarInstructor = new EntidadInstructor();

        public delegate void InstructorGrillaLoadEventHandler();
        public event InstructorGrillaLoadEventHandler IntructorGrillaLoaded;

        public FrmEditarInstructor(EntidadInstructor entidadInstructor)
        {
            _editarInstructor = _negocioInstructor.BuscarInstructorById(entidadInstructor.Id);
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _editarInstructor.Dni = txtDni.Text;
            _editarInstructor.Nombres = txtNombres.Text;
            _editarInstructor.Apellidos = txtApellidos.Text;
            _editarInstructor.Direccion = txtDireccion.Text;
            _editarInstructor.Telefono = txtTelefono.Text;
            _editarInstructor.Sexo = cmbSexo.Text;
            _editarInstructor.Titulo = txtTitulo.Text;
            _editarInstructor.Especialidad = txtEspecialidad.Text;
            _editarInstructor.FechaNac = timeFechaNac.Value;
            _editarInstructor.Salario = Double.Parse(txtSalario.Text);
            

            int num = _negocioInstructor.EditarInstructorN(_editarInstructor);

            if (num != 0)
            {

                if (IntructorGrillaLoaded != null)
                {
                    IntructorGrillaLoaded(); //Invoco al evento refrescar grilla
                }

                MessageBox.Show("Operacion Satisfactoria");

                Close();
            }
        }

        private void FrmEditarInstructor_Load(object sender, EventArgs e)
        {
            txtDni.Text = _editarInstructor.Dni;
            txtNombres.Text = _editarInstructor.Nombres;
            txtApellidos.Text = _editarInstructor.Apellidos;
            txtDireccion.Text = _editarInstructor.Direccion;
            txtTitulo.Text = _editarInstructor.Titulo;
            cmbSexo.Text = _editarInstructor.Sexo;
            txtEspecialidad.Text = _editarInstructor.Especialidad;
            txtTelefono.Text = _editarInstructor.Telefono;
            txtSalario.Text = _editarInstructor.Salario.ToString();
            timeFechaNac.Value = _editarInstructor.FechaNac;
        }
    }
}
