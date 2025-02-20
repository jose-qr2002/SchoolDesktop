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
        public DataTable ObtenerTodosCursos()
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("obtenerTodosCursos", Connection.Singleton.SqlConnetionFactory))
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

        public int EditarCurso(EntidadCurso curso)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand("editarCurso", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", curso.Id);
                    cmd.Parameters.AddWithValue("@Codigo", curso.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Carrera", curso.Carrera);
                    cmd.Parameters.AddWithValue("@Ciclo", curso.Ciclo);
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

        public int EliminarCurso(int idCurso)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand("eliminarCurso", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", idCurso);
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

        public DataTable BuscarCursoByTipoAndParametro(ETipoBusquedaCurso tipoBusquedaCurso, string parametro)
        {

            try
            {
                int tipo = -1;
                switch (tipoBusquedaCurso)
                {
                    case ETipoBusquedaCurso.Codigo: tipo = 1; break;
                    case ETipoBusquedaCurso.Nombre: tipo = 2; break;
                    case ETipoBusquedaCurso.Carrera: tipo = 3; break;
                }

                using (SqlCommand cmd = new SqlCommand("buscarCursoByTipoAndParametro", Connection.Singleton.SqlConnetionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Parametro", parametro);
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
