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

namespace WindowsFormsApp3.presentacion.curso
{
    public partial class FrmMenuCurso : Form
    {   
        private NegocioCurso _negocioCurso = new NegocioCurso();
        private EntidadCurso _cursoSeleccionado = new EntidadCurso();

        public FrmMenuCurso()
        {
            InitializeComponent();
        }

        private void CargarTodosCursos()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dvgCursos.DataSource = _negocioCurso.ObtenerTodosCursosN();
            SeleccionarCursoLoad();
        }

        private void SeleccionarCursoLoad()
        {
            if (dvgCursos.Rows.Count == 0)
            {
                return;
            }

            string id = dvgCursos.CurrentRow.Cells[0].Value.ToString();
            string codigo = dvgCursos.CurrentRow.Cells[1].Value.ToString();
            string nombre = dvgCursos.CurrentRow.Cells[2].Value.ToString();
            string ciclo = dvgCursos.CurrentRow.Cells[3].Value.ToString();
            string carrera = dvgCursos.CurrentRow.Cells[4].Value.ToString();
            string fechaInicio = dvgCursos.CurrentRow.Cells[5].Value.ToString();
            string fechaFinalizacion = dvgCursos.CurrentRow.Cells[6].Value.ToString();

            _cursoSeleccionado.Id = Convert.ToInt32(id);
            _cursoSeleccionado.Codigo = codigo;
            _cursoSeleccionado.Nombre = nombre;
            _cursoSeleccionado.Carrera = carrera;
            _cursoSeleccionado.Ciclo = ciclo;
            _cursoSeleccionado.FechaInicio = DateTime.Parse(fechaInicio);
            _cursoSeleccionado.FechaFinalizacion = DateTime.Parse(fechaFinalizacion);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngresarCurso frmIngresarCurso = new FrmIngresarCurso();
            frmIngresarCurso.CursoGrilllaLoaded += CargarTodosCursos;
            frmIngresarCurso.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvgCursos.CurrentRow == null)
            {

                MessageBox.Show("Seleccion un alumno!!!");
                return;
            }

            FrmEditarCurso frmEditarCurso = new FrmEditarCurso(_cursoSeleccionado);
            frmEditarCurso.CursoGrilllaLoaded += CargarTodosCursos;
            frmEditarCurso.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarCurso frmBuscarCurso = new FrmBuscarCurso();
            DialogResult dialogResult = frmBuscarCurso.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ETipoBusquedaCurso tipo = frmBuscarCurso.Tipo;
                string parametro = frmBuscarCurso.Parametro;

                DataTable result = _negocioCurso.BuscarCursoByTipoAndParametroN(tipo, parametro);
                if (result != null)
                {

                    dvgCursos.DataSource = result;
                    if (result.Rows.Count > 0)
                    {
                        MessageBox.Show("Se encontraron " + result.Rows.Count + " registro(s)");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros");
                    }
                }

            }
        }

        private void FrmMenuCurso_Shown(object sender, EventArgs e)
        {
            CargarTodosCursos();
        }

        private void dvgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCursoLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgCursos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Curso!!!");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Deseas eliminar el registro con nombre: " + _cursoSeleccionado.Nombre + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                int num = _negocioCurso.EliminarCursoN(_cursoSeleccionado.Id);
                if (num != 0)
                {
                    CargarTodosCursos();
                    MessageBox.Show("Operacion Satisfactoria");
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTodosCursos();
        }
    }
}
