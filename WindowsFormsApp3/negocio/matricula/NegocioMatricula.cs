using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.matricula;
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

        public int InsertarMatriculaN(EntidadMatricula matricula)
        {
            if(matricula.IdAlumno == 0)
            {
                MessageBox.Show("Alumno No Seleccionado");
                return 0;
            }
            if(matricula.IdCurso == 0)
            {
                MessageBox.Show("Curso No Seleccionado");
                return 0;
            }
            List<string> aniosAcademicos = new List<string>{"2024-I","2024-II"};
            if (!aniosAcademicos.Contains(matricula.AnioAcademico))
            {
                MessageBox.Show("Año academico no valido");
                return 0;
            }

            return _datosMatricula.InsertarMatricula(matricula);
        }
    }
}
