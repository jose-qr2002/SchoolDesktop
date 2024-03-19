﻿using SenatiPractica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.curso;

namespace WindowsFormsApp3.datos.curso
{
    internal class DatosCurso
    {
        public int InsertarCurso(EntidadCurso curso)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("insertarCurso", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", curso.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Ciclo", curso.Ciclo);
                    cmd.Parameters.AddWithValue("@Carrera", curso.Carrera);
                    cmd.Parameters.AddWithValue("@FechaInicio", curso.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFinalizacion", curso.FechaFinalizacion);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
