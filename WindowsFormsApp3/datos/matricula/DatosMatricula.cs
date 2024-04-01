using SenatiPractica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.matricula;

namespace WindowsFormsApp3.datos.matricula
{
    public class DatosMatricula
    {
        public DataTable ObtenerTodosMatriculas()
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("obtenerTodasMatriculas", Connection.Singleton.SqlConnetionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);
                    return dtData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public int InsertarMatricula(EntidadMatricula matricula)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarMatricula", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdAlumno", matricula.IdAlumno);
                    cmd.Parameters.AddWithValue("@IdCurso", matricula.IdCurso);
                    cmd.Parameters.AddWithValue("@AnioAcademico", matricula.AnioAcademico);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;

                }
            }
            catch (SqlException ex)
            {
                // Si la excepción es por violación de la clave única
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Error: Ya existe una matrícula para este alumno en este curso y año académico.");
                }
                else
                {
                    MessageBox.Show("Error del sistema");
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
                return 0;
            }
        }

        public DataTable buscarInstructores(EntidadMatricula matricula)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerInstructoreDeMatricula", Connection.Singleton.SqlConnetionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", matricula.IdCurso);
                    cmd.Parameters.AddWithValue("@AnioAcademico", matricula.AnioAcademico);
                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);
                    return dtData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
