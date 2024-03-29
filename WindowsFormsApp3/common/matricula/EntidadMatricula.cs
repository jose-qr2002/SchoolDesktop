using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.common.matricula
{
    public class EntidadMatricula
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public string AnioAcademico { get; set; }

        public EntidadMatricula() { }
    }
}
