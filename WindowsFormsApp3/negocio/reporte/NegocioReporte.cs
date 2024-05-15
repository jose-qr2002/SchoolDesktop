using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.datos.matricula;
using WindowsFormsApp3.datos.reporte;

namespace WindowsFormsApp3.negocio.reporte
{
    public class NegocioReporte
    {
        public DatosReporte _datosReporte = new DatosReporte();
        public DataTable ObtenerReporteTotalMatriculadosN()
        {
            return _datosReporte.ObtenerReporteTotalMatriculados();
        }

        public DataTable ObtenerReporteTotalAsignadosN()
        {
            return _datosReporte.ObtenerReporteTotalAsignados();
        }
    }
}
