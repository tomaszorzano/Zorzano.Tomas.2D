namespace JardinApp
{
    partial class FrmSecundario
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
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFinal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(34, 237);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(109, 39);
            this.btnEvaluar.TabIndex = 0;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(16, 35);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(51, 13);
            this.lblDocente.TabIndex = 1;
            this.lblDocente.Text = "Docente:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(16, 70);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "Alumno:";
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(85, 32);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(171, 20);
            this.txtDocente.TabIndex = 3;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(85, 67);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(171, 20);
            this.txtAlumno.TabIndex = 4;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(16, 106);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(42, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota 1:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(218, 237);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 39);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nota 2:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(85, 136);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nota Final:";
            // 
            // numericUpDownFinal
            // 
            this.numericUpDownFinal.Location = new System.Drawing.Point(239, 122);
            this.numericUpDownFinal.Name = "numericUpDownFinal";
            this.numericUpDownFinal.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownFinal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Observaciones:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(22, 195);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(322, 20);
            this.txtObservacion.TabIndex = 13;
            // 
            // FrmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 286);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.btnEvaluar);
            this.Name = "FrmSecundario";
            this.Text = "Evaluacion";
            this.Load += new System.EventHandler(this.FrmSecundario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacion;
    }
}