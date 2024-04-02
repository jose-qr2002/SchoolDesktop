namespace WindowsFormsApp3.presentacion.asignacion
{
    partial class FrmMenuAsignacion
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
            this.cmbAnioAcademico = new System.Windows.Forms.ComboBox();
            this.lblEtiquetaAnioAcademico = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.cmbTipoBusquedaCurso = new System.Windows.Forms.ComboBox();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblEtiquetaNombreCurso = new System.Windows.Forms.Label();
            this.txtBusquedaCurso = new System.Windows.Forms.TextBox();
            this.lblBusquedaCursoTitulo = new System.Windows.Forms.Label();
            this.lblApellidosInstructor = new System.Windows.Forms.Label();
            this.btnAsignacion = new System.Windows.Forms.Button();
            this.lblNombresInstructor = new System.Windows.Forms.Label();
            this.lblApellidosEtiqueta = new System.Windows.Forms.Label();
            this.lblNombresEtiqueta = new System.Windows.Forms.Label();
            this.dvgAsignaciones = new System.Windows.Forms.DataGridView();
            this.lblDatosInstructorTitulo = new System.Windows.Forms.Label();
            this.lblBusquedaInstructoresTitulo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBusquedaDni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnioAcademico
            // 
            this.cmbAnioAcademico.AutoCompleteCustomSource.AddRange(new string[] {
            "2024-I",
            "2024-II"});
            this.cmbAnioAcademico.FormattingEnabled = true;
            this.cmbAnioAcademico.Items.AddRange(new object[] {
            "2024-I",
            "2024-II"});
            this.cmbAnioAcademico.Location = new System.Drawing.Point(477, 142);
            this.cmbAnioAcademico.Name = "cmbAnioAcademico";
            this.cmbAnioAcademico.Size = new System.Drawing.Size(73, 21);
            this.cmbAnioAcademico.TabIndex = 41;
            // 
            // lblEtiquetaAnioAcademico
            // 
            this.lblEtiquetaAnioAcademico.AutoSize = true;
            this.lblEtiquetaAnioAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaAnioAcademico.Location = new System.Drawing.Point(331, 140);
            this.lblEtiquetaAnioAcademico.Name = "lblEtiquetaAnioAcademico";
            this.lblEtiquetaAnioAcademico.Size = new System.Drawing.Size(140, 22);
            this.lblEtiquetaAnioAcademico.TabIndex = 40;
            this.lblEtiquetaAnioAcademico.Text = "Año Academico:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(305, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 42);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(617, 56);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(108, 23);
            this.btnBuscarCurso.TabIndex = 38;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            // 
            // cmbTipoBusquedaCurso
            // 
            this.cmbTipoBusquedaCurso.FormattingEnabled = true;
            this.cmbTipoBusquedaCurso.Items.AddRange(new object[] {
            "CODIGO",
            "NOMBRE"});
            this.cmbTipoBusquedaCurso.Location = new System.Drawing.Point(493, 55);
            this.cmbTipoBusquedaCurso.Name = "cmbTipoBusquedaCurso";
            this.cmbTipoBusquedaCurso.Size = new System.Drawing.Size(104, 21);
            this.cmbTipoBusquedaCurso.TabIndex = 37;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(430, 100);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(27, 13);
            this.lblNombreCurso.TabIndex = 36;
            this.lblNombreCurso.Text = "N/A";
            // 
            // lblEtiquetaNombreCurso
            // 
            this.lblEtiquetaNombreCurso.AutoSize = true;
            this.lblEtiquetaNombreCurso.Location = new System.Drawing.Point(332, 100);
            this.lblEtiquetaNombreCurso.Name = "lblEtiquetaNombreCurso";
            this.lblEtiquetaNombreCurso.Size = new System.Drawing.Size(92, 13);
            this.lblEtiquetaNombreCurso.TabIndex = 35;
            this.lblEtiquetaNombreCurso.Text = "Nombre de Curso:";
            // 
            // txtBusquedaCurso
            // 
            this.txtBusquedaCurso.Location = new System.Drawing.Point(335, 56);
            this.txtBusquedaCurso.Name = "txtBusquedaCurso";
            this.txtBusquedaCurso.Size = new System.Drawing.Size(134, 20);
            this.txtBusquedaCurso.TabIndex = 34;
            // 
            // lblBusquedaCursoTitulo
            // 
            this.lblBusquedaCursoTitulo.AutoSize = true;
            this.lblBusquedaCursoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaCursoTitulo.Location = new System.Drawing.Point(330, 20);
            this.lblBusquedaCursoTitulo.Name = "lblBusquedaCursoTitulo";
            this.lblBusquedaCursoTitulo.Size = new System.Drawing.Size(186, 25);
            this.lblBusquedaCursoTitulo.TabIndex = 33;
            this.lblBusquedaCursoTitulo.Text = "Busqueda de Curso";
            // 
            // lblApellidosInstructor
            // 
            this.lblApellidosInstructor.AutoSize = true;
            this.lblApellidosInstructor.Location = new System.Drawing.Point(83, 178);
            this.lblApellidosInstructor.Name = "lblApellidosInstructor";
            this.lblApellidosInstructor.Size = new System.Drawing.Size(27, 13);
            this.lblApellidosInstructor.TabIndex = 32;
            this.lblApellidosInstructor.Text = "N/A";
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.Location = new System.Drawing.Point(322, 212);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Size = new System.Drawing.Size(86, 28);
            this.btnAsignacion.TabIndex = 31;
            this.btnAsignacion.Text = "Asignar";
            this.btnAsignacion.UseVisualStyleBackColor = true;
            // 
            // lblNombresInstructor
            // 
            this.lblNombresInstructor.AutoSize = true;
            this.lblNombresInstructor.Location = new System.Drawing.Point(83, 154);
            this.lblNombresInstructor.Name = "lblNombresInstructor";
            this.lblNombresInstructor.Size = new System.Drawing.Size(27, 13);
            this.lblNombresInstructor.TabIndex = 30;
            this.lblNombresInstructor.Text = "N/A";
            // 
            // lblApellidosEtiqueta
            // 
            this.lblApellidosEtiqueta.AutoSize = true;
            this.lblApellidosEtiqueta.Location = new System.Drawing.Point(29, 179);
            this.lblApellidosEtiqueta.Name = "lblApellidosEtiqueta";
            this.lblApellidosEtiqueta.Size = new System.Drawing.Size(52, 13);
            this.lblApellidosEtiqueta.TabIndex = 29;
            this.lblApellidosEtiqueta.Text = "Apellidos:";
            // 
            // lblNombresEtiqueta
            // 
            this.lblNombresEtiqueta.AutoSize = true;
            this.lblNombresEtiqueta.Location = new System.Drawing.Point(29, 154);
            this.lblNombresEtiqueta.Name = "lblNombresEtiqueta";
            this.lblNombresEtiqueta.Size = new System.Drawing.Size(52, 13);
            this.lblNombresEtiqueta.TabIndex = 28;
            this.lblNombresEtiqueta.Text = "Nombres:";
            // 
            // dvgAsignaciones
            // 
            this.dvgAsignaciones.AllowUserToAddRows = false;
            this.dvgAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAsignaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgAsignaciones.Location = new System.Drawing.Point(17, 276);
            this.dvgAsignaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dvgAsignaciones.MultiSelect = false;
            this.dvgAsignaciones.Name = "dvgAsignaciones";
            this.dvgAsignaciones.RowTemplate.Height = 24;
            this.dvgAsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAsignaciones.Size = new System.Drawing.Size(722, 220);
            this.dvgAsignaciones.TabIndex = 27;
            // 
            // lblDatosInstructorTitulo
            // 
            this.lblDatosInstructorTitulo.AutoSize = true;
            this.lblDatosInstructorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosInstructorTitulo.Location = new System.Drawing.Point(28, 119);
            this.lblDatosInstructorTitulo.Name = "lblDatosInstructorTitulo";
            this.lblDatosInstructorTitulo.Size = new System.Drawing.Size(165, 22);
            this.lblDatosInstructorTitulo.TabIndex = 26;
            this.lblDatosInstructorTitulo.Text = "Datos del Instructor";
            // 
            // lblBusquedaInstructoresTitulo
            // 
            this.lblBusquedaInstructoresTitulo.AutoSize = true;
            this.lblBusquedaInstructoresTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaInstructoresTitulo.Location = new System.Drawing.Point(20, 24);
            this.lblBusquedaInstructoresTitulo.Name = "lblBusquedaInstructoresTitulo";
            this.lblBusquedaInstructoresTitulo.Size = new System.Drawing.Size(234, 25);
            this.lblBusquedaInstructoresTitulo.TabIndex = 25;
            this.lblBusquedaInstructoresTitulo.Text = "Busqueda de Instructores";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(25, 68);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(139, 20);
            this.txtDni.TabIndex = 24;
            // 
            // btnBusquedaDni
            // 
            this.btnBusquedaDni.Location = new System.Drawing.Point(209, 65);
            this.btnBusquedaDni.Name = "btnBusquedaDni";
            this.btnBusquedaDni.Size = new System.Drawing.Size(78, 23);
            this.btnBusquedaDni.TabIndex = 23;
            this.btnBusquedaDni.Text = "Buscar";
            this.btnBusquedaDni.UseVisualStyleBackColor = true;
            this.btnBusquedaDni.Click += new System.EventHandler(this.btnBusquedaDni_Click);
            // 
            // FrmMenuAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 582);
            this.Controls.Add(this.cmbAnioAcademico);
            this.Controls.Add(this.lblEtiquetaAnioAcademico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.cmbTipoBusquedaCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblEtiquetaNombreCurso);
            this.Controls.Add(this.txtBusquedaCurso);
            this.Controls.Add(this.lblBusquedaCursoTitulo);
            this.Controls.Add(this.lblApellidosInstructor);
            this.Controls.Add(this.btnAsignacion);
            this.Controls.Add(this.lblNombresInstructor);
            this.Controls.Add(this.lblApellidosEtiqueta);
            this.Controls.Add(this.lblNombresEtiqueta);
            this.Controls.Add(this.dvgAsignaciones);
            this.Controls.Add(this.lblDatosInstructorTitulo);
            this.Controls.Add(this.lblBusquedaInstructoresTitulo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBusquedaDni);
            this.Name = "FrmMenuAsignacion";
            this.Text = "Menu Asignacion";
            this.Shown += new System.EventHandler(this.FrmMenuAsignacion_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnioAcademico;
        private System.Windows.Forms.Label lblEtiquetaAnioAcademico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.ComboBox cmbTipoBusquedaCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblEtiquetaNombreCurso;
        private System.Windows.Forms.TextBox txtBusquedaCurso;
        private System.Windows.Forms.Label lblBusquedaCursoTitulo;
        private System.Windows.Forms.Label lblApellidosInstructor;
        private System.Windows.Forms.Button btnAsignacion;
        private System.Windows.Forms.Label lblNombresInstructor;
        private System.Windows.Forms.Label lblApellidosEtiqueta;
        private System.Windows.Forms.Label lblNombresEtiqueta;
        private System.Windows.Forms.DataGridView dvgAsignaciones;
        private System.Windows.Forms.Label lblDatosInstructorTitulo;
        private System.Windows.Forms.Label lblBusquedaInstructoresTitulo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBusquedaDni;
    }
}