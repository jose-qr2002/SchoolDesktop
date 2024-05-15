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
using WindowsFormsApp3.negocio.reporte;

namespace WindowsFormsApp3.presentacion.reportes
{
    public partial class FrmReporte : Form
    {
        NegocioReporte _negocioReporte = new NegocioReporte();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btnSalirReportes_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTotalMatriculados_Click(object sender, EventArgs e)
        {
            dvgReporte.DataSource = _negocioReporte.ObtenerReporteTotalMatriculadosN();
        }

        private void btnTotalAsignados_Click(object sender, EventArgs e)
        {
            dvgReporte.DataSource = _negocioReporte.ObtenerReporteTotalAsignadosN();
        }
    }
}
