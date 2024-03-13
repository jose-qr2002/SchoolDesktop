﻿using SenatiPractica.negocio.alumno;
using SenatiPractica.presentacion.alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.common.instructor;
using WindowsFormsApp3.negocio.instructor;

namespace WindowsFormsApp3.presentacion.instructor
{
    public partial class FrmMenuInstructor : Form
    {

        NegocioInstructor _negocioInstructor = new NegocioInstructor();
        private EntidadInstructor _instructorSeleccionado = new EntidadInstructor();


        public FrmMenuInstructor()
        {
            InitializeComponent();
        }

        private void FrmMenuInstructor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CargarTodosInstructores()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dgvAlumnos.DataSource = _negocioInstructor.ObtenerTodosInstructoresN();
            SeleccionarInstructorLoad();
        }

        public void SeleccionarInstructorLoad()
        {

            if (dgvAlumnos.Rows.Count == 0)
            {
                return;
            }

            string id = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            string dni = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            string nombres = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            string apellidos = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();

            _instructorSeleccionado.Id = Convert.ToInt32(id);
            _instructorSeleccionado.Dni = dni;
            _instructorSeleccionado.Nombres = nombres;
            _instructorSeleccionado.Apellidos = apellidos;

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngresarInstructor frmIngresarInstructor = new FrmIngresarInstructor();
            frmIngresarInstructor.IntructorGrillaLoaded += CargarTodosInstructores;
            //frmIngresarAlumno.AlumnoGrillaLoaded += CargarTodosAlumnos;//Usamos eventos para refrescar la grilla
            frmIngresarInstructor.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTodosInstructores();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarInstructorLoad();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_instructorSeleccionado.Nombres);
        }

        private void FrmMenuInstructor_Shown(object sender, EventArgs e)
        {
            CargarTodosInstructores();
        }
    }
}
