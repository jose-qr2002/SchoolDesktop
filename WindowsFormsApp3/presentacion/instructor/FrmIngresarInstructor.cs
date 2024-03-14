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
    public partial class FrmIngresarInstructor : Form
    {

        private NegocioInstructor _negocioInstructor = new NegocioInstructor();

        public delegate void InstructorGrillaLoadEventHandler();
        public event InstructorGrillaLoadEventHandler IntructorGrillaLoaded;
        public FrmIngresarInstructor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadInstructor instructor = new EntidadInstructor(txtDni.Text, txtNombres.Text, txtApellidos.Text,txtTelefono.Text,txtDireccion.Text,timeFechaNac.Value,cbSexo.Text,txtEspecialidad.Text,txtTitulo.Text,Double.Parse( txtSalario.Text ));

            int num = _negocioInstructor.InsertarInstructorN(instructor);
            if (num != 0)
            {
                MessageBox.Show("Operacion Satisfactoria");
                txtDni.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                if (IntructorGrillaLoaded != null)
                {
                    IntructorGrillaLoaded(); //Invoco al evento refrescar grilla
                }
            }
            Hide();
        }

        private void FrmIngresarInstructor_Load(object sender, EventArgs e)
        {

        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número, la tecla de retroceso o el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // Si no es un número, ni una tecla de control, ni un punto decimal, se cancela la entrada
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                // Si ya hay un punto decimal en el texto, se cancela la entrada del segundo punto
                e.Handled = true;
            }

        }
    }
}
