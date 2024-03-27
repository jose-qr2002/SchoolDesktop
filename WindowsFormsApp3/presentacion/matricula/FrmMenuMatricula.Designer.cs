namespace WindowsFormsApp3.presentacion.matricula
{
    partial class FrmMenuMatricula
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
            this.btnBusquedaDni = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblBusquedaDniTitulo = new System.Windows.Forms.Label();
            this.lblDatosAlumnoTitulo = new System.Windows.Forms.Label();
            this.dvgMatriculados = new System.Windows.Forms.DataGridView();
            this.lblNombresEtiqueta = new System.Windows.Forms.Label();
            this.lblApellidosEtiqueta = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.lblApellidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusquedaDni
            // 
            this.btnBusquedaDni.Location = new System.Drawing.Point(167, 72);
            this.btnBusquedaDni.Name = "btnBusquedaDni";
            this.btnBusquedaDni.Size = new System.Drawing.Size(75, 23);
            this.btnBusquedaDni.TabIndex = 0;
            this.btnBusquedaDni.Text = "Buscar";
            this.btnBusquedaDni.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(39, 74);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 1;
            // 
            // lblBusquedaDniTitulo
            // 
            this.lblBusquedaDniTitulo.AutoSize = true;
            this.lblBusquedaDniTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaDniTitulo.Location = new System.Drawing.Point(66, 18);
            this.lblBusquedaDniTitulo.Name = "lblBusquedaDniTitulo";
            this.lblBusquedaDniTitulo.Size = new System.Drawing.Size(166, 25);
            this.lblBusquedaDniTitulo.TabIndex = 2;
            this.lblBusquedaDniTitulo.Text = "Busqueda de DNI";
            // 
            // lblDatosAlumnoTitulo
            // 
            this.lblDatosAlumnoTitulo.AutoSize = true;
            this.lblDatosAlumnoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlumnoTitulo.Location = new System.Drawing.Point(303, 22);
            this.lblDatosAlumnoTitulo.Name = "lblDatosAlumnoTitulo";
            this.lblDatosAlumnoTitulo.Size = new System.Drawing.Size(151, 22);
            this.lblDatosAlumnoTitulo.TabIndex = 4;
            this.lblDatosAlumnoTitulo.Text = "Datos del Alumno";
            // 
            // dvgMatriculados
            // 
            this.dvgMatriculados.AllowUserToAddRows = false;
            this.dvgMatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatriculados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgMatriculados.Location = new System.Drawing.Point(42, 129);
            this.dvgMatriculados.Margin = new System.Windows.Forms.Padding(2);
            this.dvgMatriculados.MultiSelect = false;
            this.dvgMatriculados.Name = "dvgMatriculados";
            this.dvgMatriculados.RowTemplate.Height = 24;
            this.dvgMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMatriculados.Size = new System.Drawing.Size(614, 220);
            this.dvgMatriculados.TabIndex = 8;
            // 
            // lblNombresEtiqueta
            // 
            this.lblNombresEtiqueta.AutoSize = true;
            this.lblNombresEtiqueta.Location = new System.Drawing.Point(304, 57);
            this.lblNombresEtiqueta.Name = "lblNombresEtiqueta";
            this.lblNombresEtiqueta.Size = new System.Drawing.Size(52, 13);
            this.lblNombresEtiqueta.TabIndex = 9;
            this.lblNombresEtiqueta.Text = "Nombres:";
            // 
            // lblApellidosEtiqueta
            // 
            this.lblApellidosEtiqueta.AutoSize = true;
            this.lblApellidosEtiqueta.Location = new System.Drawing.Point(304, 82);
            this.lblApellidosEtiqueta.Name = "lblApellidosEtiqueta";
            this.lblApellidosEtiqueta.Size = new System.Drawing.Size(52, 13);
            this.lblApellidosEtiqueta.TabIndex = 10;
            this.lblApellidosEtiqueta.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(358, 57);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(27, 13);
            this.lblNombres.TabIndex = 11;
            this.lblNombres.Text = "N/A";
            // 
            // btnMatricula
            // 
            this.btnMatricula.Location = new System.Drawing.Point(565, 47);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(75, 47);
            this.btnMatricula.TabIndex = 12;
            this.btnMatricula.Text = "Matricular";
            this.btnMatricula.UseVisualStyleBackColor = true;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(358, 81);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(27, 13);
            this.lblApellidos.TabIndex = 13;
            this.lblApellidos.Text = "N/A";
            // 
            // FrmMenuMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidosEtiqueta);
            this.Controls.Add(this.lblNombresEtiqueta);
            this.Controls.Add(this.dvgMatriculados);
            this.Controls.Add(this.lblDatosAlumnoTitulo);
            this.Controls.Add(this.lblBusquedaDniTitulo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBusquedaDni);
            this.Name = "FrmMenuMatricula";
            this.Text = "FrnMenuMatricula";
            this.Shown += new System.EventHandler(this.FrmMenuMatricula_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusquedaDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblBusquedaDniTitulo;
        private System.Windows.Forms.Label lblDatosAlumnoTitulo;
        private System.Windows.Forms.DataGridView dvgMatriculados;
        private System.Windows.Forms.Label lblNombresEtiqueta;
        private System.Windows.Forms.Label lblApellidosEtiqueta;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Label lblApellidos;
    }
}