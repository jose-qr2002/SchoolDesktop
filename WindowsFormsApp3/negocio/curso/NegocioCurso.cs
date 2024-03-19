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
            // Validaciones
            if (curso.Nombre == "") {
                MessageBox.Show("El campo nombre esta vacio");
                return 0;
            }
            if (curso.Carrera == "")
            {
                MessageBox.Show("El campo carrera esta vacio");
                return 0;
            }
            if (curso.Ciclo == "")
            {
                MessageBox.Show("El campo ciclo esta vacio");
                return 0;
            }

            string[] ciclos = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            List<string> listaCiclos = new List<string>(ciclos);

            if (!listaCiclos.Contains(curso.Ciclo))
            {
                MessageBox.Show("Escoja un ciclo válido");
                return 0;
            }
            if (curso.FechaInicio > curso.FechaFinalizacion)
            {
                MessageBox.Show("La fecha de Inicio no puede ser posterior a la de Finalización del curso");
                return 0;
            }


            int numRes = _datosCurso.InsertarCurso(curso);
            return numRes;
        }
    }
}
