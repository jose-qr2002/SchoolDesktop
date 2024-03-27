using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.datos.instructor;
using WindowsFormsApp3.datos.matricula;

namespace WindowsFormsApp3.negocio.matricula
{
    public class NegocioMatricula
    {
        public DatosMatricula _datosMatricula = new DatosMatricula();
        public DataTable ObtenerTodasMatriculasN()
        {

            return _datosMatricula.ObtenerTodosMatriculas();
        }
    }
}
