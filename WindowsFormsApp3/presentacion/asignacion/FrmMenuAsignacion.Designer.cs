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
            this.lblCursoNombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBusquedaCurso = new System.Windows.Forms.TextBox();
            this.lblBusquedaCursoTitulo = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidosEtiqueta = new System.Windows.Forms.Label();
            this.lblNombresEtiqueta = new System.Windows.Forms.Label();
            this.dvgMatriculados = new System.Windows.Forms.DataGridView();
            this.lblDatosAlumnoTitulo = new System.Windows.Forms.Label();
            this.lblBusquedaInstructoresTitulo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBusquedaDni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnioAcademico
            // 
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
            // lblCursoNombre
            // 
            this.lblCursoNombre.AutoSize = true;
            this.lblCursoNombre.Location = new System.Drawing.Point(430, 100);
            this.lblCursoNombre.Name = "lblCursoNombre";
            this.lblCursoNombre.Size = new System.Drawing.Size(27, 13);
            this.lblCursoNombre.TabIndex = 36;
            this.lblCursoNombre.Text = "N/A";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(332, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre de Curso:";
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
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(83, 178);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(27, 13);
            this.lblApellidos.TabIndex = 32;
            this.lblApellidos.Text = "N/A";
            // 
            // btnMatricula
            // 
            this.btnMatricula.Location = new System.Drawing.Point(322, 212);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(86, 28);
            this.btnMatricula.TabIndex = 31;
            this.btnMatricula.Text = "Matricular";
            this.btnMatricula.UseVisualStyleBackColor = true;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(83, 154);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(27, 13);
            this.lblNombres.TabIndex = 30;
            this.lblNombres.Text = "N/A";
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
            // dvgMatriculados
            // 
            this.dvgMatriculados.AllowUserToAddRows = false;
            this.dvgMatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatriculados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgMatriculados.Location = new System.Drawing.Point(17, 276);
            this.dvgMatriculados.Margin = new System.Windows.Forms.Padding(2);
            this.dvgMatriculados.MultiSelect = false;
            this.dvgMatriculados.Name = "dvgMatriculados";
            this.dvgMatriculados.RowTemplate.Height = 24;
            this.dvgMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMatriculados.Size = new System.Drawing.Size(722, 220);
            this.dvgMatriculados.TabIndex = 27;
            // 
            // lblDatosAlumnoTitulo
            // 
            this.lblDatosAlumnoTitulo.AutoSize = true;
            this.lblDatosAlumnoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlumnoTitulo.Location = new System.Drawing.Point(28, 119);
            this.lblDatosAlumnoTitulo.Name = "lblDatosAlumnoTitulo";
            this.lblDatosAlumnoTitulo.Size = new System.Drawing.Size(165, 22);
            this.lblDatosAlumnoTitulo.TabIndex = 26;
            this.lblDatosAlumnoTitulo.Text = "Datos del Instructor";
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
            this.Controls.Add(this.lblCursoNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBusquedaCurso);
            this.Controls.Add(this.lblBusquedaCursoTitulo);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidosEtiqueta);
            this.Controls.Add(this.lblNombresEtiqueta);
            this.Controls.Add(this.dvgMatriculados);
            this.Controls.Add(this.lblDatosAlumnoTitulo);
            this.Controls.Add(this.lblBusquedaInstructoresTitulo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBusquedaDni);
            this.Name = "FrmMenuAsignacion";
            this.Text = "FrmMenuAsignacion";
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnioAcademico;
        private System.Windows.Forms.Label lblEtiquetaAnioAcademico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.ComboBox cmbTipoBusquedaCurso;
        private System.Windows.Forms.Label lblCursoNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBusquedaCurso;
        private System.Windows.Forms.Label lblBusquedaCursoTitulo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidosEtiqueta;
        private System.Windows.Forms.Label lblNombresEtiqueta;
        private System.Windows.Forms.DataGridView dvgMatriculados;
        private System.Windows.Forms.Label lblDatosAlumnoTitulo;
        private System.Windows.Forms.Label lblBusquedaInstructoresTitulo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBusquedaDni;
    }
}