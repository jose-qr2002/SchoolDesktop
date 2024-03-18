using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.common.curso
{
    public class EntidadCurso
    {
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Ciclo { get; set; }
        public String Carrera { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
    
        // Constructor adecuado para insertar un nuevo registro a la base de datos
        public EntidadCurso(string codigo, string nombre, string ciclo, string carrera, DateTime fechaInicio, DateTime fechaFinalizacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Ciclo = ciclo;
            Carrera = carrera;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFinalizacion;
        }

        // Constructor por defecto
        public EntidadCurso() { }
    }
}
