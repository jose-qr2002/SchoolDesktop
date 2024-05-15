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

        private void dvgReporte_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = dvgReporte.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Verificar si el valor de la celda es TOTAL
            if (cell.Value != null && cell.Value.ToString().Equals("TOTAL", StringComparison.OrdinalIgnoreCase))
            {
                // Cambiar el estilo de la fuente de la celda a rojo y negrita
                cell.Style.ForeColor = Color.Red;
                cell.Style.Font = new Font(dvgReporte.Font, FontStyle.Bold);
            }
        }
    }
}
