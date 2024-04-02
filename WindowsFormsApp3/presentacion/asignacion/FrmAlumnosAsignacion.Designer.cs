namespace WindowsFormsApp3.presentacion.asignacion
{
    partial class FrmAlumnosAsignacion
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
            this.dvgMatriculados = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEtiquetaCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblEtiquetaAnioAcademico = new System.Windows.Forms.Label();
            this.lblAnioAcademico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgMatriculados
            // 
            this.dvgMatriculados.AllowUserToAddRows = false;
            this.dvgMatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatriculados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgMatriculados.Location = new System.Drawing.Point(37, 123);
            this.dvgMatriculados.Margin = new System.Windows.Forms.Padding(2);
            this.dvgMatriculados.MultiSelect = false;
            this.dvgMatriculados.Name = "dvgMatriculados";
            this.dvgMatriculados.RowTemplate.Height = 24;
            this.dvgMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMatriculados.Size = new System.Drawing.Size(722, 220);
            this.dvgMatriculados.TabIndex = 28;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(123, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(522, 31);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Alumnos Matriculados en la Asignacion";
            // 
            // lblEtiquetaCurso
            // 
            this.lblEtiquetaCurso.AutoSize = true;
            this.lblEtiquetaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaCurso.Location = new System.Drawing.Point(33, 61);
            this.lblEtiquetaCurso.Name = "lblEtiquetaCurso";
            this.lblEtiquetaCurso.Size = new System.Drawing.Size(65, 24);
            this.lblEtiquetaCurso.TabIndex = 30;
            this.lblEtiquetaCurso.Text = "Curso:";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(104, 69);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(68, 13);
            this.lblNombreCurso.TabIndex = 31;
            this.lblNombreCurso.Text = "nombrecurso";
            // 
            // lblEtiquetaAnioAcademico
            // 
            this.lblEtiquetaAnioAcademico.AutoSize = true;
            this.lblEtiquetaAnioAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaAnioAcademico.Location = new System.Drawing.Point(376, 61);
            this.lblEtiquetaAnioAcademico.Name = "lblEtiquetaAnioAcademico";
            this.lblEtiquetaAnioAcademico.Size = new System.Drawing.Size(151, 24);
            this.lblEtiquetaAnioAcademico.TabIndex = 32;
            this.lblEtiquetaAnioAcademico.Text = "Año Academico:";
            // 
            // lblAnioAcademico
            // 
            this.lblAnioAcademico.AutoSize = true;
            this.lblAnioAcademico.Location = new System.Drawing.Point(534, 69);
            this.lblAnioAcademico.Name = "lblAnioAcademico";
            this.lblAnioAcademico.Size = new System.Drawing.Size(80, 13);
            this.lblAnioAcademico.TabIndex = 33;
            this.lblAnioAcademico.Text = "año academico";
            // 
            // FrmAlumnosAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnioAcademico);
            this.Controls.Add(this.lblEtiquetaAnioAcademico);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblEtiquetaCurso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dvgMatriculados);
            this.Name = "FrmAlumnosAsignacion";
            this.Text = "Alumnos de Asignacion";
            this.Shown += new System.EventHandler(this.FrmAlumnosAsignacion_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgMatriculados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEtiquetaCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblEtiquetaAnioAcademico;
        private System.Windows.Forms.Label lblAnioAcademico;
    }
}