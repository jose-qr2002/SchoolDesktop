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
using WindowsFormsApp3.negocio.curso;

namespace WindowsFormsApp3.presentacion.curso
{
    public partial class FrmMenuCurso : Form
    {   
        private NegocioCurso _negocioCurso = new NegocioCurso();

        public FrmMenuCurso()
        {
            InitializeComponent();
        }

        private void CargarTodosCursos()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dvgCursos.DataSource = _negocioCurso.ObtenerTodosCursosN();
            // SeleccionarCursosLoad();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngresarCurso frmIngresarCurso = new FrmIngresarCurso();
            frmIngresarCurso.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarCurso frmEditarCurso = new FrmEditarCurso();
            frmEditarCurso.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarCurso frmBuscarCurso = new FrmBuscarCurso();
            frmBuscarCurso.ShowDialog();
        }

        private void FrmMenuCurso_Shown(object sender, EventArgs e)
        {
            CargarTodosCursos();
        }
    }
}
