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
using WindowsFormsApp3.common.curso;
using WindowsFormsApp3.common.instructor;
using WindowsFormsApp3.negocio.asignacion;
using WindowsFormsApp3.negocio.curso;
using WindowsFormsApp3.negocio.instructor;
using WindowsFormsApp3.negocio.matricula;

namespace WindowsFormsApp3.presentacion.asignacion
{  
    public partial class FrmMenuAsignacion : Form
    {
        private NegocioInstructor _negocioInstructor = new NegocioInstructor();
        private NegocioCurso _negocioCurso = new NegocioCurso();
        private NegocioAsignacion _negocioAsignacion = new NegocioAsignacion();
        // IDS
        private int id_instructor;
        private int id_curso;

        EntidadAsignacion asignacionSeleccionada = new EntidadAsignacion();
        public FrmMenuAsignacion()
        {
            InitializeComponent();
        }

        private void cargarTodasAsignaciones()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dvgAsignaciones.DataSource = _negocioAsignacion.obtenerTodasAsignacionesN();
            // Ocultamos este dato porque es irrelevante para la vista pero necesario para saber los instructores asignado a cada curso
            dvgAsignaciones.Columns["id_intructor"].Visible = false;
            dvgAsignaciones.Columns["id_curso"].Visible = false;
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
            cargarTodasAsignaciones();
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

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            EntidadAsignacion nuevaAsignacion = new EntidadAsignacion();
            nuevaAsignacion.IdInstructor = id_instructor;
            nuevaAsignacion.IdCurso = id_curso;
            nuevaAsignacion.AnioAcademico = cmbAnioAcademico.Text;
            int resultado = _negocioAsignacion.insertarAsignacionN(nuevaAsignacion);
            if (resultado != 0)
            {
                id_instructor = 0;
                id_curso = 0;
                cmbAnioAcademico.SelectedIndex = 0;
                lblNombresInstructor.Text = "N/A";
                lblApellidosInstructor.Text = "M/A";
                lblNombreCurso.Text = "N/A";
                txtBusquedaCurso.Text = "";
                txtDni.Text = "";

                MessageBox.Show("Matricula Ingresada");
            }
        }

        private void dvgAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAsignacion();
            FrmAlumnosAsignacion frmAlumnosAsignacion = new FrmAlumnosAsignacion(asignacionSeleccionada);
            if (!frmAlumnosAsignacion.IsDisposed)
            {
                frmAlumnosAsignacion.ShowDialog();
            }
            
        }

        private void seleccionarAsignacion()
        {
            if (dvgAsignaciones.Rows.Count == 0)
            {
                return;
            }

            string id = dvgAsignaciones.CurrentRow.Cells["id"].Value.ToString();
            string id_instructorseleccionado = dvgAsignaciones.CurrentRow.Cells["id_intructor"].Value.ToString();
            string id_curso = dvgAsignaciones.CurrentRow.Cells["id_curso"].Value.ToString();
            string anio_academico = dvgAsignaciones.CurrentRow.Cells["Año academico"].Value.ToString();

            asignacionSeleccionada.Id = Convert.ToInt32(id);
            asignacionSeleccionada.IdInstructor = Convert.ToInt32(id_instructorseleccionado);
            asignacionSeleccionada.IdCurso = Convert.ToInt32(id_curso);
            asignacionSeleccionada.AnioAcademico = anio_academico;
        }
    }
}
