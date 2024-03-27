using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.negocio.instructor;
using WindowsFormsApp3.negocio.matricula;

namespace WindowsFormsApp3.presentacion.matricula
{
    public partial class FrmMenuMatricula : Form
    {
        public NegocioMatricula _negocioMatriculaN = new NegocioMatricula();
        public FrmMenuMatricula()
        {
            InitializeComponent();
        }

        private void FrmMenuMatricula_Shown(object sender, EventArgs e)
        {
            CargarTodasMatriculas();
        }

        private void CargarTodasMatriculas()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dvgMatriculados.DataSource = _negocioMatriculaN.ObtenerTodasMatriculasN();
        }
    }
}
