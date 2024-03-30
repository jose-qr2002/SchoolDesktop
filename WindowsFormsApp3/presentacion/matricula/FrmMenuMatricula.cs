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
        // IDs
        public int idAlumnoBuscado;
        public FrmMenuMatricula()
        {
            InitializeComponent();
        }

        private void FrmMenuMatricula_Shown(object sender, EventArgs e)
        {
            CargarTodasMatriculas();
            cmbTipoBusquedaCurso.SelectedIndex = 0;
        }

        private void CargarTodasMatriculas()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dvgMatriculados.DataSource = _negocioMatriculaN.ObtenerTodasMatriculasN();
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
            idAlumnoBuscado = int.Parse(resultado.Rows[0]["id"].ToString());
            lblCursoNombre.Text = resultado.Rows[0]["nombre"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            
        }
    }
}
