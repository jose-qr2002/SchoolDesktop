using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.curso;
using WindowsFormsApp3.common.instructor;
using WindowsFormsApp3.negocio.curso;
using WindowsFormsApp3.negocio.instructor;

namespace WindowsFormsApp3.presentacion.asignacion
{  
    public partial class FrmMenuAsignacion : Form
    {
        private NegocioInstructor _negocioInstructor = new NegocioInstructor();
        private NegocioCurso _negocioCurso = new NegocioCurso();
        // IDS
        private int id_instructor;
        private int id_curso;

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

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            string parametroCurso = txtBusquedaCurso.Text;
            ETipoBusquedaCurso tipo = new ETipoBusquedaCurso();
            switch (cmbTipoBusquedaCurso.SelectedIndex)
            {
                case 0: tipo = ETipoBusquedaCurso.Codigo; break;
                case 1: tipo = ETipoBusquedaCurso.Nombre; break;
            }
            DataTable resultado = _negocioCurso.BuscarCursoByTipoAndParametroN(tipo, parametroCurso);
            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados");
                lblNombreCurso.Text = "N/A";
                id_curso = 0;
                return;
            }
            MessageBox.Show("Curso Encontrado");
            id_curso = int.Parse(resultado.Rows[0]["id"].ToString());
            lblNombreCurso.Text = resultado.Rows[0]["nombre"].ToString();
        }
    }
}
