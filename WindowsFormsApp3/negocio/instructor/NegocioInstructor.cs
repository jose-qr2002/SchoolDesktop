using SenatiPractica.common.alumno;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.instructor;
using WindowsFormsApp3.datos.instructor;

namespace WindowsFormsApp3.negocio.instructor
{
    public class NegocioInstructor
    {
        DatosInstructor _datosInstructor = new DatosInstructor();

        public int InsertarInstructorN(EntidadInstructor instructor)
        {
            //validaciones
            // DNI
            if (!instructor.Dni.All(char.IsDigit))
            {
                MessageBox.Show("Formato de DNI incorrecto");
                return 0;
            }
            if (instructor.Dni.Length != 8)
            {
                MessageBox.Show("Longitud de dni incorrecta");
                return 0;
            }
            // Nombres
            if (instructor.Nombres.Length == 0)
            {
                MessageBox.Show("Nombres esta vacio");
                return 0;
            }
            // Apellidos
            if (instructor.Apellidos.Length == 0)
            {
                MessageBox.Show("Apellidos esta vacio");
                return 0;
            }
            // Direccion
            if (instructor.Direccion != null)
            {
                if (instructor.Direccion.Length == 0) {
                    MessageBox.Show("Direccion esta vacio");
                    return 0;
                }
            }
            // Telefono
            if (instructor.Telefono.Length != 9) {
                MessageBox.Show("Longitud de numero telefonico incorrecto");
                return 0;
            }
            // Fecha de Nacimiento
            DateTime haceDieciochoanios = DateTime.Now.AddYears(-18);
            if (instructor.FechaNac > haceDieciochoanios) {
                MessageBox.Show("Debe ser mayor de edad");
                return 0;
            }
            // Sexo
            if (!(instructor.Sexo == "M" ||  instructor.Sexo == "F")) {
                MessageBox.Show("Elige un sexo valido");
                return 0;
            }
            //Especialidad
            if(instructor.Especialidad.Length == 0) {
                MessageBox.Show("Especialidad esta vacio");
                return 0;
            }
            // Titulo
            if (instructor.Titulo.Length == 0) {
                MessageBox.Show("Titulo esta vacio");
                return 0;
            }
            // Salario
            if (instructor.Salario != null)
            {
                if (instructor.Salario < 0) {
                    MessageBox.Show("Ingrese un salario valido");
                    return 0;
                }
            }

            int numRes = _datosInstructor.InsertarInstructor(instructor);
            return numRes;
            //return 0;
        }

        public DataTable ObtenerTodosInstructoresN()
        {

            return _datosInstructor.ObtenerTodosInstructores();
        }

        public int EliminarInstructorN(int idAlumno)
        {

            return _datosInstructor.EliminarInstructor(idAlumno);
        }

        public int EditarInstructorN(EntidadInstructor instructor)
        {
            //validaciones
            // DNI
            if (!instructor.Dni.All(char.IsDigit))
            {
                MessageBox.Show("Formato de DNI incorrecto");
                return 0;
            }
            if (instructor.Dni.Length != 8)
            {
                MessageBox.Show("Longitud de dni incorrecta");
                return 0;
            }
            // Nombres
            if (instructor.Nombres.Length == 0)
            {
                MessageBox.Show("Nombres esta vacio");
                return 0;
            }
            // Apellidos
            if (instructor.Apellidos.Length == 0)
            {
                MessageBox.Show("Apellidos esta vacio");
                return 0;
            }
            // Direccion
            if (instructor.Direccion.Length == 0)
            {
                MessageBox.Show("Direccion esta vacio");
                return 0;
            }
            // Telefono
            if (instructor.Telefono.Length != 9)
            {
                MessageBox.Show("Longitud de numero telefonico incorrecto");
                return 0;
            }
            // Fecha de Nacimiento
            DateTime haceDieciochoanios = DateTime.Now.AddYears(-18);
            if (instructor.FechaNac > haceDieciochoanios)
            {
                MessageBox.Show("Debe ser mayor de edad");
                return 0;
            }
            // Sexo
            if (!(instructor.Sexo == "M" || instructor.Sexo == "F"))
            {
                MessageBox.Show("Elige un sexo valido");
                return 0;
            }
            //Especialidad
            if (instructor.Especialidad.Length == 0)
            {
                MessageBox.Show("Especialidad esta vacio");
                return 0;
            }
            // Titulo
            if (instructor.Titulo.Length == 0)
            {
                MessageBox.Show("Titulo esta vacio");
                return 0;
            }
            // Salario
            if (instructor.Salario.ToString() == "")
            {
                MessageBox.Show("Ingrese un salario valido" + instructor.Salario.ToString());
                return 0;
            }

            return _datosInstructor.EditarInstructor(instructor);
        }

        public EntidadInstructor BuscarInstructorById(int id)
        {
            return _datosInstructor.BuscarInstructorById(id);
        }

        public DataTable BuscarInstructorByTipoAndParametroN(ETipoBusquedaInstructor tipo, string parametro)
        {

            //validaciones
            if (tipo == ETipoBusquedaInstructor.Dni)
            {//DNI 
                if (Regex.IsMatch(parametro, "[aeiouAEIOU]", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("El DNI no puede tener vocales");
                    return null;
                }
            }

            return _datosInstructor.BuscarInstructorByTipoAndParametro(tipo, parametro);
        }
    }
}
