using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.presentacion.curso
{
    public partial class FrmMenuCurso : Form
    {
        public FrmMenuCurso()
        {
            InitializeComponent();
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
    }
}
