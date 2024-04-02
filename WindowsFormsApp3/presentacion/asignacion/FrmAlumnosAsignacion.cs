using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.asignacion;
using WindowsFormsApp3.negocio.asignacion;

namespace WindowsFormsApp3.presentacion.asignacion
{
    public partial class FrmAlumnosAsignacion : Form
    {
        private NegocioAsignacion _negocioAsignacion = new NegocioAsignacion();
        private EntidadAsignacion asignacion;
        public FrmAlumnosAsignacion(EntidadAsignacion asignacion)
        {
            InitializeComponent();
            this.asignacion = asignacion;
            DataTable matriculados = _negocioAsignacion.obtenerAlumnosAsignacionN(this.asignacion);
            if(matriculados.Rows.Count == 0)
            {
                Close();
                MessageBox.Show("No hay alumnos matriculados");
                return;
            }
            
            lblNombreCurso.Text = matriculados.Rows[0]["Curso"].ToString();
            lblAnioAcademico.Text = matriculados.Rows[0]["Año academico"].ToString();
            dvgMatriculados.DataSource = matriculados;
            
            
            
        }

        private void FrmAlumnosAsignacion_Shown(object sender, EventArgs e)
        {

        }
    }
}
