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

namespace WindowsFormsApp3.presentacion.curso
{
    public partial class FrmBuscarCurso : Form
    {
        public ETipoBusquedaCurso Tipo {  get; set; }
        public string Parametro { get; set; }

        public FrmBuscarCurso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cbTipo.SelectedIndex)
            {
                case 0: Tipo = ETipoBusquedaCurso.Codigo; break;
                case 1: Tipo = ETipoBusquedaCurso.Nombre; break;
                case 2: Tipo = ETipoBusquedaCurso.Carrera; break;
            }
            Parametro = txtBusqueda.Text;
            this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo.
            this.Close();
        }

        private void FrmBuscarCurso_Shown(object sender, EventArgs e)
        {
            CenterToScreen();
            cbTipo.SelectedIndex = 0;
            txtBusqueda.Focus();
        }
    }
}
