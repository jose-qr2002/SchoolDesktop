using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.common.instructor
{
    public class EntidadInstructor
    {
        public int Id { get; set; }
        public String Dni { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Telefono {  get; set; }
        public String Direccion {  get; set; }
        public DateTime FechaNac { get; set; }
        public String Sexo { get; set; }
        public String Especialidad { get; set; }
        public String Titulo { get; set; }
        public Double Salario { get; set; }
        public DateTime FechaContrato { get; set; }
        public String EstadoEmpleo { get; set; }

        // Constructor
        public EntidadInstructor(string dni, string nombres, string apellidos)
        {
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
        }
        public EntidadInstructor(int id, string dni, string nombres, string apellidos)
        {
            Id = id;
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
        }
        public EntidadInstructor() { }
    }
}
