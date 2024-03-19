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

namespace WindowsFormsApp3.presentacion.curso
{
    public partial class FrmIngresarCurso : Form
    {
        private NegocioCurso _negocioCurso = new NegocioCurso();

        public delegate void CursoGrillaLoadEventHandler();
        public event CursoGrillaLoadEventHandler CursoGrilllaLoaded;
        public FrmIngresarCurso()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = "CRS-";
            codigo += DateTime.Now.ToString("yyyyMMddHHmmssfff");
            EntidadCurso curso = new EntidadCurso(codigo, txtNombre.Text , cmbCiclo.Text, txtCarrera.Text, dtFechaInicio.Value, dtFechaFinalizacion.Value );
            int num = _negocioCurso.InsertarCursoN(curso);
            if (num != 0)
            {
                txtNombre.Text = "";
                cmbCiclo.SelectedIndex = 0;
                txtCarrera.Text = "";
                dtFechaInicio.Value = DateTime.Now;
                dtFechaFinalizacion.Value = DateTime.Now;

                MessageBox.Show("Operacion Satisfactoria");

                
                if (CursoGrilllaLoaded != null)
                {
                    CursoGrilllaLoaded(); //Invoco al evento refrescar grilla
                }
                
            }
        }

        private void FrmIngresarCurso_Shown(object sender, EventArgs e)
        {
            cmbCiclo.SelectedIndex = 0;
            txtNombre.Focus();
        }
    }
}
