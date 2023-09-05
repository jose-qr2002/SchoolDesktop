﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        EntidadLogin objEntidad;
        NegocioLogin objNegocio;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //"Data Source=localhost,64930;Initial Catalog=Senati;User ID=sa;Password=***********"
            //"Data Source=DESKTOP-VLV57I9\\SQLEXPRESS;Initial Catalog=Senati;Integrated Security=True";
            objEntidad = new EntidadLogin();
            objNegocio = new NegocioLogin();

        }
        void Login()//Creando un procedimiento.
        {
            Connection.Singleton.ConnetionString = txtConeccion.Text;
            objEntidad.Usuario = txtUsuario.Text;
            objEntidad.Contrasenia = txtContrasenia.Text;

            DataTable tbl = objNegocio.LogonN(objEntidad);
            if (tbl == null) return;

            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("No coinciden Usuario y Contraseña \n Intentelo nuevamente",

                "Acceso al Sistema", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Bienvenido al Sistema", "Acceso al Sistema",
               MessageBoxButtons.OK);
                //FrmMenuPrincilpal Frm = new FrmMenuPrincilpal();
                //Frm.Show();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtConeccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
