using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.asignacion;
using WindowsFormsApp3.datos.asignacion;
using WindowsFormsApp3.datos.matricula;

namespace WindowsFormsApp3.negocio.asignacion
{
    public class NegocioAsignacion
    {
        private DatosAsignacion _datosAsignacion = new DatosAsignacion();

        public DataTable obtenerTodasAsignacionesN()
        {
            return _datosAsignacion.obtenerTodasAsignaciones();
        }

        public int insertarAsignacionN(EntidadAsignacion asignacion)
        {
            if (asignacion.IdInstructor == 0)
            {
                MessageBox.Show("Instructor No Seleccionado");
                return 0;
            }
            if (asignacion.IdCurso == 0)
            {
                MessageBox.Show("Curso No Seleccionado");
                return 0;
            }
            List<string> aniosAcademicos = new List<string> { "2024-I", "2024-II" };
            if (!aniosAcademicos.Contains(asignacion.AnioAcademico))
            {
                MessageBox.Show("Año academico no valido");
                return 0;
            }
            return _datosAsignacion.insertarAsignacion(asignacion);
        }
    }
}
