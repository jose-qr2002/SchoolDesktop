using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public EntidadInstructor(string dni, string nombres, string apellidos, string telefono, string direccion, DateTime fechaNac, string sexo, string especialidad, string titulo, double salario)
        {
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            FechaNac = fechaNac;
            Sexo = sexo;
            Especialidad = especialidad;
            Titulo = titulo;
            Salario = salario;
        }

        public EntidadInstructor() { }

        /// <summary>
        /// Mapea los datos de un SqlDataReader a una instancia de EntidadInstructor.
        /// </summary>
        /// <param name="reader">El SqlDataReader que contiene los datos del instructor.</param>
        /// <returns>Una instancia de EntidadInstructor con los datos mapeados desde el SqlDataReader.</returns>
        public void mapearDatosInstructor(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["id"]);
            this.Dni = reader["dni"].ToString();
            this.Nombres = reader["nombre"].ToString();
            this.Apellidos = reader["apellido"].ToString();
            this.Telefono = reader["telefono"].ToString();
            this.Direccion = reader["direccion"].ToString();
            this.FechaNac = Convert.ToDateTime(reader["fechaNacimiento"]);
            this.Sexo = reader["sexo"].ToString();
            this.Especialidad = reader["especialidad"].ToString();
            this.Titulo = reader["titulo"].ToString();
            this.Salario = Convert.ToDouble(reader["salario"]);
        }
    }
}
