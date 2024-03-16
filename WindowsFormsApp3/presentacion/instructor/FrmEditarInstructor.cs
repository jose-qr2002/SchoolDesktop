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
