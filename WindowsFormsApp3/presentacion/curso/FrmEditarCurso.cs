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
    public partial class FrmEditarCurso : Form
    {
        private NegocioCurso _negocioCurso = new NegocioCurso();
        private EntidadCurso _entidadCurso;

        public delegate void CursoGrillaLoadEventHandler();
        public event CursoGrillaLoadEventHandler CursoGrilllaLoaded;
        public FrmEditarCurso(EntidadCurso curso)
        {
            _entidadCurso = curso;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _entidadCurso.Nombre = txtNombre.Text;
            _entidadCurso.Carrera = txtCarrera.Text;
            _entidadCurso.Ciclo = cmbCiclo.Text;
            _entidadCurso.FechaInicio = dtFechaInicio.Value;
            _entidadCurso.FechaFinalizacion = dtFechaFinalizacion.Value;

            int num = _negocioCurso.EditarCursoN(_entidadCurso);

            if (num != 0)
            {

                if (CursoGrilllaLoaded != null)
                {
                    CursoGrilllaLoaded(); //Invoco al evento refrescar grilla
                }

                MessageBox.Show("Operacion Satisfactoria");

                Close();
            }
        }

        private void FrmEditarCurso_Shown(object sender, EventArgs e)
        {
            txtNombre.Text = _entidadCurso.Nombre;
            txtCarrera.Text = _entidadCurso.Carrera;
            cmbCiclo.Text = _entidadCurso.Ciclo;
            dtFechaInicio.Value = _entidadCurso.FechaInicio;
            dtFechaFinalizacion.Value = _entidadCurso.FechaFinalizacion;
        }
    }
}
