using SenatiPractica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.asignacion;

namespace WindowsFormsApp3.datos.asignacion
{
    public class DatosAsignacion
    {
        public int insertarAsignacion(EntidadAsignacion asignacion)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarAsignacion", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdInstructor", asignacion.IdInstructor);
                    cmd.Parameters.AddWithValue("@IdCurso", asignacion.IdCurso);
                    cmd.Parameters.AddWithValue("@AnioAcademico", asignacion.AnioAcademico);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;
                }
            }
            catch (SqlException ex)
            {
                // Si la excepción es por violación de la clave única
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Error: Ya existe una asignacion para este instructor en este curso y año académico.");
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
    }
}
