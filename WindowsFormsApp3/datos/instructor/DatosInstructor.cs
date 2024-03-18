﻿using SenatiPractica.common.alumno;
using SenatiPractica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.instructor;

namespace WindowsFormsApp3.datos.instructor
{
    public class DatosInstructor
    {


        public int InsertarInstructor(EntidadInstructor instructor)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("insertarInstructor", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Dni", instructor.Dni);
                    cmd.Parameters.AddWithValue("@Nombres", instructor.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", instructor.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", instructor.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", instructor.Direccion);
                    cmd.Parameters.AddWithValue("@FechaNac", instructor.FechaNac);
                    cmd.Parameters.AddWithValue("@Sexo", instructor.Sexo);
                    cmd.Parameters.AddWithValue("@Especialidad", instructor.Especialidad);
                    cmd.Parameters.AddWithValue("@Titulo", instructor.Titulo);
                    cmd.Parameters.AddWithValue("@Salario", instructor.Salario);
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

        public DataTable ObtenerTodosInstructores()
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("obtenerTodosInstructores", Connection.Singleton.SqlConnetionFactory))
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

        public int EliminarInstructor(int idInstructor)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand("eliminarInstructor", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", idInstructor);
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

        public int EditarInstructor(EntidadInstructor instructor)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand("editarInstructor", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", instructor.Id);
                    cmd.Parameters.AddWithValue("@Dni", instructor.Dni);
                    cmd.Parameters.AddWithValue("@Nombres", instructor.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", instructor.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", instructor.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", instructor.Direccion);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", instructor.FechaNac);
                    cmd.Parameters.AddWithValue("@Sexo", instructor.Sexo);
                    cmd.Parameters.AddWithValue("@Especialidad", instructor.Especialidad);
                    cmd.Parameters.AddWithValue("@Titulo", instructor.Titulo);
                    cmd.Parameters.AddWithValue("@Salario", instructor.Salario);
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

        public EntidadInstructor BuscarInstructorById(int idInstructor)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand("buscarInstructorById", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", idInstructor);
                    SqlDataReader reader = cmd.ExecuteReader();
                    EntidadInstructor entidadInstructor = new EntidadInstructor();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        entidadInstructor.mapearDatosInstructor(reader);
                    }
                    reader.Close();
                    
                    return entidadInstructor;
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
