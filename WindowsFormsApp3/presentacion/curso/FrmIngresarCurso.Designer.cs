namespace WindowsFormsApp3.presentacion.curso
{
    partial class FrmIngresarCurso
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.cmbCiclo = new System.Windows.Forms.ComboBox();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(258, 94);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(30, 13);
            this.lblCiclo.TabIndex = 2;
            this.lblCiclo.Text = "Ciclo";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(30, 157);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(30, 94);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(259, 157);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(110, 13);
            this.lblFechaFinalizacion.TabIndex = 5;
            this.lblFechaFinalizacion.Text = "Fecha de Finalizacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(213, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(428, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(33, 118);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(206, 20);
            this.txtCarrera.TabIndex = 8;
            // 
            // cmbCiclo
            // 
            this.cmbCiclo.FormattingEnabled = true;
            this.cmbCiclo.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.cmbCiclo.Location = new System.Drawing.Point(262, 118);
            this.cmbCiclo.Name = "cmbCiclo";
            this.cmbCiclo.Size = new System.Drawing.Size(199, 21);
            this.cmbCiclo.TabIndex = 9;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(33, 173);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(206, 20);
            this.dtFechaInicio.TabIndex = 10;
            // 
            // dtFechaFinalizacion
            // 
            this.dtFechaFinalizacion.Location = new System.Drawing.Point(261, 173);
            this.dtFechaFinalizacion.Name = "dtFechaFinalizacion";
            this.dtFechaFinalizacion.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinalizacion.TabIndex = 11;
            // 
            // FrmIngresarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 256);
            this.Controls.Add(this.dtFechaFinalizacion);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.cmbCiclo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFechaFinalizacion);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmIngresarCurso";
            this.Text = "Menú Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.ComboBox cmbCiclo;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFinalizacion;
    }
}