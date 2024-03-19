using SenatiPractica.common.alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.curso;
using WindowsFormsApp3.datos.curso;

namespace WindowsFormsApp3.negocio.curso
{
    internal class NegocioCurso
    {
        public DatosCurso _datosCurso = new DatosCurso();

        public int InsertarCursoN(EntidadCurso curso)
        {
            int numRes = _datosCurso.InsertarCurso(curso);
            return numRes;
        }
    }
}
