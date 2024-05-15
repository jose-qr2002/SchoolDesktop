namespace WindowsFormsApp3.presentacion.reportes
{
    partial class FrmReporte
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
            this.dvgReporte = new System.Windows.Forms.DataGridView();
            this.grpReportes = new System.Windows.Forms.GroupBox();
            this.btnTotalMatriculados = new System.Windows.Forms.Button();
            this.btnTotalAsignados = new System.Windows.Forms.Button();
            this.btnSalirReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReporte)).BeginInit();
            this.grpReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgReporte
            // 
            this.dvgReporte.AllowUserToAddRows = false;
            this.dvgReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgReporte.Location = new System.Drawing.Point(263, 18);
            this.dvgReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dvgReporte.MultiSelect = false;
            this.dvgReporte.Name = "dvgReporte";
            this.dvgReporte.RowTemplate.Height = 24;
            this.dvgReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgReporte.Size = new System.Drawing.Size(472, 237);
            this.dvgReporte.TabIndex = 7;
            // 
            // grpReportes
            // 
            this.grpReportes.Controls.Add(this.btnTotalAsignados);
            this.grpReportes.Controls.Add(this.btnTotalMatriculados);
            this.grpReportes.Controls.Add(this.dvgReporte);
            this.grpReportes.Location = new System.Drawing.Point(25, 37);
            this.grpReportes.Name = "grpReportes";
            this.grpReportes.Size = new System.Drawing.Size(751, 291);
            this.grpReportes.TabIndex = 8;
            this.grpReportes.TabStop = false;
            this.grpReportes.Text = "Reportes";
            // 
            // btnTotalMatriculados
            // 
            this.btnTotalMatriculados.Location = new System.Drawing.Point(57, 33);
            this.btnTotalMatriculados.Name = "btnTotalMatriculados";
            this.btnTotalMatriculados.Size = new System.Drawing.Size(138, 43);
            this.btnTotalMatriculados.TabIndex = 8;
            this.btnTotalMatriculados.Text = "Total Matriculados";
            this.btnTotalMatriculados.UseVisualStyleBackColor = true;
            // 
            // btnTotalAsignados
            // 
            this.btnTotalAsignados.Location = new System.Drawing.Point(57, 99);
            this.btnTotalAsignados.Name = "btnTotalAsignados";
            this.btnTotalAsignados.Size = new System.Drawing.Size(138, 45);
            this.btnTotalAsignados.TabIndex = 9;
            this.btnTotalAsignados.Text = "Total Asignaciones";
            this.btnTotalAsignados.UseVisualStyleBackColor = true;
            // 
            // btnSalirReportes
            // 
            this.btnSalirReportes.Location = new System.Drawing.Point(363, 344);
            this.btnSalirReportes.Name = "btnSalirReportes";
            this.btnSalirReportes.Size = new System.Drawing.Size(95, 42);
            this.btnSalirReportes.TabIndex = 9;
            this.btnSalirReportes.Text = "Salir";
            this.btnSalirReportes.UseVisualStyleBackColor = true;
            this.btnSalirReportes.Click += new System.EventHandler(this.btnSalirReportes_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btnSalirReportes);
            this.Controls.Add(this.grpReportes);
            this.Name = "FrmReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dvgReporte)).EndInit();
            this.grpReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgReporte;
        private System.Windows.Forms.GroupBox grpReportes;
        private System.Windows.Forms.Button btnTotalAsignados;
        private System.Windows.Forms.Button btnTotalMatriculados;
        private System.Windows.Forms.Button btnSalirReportes;
    }
}