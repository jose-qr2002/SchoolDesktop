using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.common.asignacion;
using WindowsFormsApp3.datos.asignacion;

namespace WindowsFormsApp3.negocio.asignacion
{
    public class NegocioAsignacion
    {
        private DatosAsignacion _datosAsignacion = new DatosAsignacion();

        public int insertarAsignacionN(EntidadAsignacion asignacion)
        {
            return _datosAsignacion.insertarAsignacion(asignacion);
        }
    }
}
