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

namespace WindowsFormsApp3.presentacion.asignacion
{  
    public partial class FrmMenuAsignacion : Form
    {
        private NegocioInstructor _negocioInstructor = new NegocioInstructor();
        // IDS
        private int id_instructor;

        public FrmMenuAsignacion()
        {
            InitializeComponent();
        }

        private void btnBusquedaDni_Click(object sender, EventArgs e)
        {
            string parametroDni = txtDni.Text;
            DataTable instructores = _negocioInstructor.BuscarInstructorByTipoAndParametroN(ETipoBusquedaInstructor.Dni, parametroDni);
            if (instructores.Rows.Count == 0) 
            {
                MessageBox.Show("No se encontraron instructores");
                lblNombresInstructor.Text = "N/A";
                lblApellidosInstructor.Text = "N/A";
                return;
            }
            lblNombresInstructor.Text = instructores.Rows[0]["nombre"].ToString();
            lblApellidosInstructor.Text = instructores.Rows[0]["apellido"].ToString();
            id_instructor = Int32.Parse(instructores.Rows[0]["id"].ToString());
            MessageBox.Show("Se encontro un instructor");
        }

        private void FrmMenuAsignacion_Shown(object sender, EventArgs e)
        {
            cmbAnioAcademico.SelectedIndex = 0;
            cmbTipoBusquedaCurso.SelectedIndex = 0;
        }
    }
}
