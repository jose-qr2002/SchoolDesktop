namespace WindowsFormsApp3.presentacion.instructor
{
    partial class FrmEditarInstructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvlTitulo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timeFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lvlEspecialidad = new System.Windows.Forms.Label();
            this.lvlSexo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(373, 63);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 49;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(373, 137);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(121, 20);
            this.txtSalario.TabIndex = 48;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(102, 137);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(168, 20);
            this.txtTitulo.TabIndex = 47;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(373, 102);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(121, 20);
            this.txtEspecialidad.TabIndex = 46;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(373, 28);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Salario";
            // 
            // lvlTitulo
            // 
            this.lvlTitulo.AutoSize = true;
            this.lvlTitulo.Location = new System.Drawing.Point(34, 145);
            this.lvlTitulo.Name = "lvlTitulo";
            this.lvlTitulo.Size = new System.Drawing.Size(33, 13);
            this.lvlTitulo.TabIndex = 43;
            this.lvlTitulo.Text = "Titulo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(37, 196);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(233, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // timeFechaNac
            // 
            this.timeFechaNac.Location = new System.Drawing.Point(302, 196);
            this.timeFechaNac.Name = "timeFechaNac";
            this.timeFechaNac.Size = new System.Drawing.Size(200, 20);
            this.timeFechaNac.TabIndex = 40;
            // 
            // lvlEspecialidad
            // 
            this.lvlEspecialidad.AutoSize = true;
            this.lvlEspecialidad.Location = new System.Drawing.Point(299, 105);
            this.lvlEspecialidad.Name = "lvlEspecialidad";
            this.lvlEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lvlEspecialidad.TabIndex = 39;
            this.lvlEspecialidad.Text = "Especialidad";
            // 
            // lvlSexo
            // 
            this.lvlSexo.AutoSize = true;
            this.lvlSexo.Location = new System.Drawing.Point(299, 66);
            this.lvlSexo.Name = "lvlSexo";
            this.lvlSexo.Size = new System.Drawing.Size(31, 13);
            this.lvlSexo.TabIndex = 38;
            this.lvlSexo.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dni";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(102, 63);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(168, 20);
            this.txtNombres.TabIndex = 31;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(102, 102);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(168, 20);
            this.txtApellidos.TabIndex = 32;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(102, 31);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(168, 20);
            this.txtDni.TabIndex = 30;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(201, 23);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmEditarInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 302);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvlTitulo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeFechaNac);
            this.Controls.Add(this.lvlEspecialidad);
            this.Controls.Add(this.lvlSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmEditarInstructor";
            this.Text = "Editar Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lvlTitulo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timeFechaNac;
        private System.Windows.Forms.Label lvlEspecialidad;
        private System.Windows.Forms.Label lvlSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnGuardar;
    }
}