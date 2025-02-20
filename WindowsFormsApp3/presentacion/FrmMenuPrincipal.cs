﻿using SenatiPractica.presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.presentacion.asignacion;
using WindowsFormsApp3.presentacion.curso;
using WindowsFormsApp3.presentacion.instructor;
using WindowsFormsApp3.presentacion.matricula;
using WindowsFormsApp3.presentacion.reportes;

namespace WindowsFormsApp3.presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            FrmMenuAlumno frmMenuAlumno = new FrmMenuAlumno();
            frmMenuAlumno.ShowDialog();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Sistema", "Acceso al Sistema",
            MessageBoxButtons.OK);
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            FrmMenuInstructor frmMenuInstructor = new FrmMenuInstructor();
            frmMenuInstructor.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            FrmMenuCurso frmMenuCurso = new FrmMenuCurso();
            frmMenuCurso.ShowDialog();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            FrmMenuMatricula frmMenuMatricula = new FrmMenuMatricula();
            frmMenuMatricula.ShowDialog();
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            FrmMenuAsignacion frmMenuAsignacion = new FrmMenuAsignacion();
            frmMenuAsignacion.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.ShowDialog();
        }
    }
}
