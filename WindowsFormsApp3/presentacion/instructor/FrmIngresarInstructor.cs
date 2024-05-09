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
            try
            {
                // Valores con restriccion default
                double? salario;
                string direccion;
                if (txtSalario.Text.Trim() == "")
                {
                    salario = null;
                } else
                {
                    salario = Double.Parse(txtSalario.Text);
                }
                
                if (txtDireccion.Text.Trim() == "") {
                    direccion = null;
                } else
                {
                    direccion = txtDireccion.Text;
                }

                EntidadInstructor instructor = new EntidadInstructor(txtDni.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, direccion, timeFechaNac.Value, cbSexo.Text, txtEspecialidad.Text, txtTitulo.Text, salario);
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
                    Hide();
                }
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ingrese todos los campos correctamente");
                return;
            }

            
        }

        private void FrmIngresarInstructor_Load(object sender, EventArgs e)
        {
            List<string> sexos = new List<string> { "F", "M" };
            cbSexo.DataSource = sexos;
            cbSexo.Text = sexos[1];
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
