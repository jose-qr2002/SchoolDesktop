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
using WindowsFormsApp3.common.curso;
using WindowsFormsApp3.common.matricula;
using WindowsFormsApp3.negocio.curso;
using WindowsFormsApp3.negocio.instructor;
using WindowsFormsApp3.negocio.matricula;

namespace WindowsFormsApp3.presentacion.matricula
{
    public partial class FrmMenuMatricula : Form
    {
        private NegocioMatricula _negocioMatriculaN = new NegocioMatricula();
        private NegocioAlumno _negocioAlumnoN = new NegocioAlumno();
        private NegocioCurso _negocioCursoN = new NegocioCurso();
        // IDs para ingresar nueva Matricula
        public int idAlumnoBuscado;
        public int idCursoBuscado;
        // Matricula sellecionada
        EntidadMatricula matriculaSeleccionada = new EntidadMatricula();
        public FrmMenuMatricula()
        {
            InitializeComponent();
        }

        private void FrmMenuMatricula_Shown(object sender, EventArgs e)
        {
            CargarTodasMatriculas();
            cmbTipoBusquedaCurso.SelectedIndex = 0;
            cmbAnioAcademico.SelectedIndex = 0;
        }

        private void CargarTodasMatriculas()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dvgMatriculados.DataSource = _negocioMatriculaN.ObtenerTodasMatriculasN();
            // Ocultamos este dato porque es irrelevante para la vista pero necesario para saber los instructores asignado a cada curso
            dvgMatriculados.Columns["id_alumno"].Visible = false;
            dvgMatriculados.Columns["id_curso"].Visible = false;
        }

        private void btnBusquedaDni_Click(object sender, EventArgs e)
        {
            string parametro = txtDni.Text;
            ETipoBusquedaAlumno tipo = ETipoBusquedaAlumno.Dni;
            DataTable resultado = _negocioAlumnoN.BuscarAlumnoByTipoAndParametroN(tipo, parametro);
            if (resultado == null)
            {
                MessageBox.Show("No se encontraron resultados");
                return;
            }
            if (resultado.Rows.Count == 0 )
            {
                MessageBox.Show("No se encontraron resultados");
                lblApellidos.Text = "";
                lblNombres.Text = "";
                return;
            }
            MessageBox.Show("Alumno Encontrado");
            idAlumnoBuscado = int.Parse( resultado.Rows[0]["id"].ToString());
            lblNombres.Text = resultado.Rows[0]["nombres"].ToString();
            lblApellidos.Text = resultado.Rows[0]["apellidos"].ToString();
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            string parametro = txtBusquedaCurso.Text;
            ETipoBusquedaCurso tipo = new ETipoBusquedaCurso();
            switch (cmbTipoBusquedaCurso.SelectedIndex)
            {
                case 0: tipo = ETipoBusquedaCurso.Codigo; break;
                case 1: tipo = ETipoBusquedaCurso.Nombre; break;
            }
            DataTable resultado = _negocioCursoN.BuscarCursoByTipoAndParametroN(tipo, parametro);
            if (resultado == null)
            {
                MessageBox.Show("No se encontraron resultados");
                return;
            }
            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados");
                lblCursoNombre.Text = "";
                return;
            }
            MessageBox.Show("Curso Encontrado");
            idCursoBuscado = int.Parse(resultado.Rows[0]["id"].ToString());
            lblCursoNombre.Text = resultado.Rows[0]["nombre"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            EntidadMatricula nuevaMatricula = new EntidadMatricula();
            nuevaMatricula.IdAlumno = idAlumnoBuscado;
            nuevaMatricula.IdCurso = idCursoBuscado;
            nuevaMatricula.AnioAcademico = cmbAnioAcademico.Text;
            int resultado = _negocioMatriculaN.InsertarMatriculaN(nuevaMatricula);
            if (resultado != 0)
            {
                idAlumnoBuscado = 0;
                idCursoBuscado = 0;
                cmbAnioAcademico.SelectedIndex = 0;
                lblNombres.Text = "N/A";
                lblCursoNombre.Text = "N/A";
                lblApellidos.Text = "M/A";
                txtBusquedaCurso.Text = "";
                txtDni.Text = "";
         
                MessageBox.Show("Matricula Ingresada");
                CargarTodasMatriculas();
            }

        }

        private void dvgMatriculados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMatricula();
            DataTable instructores = _negocioMatriculaN.buscarInstructoresN(matriculaSeleccionada);
            if (instructores.Rows.Count == 0) {
                MessageBox.Show("No Hay Instructores Asignados");
                return;
            }
            string mensaje = "";
            for (int i = 0; i < instructores.Rows.Count; i++)
            {
                mensaje += instructores.Rows[i]["nombres"] + "\n";
            }
            
            MessageBox.Show("Matricula seleccionada\n" +
                            "Instructores: \n" +
                            mensaje);
        }

        private void seleccionarMatricula()
        {
            if (dvgMatriculados.Rows.Count == 0)
            {
                return;
            }

            string id = dvgMatriculados.CurrentRow.Cells["id"].Value.ToString();
            string id_alumno = dvgMatriculados.CurrentRow.Cells["id_alumno"].Value.ToString();
            string id_curso = dvgMatriculados.CurrentRow.Cells["id_curso"].Value.ToString();
            string anio_academico = dvgMatriculados.CurrentRow.Cells["Año academico"].Value.ToString();

            matriculaSeleccionada.Id = Convert.ToInt32(id);
            matriculaSeleccionada.IdAlumno = Convert.ToInt32(id_alumno);
            matriculaSeleccionada.IdCurso = Convert.ToInt32(id_curso);
            matriculaSeleccionada.AnioAcademico = anio_academico;
        }
    }
}
